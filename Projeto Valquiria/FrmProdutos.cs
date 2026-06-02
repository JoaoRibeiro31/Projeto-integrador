using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class FrmProdutos : Form
    {
        private string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        private System.Windows.Forms.Timer timerPesquisa = new System.Windows.Forms.Timer();
        private DataTable tabela = new DataTable();
        private bool editando = false;

        public FrmProdutos()
        {
            InitializeComponent();

            btnAtualizar.Visible = false;
            btnDeletar.Visible = false;
            dgvDadosProdutos.ReadOnly = true;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregarDadosProdutos();

            // Cor de fundo geral da tabela
            dgvDadosProdutos.BackgroundColor = Color.FromArgb(240, 192, 229); // rosa pastel do layout

            // Linhas alternadas
            dgvDadosProdutos.DefaultCellStyle.BackColor = Color.White;
            dgvDadosProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220); // verde pastel suave

            // Texto das células
            dgvDadosProdutos.DefaultCellStyle.ForeColor = Color.FromArgb(40, 80, 40); // verde escuro
            dgvDadosProdutos.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(40, 80, 40);

            // Seleção
            dgvDadosProdutos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(92, 184, 92); // verde vibrante (botão Produtos)
            dgvDadosProdutos.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho
            dgvDadosProdutos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 192, 229); // rosa pastel
            dgvDadosProdutos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);   // lilás escuro
            dgvDadosProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvDadosProdutos.EnableHeadersVisualStyles = false;

            // Bordas e estilo geral
            dgvDadosProdutos.GridColor = Color.FromArgb(200, 230, 200);
            dgvDadosProdutos.BorderStyle = BorderStyle.None;
            dgvDadosProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Centraliza o texto do cabeçalho (títulos das colunas)
            dgvDadosProdutos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // ---------- CARREGAR PRODUTOS ----------
        public void CarregarDadosProdutos(string filtro = "")
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT id AS Id,
                                          nome AS Nome,
                                          valor AS Valor
                                   FROM produtos
                                   WHERE (nome LIKE @filtro
                                          OR valor LIKE @filtro)
                                   ORDER BY nome ASC;";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    dgvDadosProdutos.DataSource = tabela;
                    dgvDadosProdutos.Columns["Id"].Visible = false;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ---------- PESQUISA COM DELAY ----------
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
            timerPesquisa.Interval = 500; // meio segundo

            timerPesquisa.Tick -= TimerPesquisa_Tick;
            timerPesquisa.Tick += TimerPesquisa_Tick;

            timerPesquisa.Start();
        }

        private void TimerPesquisa_Tick(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
            CarregarDadosProdutos(txtPesquisar.Text);
        }

        // ---------- CADASTRAR PRODUTO ----------
        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar o produto!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text.Trim();
            string valorTexto = txtValor.Text.Trim();

            if (nome.Length > 80)
                nome = nome.Substring(0, 80);

            Regex regexNome = new Regex(@"^[A-Za-zÀ-ÿ\s'-]+$");
            nome = Regex.Replace(nome, @"\s+", " ");
            if (!regexNome.IsMatch(nome) || nome.Trim().Length < 2)
            {
                MessageBox.Show("Digite um nome válido para o produto!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            nome = textInfo.ToTitleCase(nome.ToLower());

            if (!decimal.TryParse(valorTexto, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Digite um valor válido (somente números, use vírgula para decimais)!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (valor > 999)
            {
                MessageBox.Show("O valor do produto não pode ser maior que 999!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sqlCheck = "SELECT COUNT(*) FROM produtos WHERE nome = @nome";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@nome", nome);

                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (existe > 0)
                    {
                        MessageBox.Show("Já existe um produto com este nome!",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult confirmacao = MessageBox.Show(
                        $"Confirma cadastrar o produto '{nome}'?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacao == DialogResult.No) return;

                    string sql = @"INSERT INTO produtos (nome, valor) VALUES (@nome, @valor)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Produto '{nome}' cadastrado com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao cadastrar produto: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarDadosProdutos();
            txtNome.Clear();
            txtValor.Clear();
        }

        // ---------- HABILITAR EDIÇÃO ----------
        private void btnEdicao_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                dgvDadosProdutos.ReadOnly = false;
                btnAtualizar.Visible = true;
                btnDeletar.Visible = true;
                editando = true;
            }
            else
            {
                dgvDadosProdutos.ReadOnly = true;
                btnAtualizar.Visible = false;
                btnDeletar.Visible = false;
                editando = false;
            }
        }
        // ---------- ATUALIZAR ----------
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int contadorAtualizados = 0;

            DialogResult confirmacao = MessageBox.Show(
                "Confirma atualizar os produtos?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No) return;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvDadosProdutos.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        string nome = row.Cells["Nome"].Value.ToString().Trim();
                        string valorTexto = row.Cells["Valor"].Value.ToString().Trim();

                        if (nome.Length > 80)
                            nome = nome.Substring(0, 80);

                        TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                        nome = textInfo.ToTitleCase(nome.ToLower());

                        if (!decimal.TryParse(valorTexto, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valor) || valor <= 0)
                            continue;

                        string sqlCheck = "SELECT nome, valor FROM produtos WHERE id = @id";
                        MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                        cmdCheck.Parameters.AddWithValue("@id", id);

                        using (var reader = cmdCheck.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nomeAtual = reader.GetString("nome");
                                decimal valorAtual = reader.GetDecimal("valor");

                                if (nome != nomeAtual || valor != valorAtual)
                                {
                                    reader.Close();
                                    string sql = "UPDATE produtos SET nome = @nome, valor = @valor WHERE id = @id";
                                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                                    cmd.Parameters.AddWithValue("@nome", nome);
                                    cmd.Parameters.AddWithValue("@valor", valor);
                                    cmd.Parameters.AddWithValue("@id", id);
                                    cmd.ExecuteNonQuery();
                                    contadorAtualizados++;
                                }
                            }
                        }
                    }

                    if (contadorAtualizados == 0)
                        MessageBox.Show("Nenhuma alteração realizada.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (contadorAtualizados == 1)
                        MessageBox.Show("Produto atualizado com sucesso!",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"Produtos atualizados com sucesso! ({contadorAtualizados} registros)",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao atualizar produtos: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarDadosProdutos();
        }

        // ---------- DELETAR ----------
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvDadosProdutos.CurrentRow == null || dgvDadosProdutos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecione um produto para excluir!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvDadosProdutos.CurrentRow.Cells["Id"].Value);
            string nome = dgvDadosProdutos.CurrentRow.Cells["Nome"].Value.ToString();

            DialogResult confirmacao = MessageBox.Show(
                $"Confirma excluir o produto '{nome}'?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.No) return;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM produtos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Produto '{nome}' excluído com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao excluir produto: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarDadosProdutos();
        }

        // ---------- NAVEGAÇÃO ----------
        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelConteudo tela = new panelConteudo();
            tela.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.Show();
            this.Hide();
        }
    }
}
