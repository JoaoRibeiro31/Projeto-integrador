using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class FrmClientes : Form
    {
        private string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        private System.Windows.Forms.Timer timerPesquisa = new System.Windows.Forms.Timer();
        private bool editando = false;

        public FrmClientes()
        {
            InitializeComponent();
            btnAtualizar.Visible = false;
            btnDeletar.Visible = false;
            dgvDadosClientes.ReadOnly = true;
        }

        // ---------- LOAD ----------
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //Teste de conexão
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                }
            }
            catch (MySqlException ex)
            {
                ErroHelper.MostrarErro("Erro de Conexão", "Não foi possível conectar ao banco de dados.");
                ErroHelper.LogErro(ex);
            }

            CarregarDadosClientes();

            // Cor de fundo geral da tabela
            dgvDadosClientes.BackgroundColor = Color.FromArgb(255, 220, 235);

            // Linhas alternadas (efeito suave)
            dgvDadosClientes.DefaultCellStyle.BackColor = Color.White;
            dgvDadosClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 240, 245);

            // Texto das células
            dgvDadosClientes.DefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);
            dgvDadosClientes.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);

            // Cor da seleção
            dgvDadosClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 100, 150);
            dgvDadosClientes.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho
            dgvDadosClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 200, 220);
            dgvDadosClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);
            dgvDadosClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvDadosClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 200, 220);
            dgvDadosClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(80, 40, 100);

            // Bordas e estilo geral
            dgvDadosClientes.GridColor = Color.FromArgb(220, 180, 200);
            dgvDadosClientes.BorderStyle = BorderStyle.None;
            dgvDadosClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Borda arredondada
            UIHelper.ArredondarBorda(btnPedidos, 20);
            UIHelper.ArredondarBorda(btnProdutos, 20);
            UIHelper.ArredondarBorda(btnClientes, 20);
            UIHelper.ArredondarBorda(btnHome, 20);
            UIHelper.ArredondarBorda(dgvDadosClientes, 20);
            UIHelper.ArredondarBorda(tlpCadastro, 20);
            UIHelper.ArredondarBorda(btnCadastrar, 20);
        }

        // ---------- CARREGAR CLIENTES ----------
        public void CarregarDadosClientes(string filtro = "")
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT id AS Id,
                                          nome AS Nome,
                                          contato AS Contato,
                                          data_de_cadastro AS Cadastro
                                   FROM clientes
                                   WHERE (nome LIKE @filtro
                                          OR contato LIKE @filtro
                                          OR data_de_cadastro LIKE @filtro)
                                   ORDER BY nome ASC;";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    dgvDadosClientes.DataSource = tabela;
                    dgvDadosClientes.Columns["Id"].Visible = false;
                }
                catch (Exception ex)
                {
                    ErroHelper.MostrarErro("Erro ao carregar clientes", "Não foi possível carregar os dados.");
                    ErroHelper.LogErro(ex);
                }
            }
        }

        // ---------- PESQUISA COM DELAY ----------
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
            timerPesquisa.Interval = 500;

            timerPesquisa.Tick -= TimerPesquisa_Tick;
            timerPesquisa.Tick += TimerPesquisa_Tick;

            timerPesquisa.Start();
        }

        private void TimerPesquisa_Tick(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
            CarregarDadosClientes(txtPesquisar.Text);
        }

        // ---------- CADASTRAR CLIENTE ----------
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtContato.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text.Trim();
            string contato = txtContato.Text.Trim();

            if (nome.Length > 120 || contato.Length > 80)
            {
                ErroHelper.MostrarAviso("Nome ou contato excedem o limite de caracteres!");
                return;
            }

            Regex regexNome = new Regex(@"^[A-Za-zÀ-ÿ\s'-]+$");
            nome = Regex.Replace(nome, @"\s+", " ");

            if (!regexNome.IsMatch(nome) || nome.Trim().Length < 2)
            {
                ErroHelper.MostrarAviso("Digite um nome válido!");
                return;
            }

            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            nome = textInfo.ToTitleCase(nome.ToLower());

            Regex regexTelefone = new Regex(@"^\d{8,}$");
            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!regexTelefone.IsMatch(contato) && !regexEmail.IsMatch(contato))
            {
                ErroHelper.MostrarAviso("O contato deve ser um telefone válido ou um e-mail válido!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sqlCheck = "SELECT COUNT(*) FROM clientes WHERE nome = @nome OR contato = @contato;";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@nome", nome);
                    cmdCheck.Parameters.AddWithValue("@contato", contato);

                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (existe > 0)
                    {
                        ErroHelper.MostrarAviso("Já existe um cliente com este nome ou contato!");
                        return;
                    }

                    DialogResult confirmacao = MessageBox.Show(
                        $"Confirma cadastrar o(a) '{nome}'?",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacao == DialogResult.No) return;



                    string sql = @"INSERT INTO clientes (nome, contato) VALUES (@nome, @contato)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@contato", contato);
                    cmd.ExecuteNonQuery();

                    ErroHelper.MostrarSucesso($"Cliente '{nome}' cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    ErroHelper.MostrarErro("Erro ao cadastrar cliente", ex.Message);
                    ErroHelper.LogErro(ex);
                }
            }

            CarregarDadosClientes();
            txtNome.Clear();
            txtContato.Clear();
        }

        // ---------- HABILITAR EDIÇÃO ----------
        private void btnEdicao_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                dgvDadosClientes.ReadOnly = false;
                btnAtualizar.Visible = true;
                btnDeletar.Visible = true;
                editando = true;
            }
            else
            {
                dgvDadosClientes.ReadOnly = true;
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
                "Confirma atualizar os clientes?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No) return;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvDadosClientes.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        string nome = row.Cells["Nome"].Value.ToString().Trim();
                        string contato = row.Cells["Contato"].Value.ToString().Trim();

                        string sqlCheck = "SELECT nome, contato FROM clientes WHERE id = @id";
                        MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                        cmdCheck.Parameters.AddWithValue("@id", id);

                        bool houveAlteracao = false;
                        using (var reader = cmdCheck.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nomeAtual = reader.GetString("nome");
                                string contatoAtual = reader.GetString("contato");

                                if (nome != nomeAtual || contato != contatoAtual)
                                    houveAlteracao = true;
                            }
                        }

                        if (houveAlteracao)
                        {
                            string sql = "UPDATE clientes SET nome = @nome, contato = @contato WHERE id = @id";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@contato", contato);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            contadorAtualizados++;
                        }
                    }

                    if (contadorAtualizados == 0)
                        MessageBox.Show("Nenhuma alteração realizada.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (contadorAtualizados == 1)
                        ErroHelper.MostrarSucesso("Produtos atualizados com sucesso!");
                    else
                        ErroHelper.MostrarSucesso($"Clientes atualizados com sucesso! ({contadorAtualizados} registros)");
                }
                catch (Exception ex)
                {
                    ErroHelper.MostrarErro("Erro ao atualizar clientes: ", ex.Message);
                    ErroHelper.LogErro(ex);
                }
            }

            CarregarDadosClientes();
        }

        // ---------- DELETAR ----------
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvDadosClientes.CurrentRow == null || dgvDadosClientes.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecione um cliente para excluir!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = dgvDadosClientes.CurrentRow.Cells["Nome"].Value.ToString();

            DialogResult confirmacao = MessageBox.Show(
                $"Confirma excluir o(a) cliente '{nome}'?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.No) return;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM clientes WHERE nome = @nome";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Cliente '{nome}' excluído com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarDadosClientes();
        }


        // ---------- NAVEGAÇÃO ----------
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.Show();
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome tela = new FrmHome();
            tela.Show();
            this.Hide();
        }
    }
}
