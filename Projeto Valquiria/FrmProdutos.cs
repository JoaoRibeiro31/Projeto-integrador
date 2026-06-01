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
            InitializeComponent(); // garante que os controles sejam criados

            // Agora sim pode acessar os botões
            btnAtualizar.Visible = false;
            btnDeletar.Visible = false;
            btnEdicao.Text = "Habilitar Edição";

            dgvDadosProdutos.ReadOnly = true; // trava edição ao abrir
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
                MessageBox.Show("Erro ao carregar produtos: " + erro.Message);
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
            string nome = txtNome.Text.Trim();
            string valorTexto = txtValor.Text.Trim();

            // 🔒 Limite de caracteres do nome
            if (nome.Length > 80)
                nome = nome.Substring(0, 80);

            // Validação de nome
            Regex regexNome = new Regex(@"^[A-Za-zÀ-ÿ\s]+$");
            if (!regexNome.IsMatch(nome) || nome.Length < 2)
            {
                MessageBox.Show("Digite um nome válido (somente letras e espaços)!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔄 Formatar nome para Title Case
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
            nome = textInfo.ToTitleCase(nome.ToLower());

            // 🔒 Validação e formatação do valor
            if (!decimal.TryParse(valorTexto, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Digite um valor válido (número positivo)!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Converter para string e aplicar regra de casas decimais
            string valorFormatado = valor.ToString("F10", new CultureInfo("pt-BR"));
            string[] partes = valorFormatado.Split(',');

            string parteInteira = partes[0];
            string parteDecimal = partes.Length > 1 ? partes[1] : "";

            // Máximo 2 dígitos antes da vírgula
            if (parteInteira.Length > 2)
                parteInteira = parteInteira.Substring(parteInteira.Length - 2);

            // Máximo 10 dígitos depois da vírgula
            if (parteDecimal.Length > 10)
                parteDecimal = parteDecimal.Substring(0, 10);

            valorFormatado = parteInteira + (parteDecimal != "" ? "," + parteDecimal : "");
            valor = decimal.Parse(valorFormatado, new CultureInfo("pt-BR"));

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

                    // 🔒 Nome máximo 80 caracteres
                    if (nome.Length > 80)
                        nome = nome.Substring(0, 80);

                    // 🔄 Formatar nome
                    TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                    nome = textInfo.ToTitleCase(nome.ToLower());

                    // 🔒 Valor com regra de casas decimais
                    if (!decimal.TryParse(valorTexto, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valor) || valor <= 0)
                        continue;

                    string valorFormatado = valor.ToString("F10", new CultureInfo("pt-BR"));
                    string[] partes = valorFormatado.Split(',');
                    string parteInteira = partes[0];
                    string parteDecimal = partes.Length > 1 ? partes[1] : "";

                    if (parteInteira.Length > 2)
                        parteInteira = parteInteira.Substring(parteInteira.Length - 2);
                    if (parteDecimal.Length > 10)
                        parteDecimal = parteDecimal.Substring(0, 10);

                    valorFormatado = parteInteira + (parteDecimal != "" ? "," + parteDecimal : "");
                    valor = decimal.Parse(valorFormatado, new CultureInfo("pt-BR"));

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

            string nome = dgvDadosProdutos.CurrentRow.Cells["Nome"].Value.ToString();

            DialogResult confirmacao = MessageBox.Show(
                $"Confirma excluir o produto '{nome}'?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.No) return;

            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = "DELETE FROM produtos WHERE nome = @nome";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nome);
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

        // Pesquisa
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisar.Text.Replace("'", "''");
            tabela.DefaultView.RowFilter = $"Nome LIKE '%{filtro}%'";
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelConteudo tela = new panelConteudo();
            tela.ShowDialog();
            this.Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.ShowDialog();
            this.Close();
        }
    }
}
