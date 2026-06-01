using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Projeto_Valquiria
{
    public partial class FrmClientes : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        private bool editando = false; // controle de edição

        public FrmClientes()
        {
            InitializeComponent();
        }

        public void CarregarDadosClientes()
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = @"SELECT id AS Id,
                                      nome AS Nome,
                                      contato AS Contato,
                                      data_de_cadastro AS Cadastro
                               FROM clientes
                               ORDER BY data_de_cadastro DESC;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);

                dvgTabela.DataSource = tabela;
                dvgTabela.Columns["Id"].Visible = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar clientes: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CarregarDadosClientes();

            // 🔄 Botões começam invisíveis
            btnAtualizar.Visible = false;
            btnDeletar.Visible = false;

            // tabela começa bloqueada
            dvgTabela.ReadOnly = true;
        }

        // ---------- CADASTRAR ----------
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();      // remove espaços extras
            string contato = txtContato.Text.Trim();

            // Limite de caracteres
            if (nome.Length > 120)
            {
                MessageBox.Show("O nome deve ter no máximo 120 caracteres!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contato.Length > 80)
            {
                MessageBox.Show("O contato deve ter no máximo 80 caracteres!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação de nome (não pode ter números ou caracteres especiais)
            Regex regexNome = new Regex(@"^[A-Za-zÀ-ÿ\s]+$"); // letras e espaços
            if (!regexNome.IsMatch(nome) || nome.Length < 2)
            {
                MessageBox.Show("Digite um nome válido (somente letras e espaços)!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Formatar nome para Title Case (primeira letra maiúscula em cada palavra)
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            nome = textInfo.ToTitleCase(nome.ToLower());

            // Validação de contato (telefone ou email)
            Regex regexTelefone = new Regex(@"^\d{8,}$");
            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!regexTelefone.IsMatch(contato) && !regexEmail.IsMatch(contato))
            {
                MessageBox.Show("O contato deve ser um número de telefone válido ou um e-mail válido!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se passou nas validações, insere no banco
            MySqlConnection conn = new MySqlConnection(conexao);

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
            finally
            {
                conn.Close();
            }

            CarregarDadosClientes();

            txtNome.Clear();
            txtContato.Clear();
        }

        // ---------- PESQUISA ----------
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtPesquisar.Text.Replace("'", "''");

                if (string.IsNullOrWhiteSpace(filtro))
                {
                    (dvgTabela.DataSource as DataTable).DefaultView.RowFilter = "";
                }
                else
                {
                    (dvgTabela.DataSource as DataTable).DefaultView.RowFilter =
                        $"Nome LIKE '%{filtro}%' OR " +
                        $"Contato LIKE '%{filtro}%' OR " +
                        $"Convert(Cadastro, 'System.String') LIKE '%{filtro}%'";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao aplicar filtro de pesquisa: " + erro.Message);
            }
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
            int contadorAtualizados = 0; // contador de alterações

            DialogResult confirmacao = MessageBox.Show(
                "Confirma atualizar os clientes?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No) return;

            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();

                foreach (DataGridViewRow row in dvgTabela.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool houveAlteracaoLinha = false;

                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    string nome = row.Cells["Nome"].Value.ToString().Trim();
                    string contato = row.Cells["Contato"].Value.ToString().Trim();

                    // 🔒 Validação de tamanho
                    if (nome.Length > 120)
                    {
                        MessageBox.Show($"O nome do(a) cliente (ID {id}) excede 120 caracteres!",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    if (contato.Length > 80)
                    {
                        MessageBox.Show($"O contato do(a) cliente (ID {id}) excede 80 caracteres!",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    // 🔒 Validação de nome (somente letras e espaços)
                    Regex regexNome = new Regex(@"^[A-Za-zÀ-ÿ\s]+$");
                    if (!regexNome.IsMatch(nome) || nome.Length < 2)
                    {
                        MessageBox.Show($"O nome do(a) cliente (ID {id}) não é válido!",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    // 🔄 Formatar nome para Title Case
                    TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                    nome = textInfo.ToTitleCase(nome.ToLower());

                    // 🔒 Validação de contato (telefone ou email)
                    Regex regexTelefone = new Regex(@"^\d{8,}$");
                    Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                    if (!regexTelefone.IsMatch(contato) && !regexEmail.IsMatch(contato))
                    {
                        MessageBox.Show($"O contato do(a) cliente (ID {id}) não é válido. Deve ser telefone ou email!",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    // Verifica se houve alteração
                    string sqlCheck = "SELECT nome, contato FROM clientes WHERE id = @id";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@id", id);

                    using (var reader = cmdCheck.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomeAtual = reader.GetString("nome");
                            string contatoAtual = reader.GetString("contato");

                            if (nome != nomeAtual || contato != contatoAtual)
                            {
                                houveAlteracaoLinha = true;
                            }
                        }
                    }

                    if (houveAlteracaoLinha)
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

                // Mensagens mais elegantes e profissionais
                if (contadorAtualizados == 0)
                {
                    MessageBox.Show("Nenhuma alteração detectada.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (contadorAtualizados == 1)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Clientes atualizados com sucesso! ({contadorAtualizados} registros)",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar clientes: " + erro.Message);
            }
            finally
            {
                conn.Close();
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

            MySqlConnection conn = new MySqlConnection(conexao);

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
                MessageBox.Show("Erro ao excluir o(a) cliente: " + erro.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            CarregarDadosClientes();
        }


        // ---------- NAVEGAÇÃO ----------
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelConteudo tela = new panelConteudo();
            tela.ShowDialog();
            this.Close();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.ShowDialog();
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.ShowDialog();
            this.Close();
        }

        private void dvgTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
S