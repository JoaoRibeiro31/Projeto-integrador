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
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        DataTable tabela = new DataTable();
        bool editando = false;

        public FrmProdutos()
        {
            InitializeComponent();

            // Botões começam invisíveis
            btnAtualizar.Visible = false;
            btnDeletar.Visible = false;

            // 🔒 Travar edição da tabela ao abrir
            dgvDadosProdutos.ReadOnly = true;
        }

        public void CarregarDadosProdutos()
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = @"SELECT id AS Id,
                                      nome AS Nome,
                                      valor AS Valor
                               FROM produtos
                               ORDER BY nome ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                tabela = new DataTable();
                adapter.Fill(tabela);

                dgvDadosProdutos.DataSource = tabela;
                dgvDadosProdutos.Columns["Id"].Visible = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar produtos: " + erro.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregarDadosProdutos();
        }

        // Botão habilitar edição
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

        // Botão cadastrar produto
        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            // 🚫 Verificação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar o produto!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text.Trim();
            string valorTexto = txtValor.Text.Trim();

            // 🔒 Limite de caracteres do nome
            if (nome.Length > 80)
                nome = nome.Substring(0, 80);

            // 🔒 Validação de nome (letras, espaços, hífen e apóstrofo)
            Regex regexNome = new Regex(@"^[A-Za-zÀ-ÿ\s'-]+$");
            nome = Regex.Replace(nome, @"\s+", " ");
            if (!regexNome.IsMatch(nome) || nome.Trim().Length < 2)
            {
                MessageBox.Show("Digite um nome válido para o produto!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔄 Formatar nome para Title Case
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            nome = textInfo.ToTitleCase(nome.ToLower());

            // 🔒 Validação e formatação do valor
            if (!decimal.TryParse(valorTexto, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valor))
            {
                MessageBox.Show("Digite um valor válido (somente números, use vírgula para decimais)!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (valor <= 0)
            {
                MessageBox.Show("O valor do produto deve ser maior que 0!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (valor > 999)
            {
                MessageBox.Show("O valor do produto não pode ser maior que 999!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conn = new MySqlConnection(conexao);

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
            finally
            {
                conn.Close();
            }

            CarregarDadosProdutos();
            txtNome.Clear();
            txtValor.Clear();
        }

        // Botão atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int contadorAtualizados = 0;

            DialogResult confirmacao = MessageBox.Show(
                "Confirma atualizar os produtos?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No) return;

            MySqlConnection conn = new MySqlConnection(conexao);

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

                    // Verifica se houve alteração
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
                    MessageBox.Show("Nenhuma alteração detectada.",
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
            finally
            {
                conn.Close();
            }

            CarregarDadosProdutos();
        }

        // Botão deletar (remove linha selecionada)
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

            MySqlConnection conn = new MySqlConnection(conexao);

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
            finally
            {
                conn.Close();
            }

            CarregarDadosProdutos();
        }

        // Pesquisa em tempo real
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisar.Text.Replace("'", "''");
            tabela.DefaultView.RowFilter = $"Nome LIKE '%{filtro}%'";
        }

        // Navegação para Pedidos
        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.Show();
            this.Hide();
        }

        // Navegação para Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            panelConteudo tela = new panelConteudo();
            tela.Show();
            this.Hide();
        }

        // Navegação para Clientes
        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.Show();
            this.Hide();
        }
    }
}
