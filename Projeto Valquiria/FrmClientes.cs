using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class FrmClientes : Form
    {
        private string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        private bool editando = false;
        private System.Windows.Forms.Timer timerPesquisa = new System.Windows.Forms.Timer();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CarregarDadosClientes();

            btnAtualizar.Visible = false;
            btnDeletar.Visible = false;
            dvgTabela.ReadOnly = true;

            // Cor de fundo geral da tabela
            dvgTabela.BackgroundColor = Color.FromArgb(240, 192, 229); // rosa pastel do layout

            // Linhas alternadas
            dvgTabela.DefaultCellStyle.BackColor = Color.White;
            dvgTabela.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 245, 200); // amarelo pastel suave

            // Texto das células
            dvgTabela.DefaultCellStyle.ForeColor = Color.FromArgb(100, 80, 20); // marrom/amarelo escuro
            dvgTabela.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(100, 80, 20);

            // Seleção
            dvgTabela.DefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 208, 23); // amarelo vibrante (igual ao botão Clientes)
            dvgTabela.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho
            dvgTabela.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 192, 229); // rosa pastel
            dvgTabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);   // lilás escuro
            dvgTabela.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dvgTabela.EnableHeadersVisualStyles = false;

            // Bordas e estilo geral
            dvgTabela.GridColor = Color.FromArgb(230, 210, 150);
            dvgTabela.BorderStyle = BorderStyle.None;
            dvgTabela.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Centraliza o texto do cabeçalho (títulos das colunas)
            dvgTabela.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Borda arredondada
            UIHelper.ArredondarBorda(btnPedidos, 20);
            UIHelper.ArredondarBorda(btnProdutos, 20);
            UIHelper.ArredondarBorda(btnClientes, 20);
            UIHelper.ArredondarBorda(btnHome, 20);
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

                    dvgTabela.DataSource = tabela;
                    dvgTabela.Columns["Id"].Visible = false;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ---------- CADASTRAR ----------
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
                MessageBox.Show("Nome ou contato excedem o limite de caracteres!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Regex regexNome = new Regex(@"^[A-Za-zÀ-ÿ\s'-]+$");
            nome = Regex.Replace(nome, @"\s+", " ");
            if (!regexNome.IsMatch(nome) || nome.Trim().Length < 2)
            {
                MessageBox.Show("Digite um nome válido!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            nome = textInfo.ToTitleCase(nome.ToLower());

            Regex regexTelefone = new Regex(@"^\d{8,}$");
            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regexTelefone.IsMatch(contato) && !regexEmail.IsMatch(contato))
            {
                MessageBox.Show("O contato deve ser um telefone válido ou um e-mail válido!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO clientes (nome, contato) VALUES (@nome, @contato)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@contato", contato);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Cliente '{nome}' cadastrado com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarDadosClientes();
            txtNome.Clear();
            txtContato.Clear();
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
            CarregarDadosClientes(txtPesquisar.Text);
        }

        // ---------- EDIÇÃO ----------
        private void btnEdicao_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                dvgTabela.ReadOnly = false;
                btnAtualizar.Visible = true;
                btnDeletar.Visible = true;
                editando = true;
            }
            else
            {
                dvgTabela.ReadOnly = true;
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

                    foreach (DataGridViewRow row in dvgTabela.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        string nome = row.Cells["Nome"].Value.ToString().Trim();
                        string contato = row.Cells["Contato"].Value.ToString().Trim();

                        // Verifica se houve alteração comparando com o banco
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
                        MessageBox.Show("Cliente atualizado com sucesso!",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"Clientes atualizados com sucesso! ({contadorAtualizados} registros)",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao atualizar clientes: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarDadosClientes();
        }

        // ---------- DELETAR ----------
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dvgTabela.CurrentRow == null || dvgTabela.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecione um cliente para excluir!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = dvgTabela.CurrentRow.Cells["Nome"].Value.ToString();

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
            FrmClientes tela = new FrmClientes();
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
