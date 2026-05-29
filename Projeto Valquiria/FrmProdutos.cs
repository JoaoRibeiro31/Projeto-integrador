using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class FrmProdutos : Form
    {
        MySqlConnection Conexao;
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        DataTable tabela = new DataTable();
        bool editando = false;

        public FrmProdutos()
        {
            InitializeComponent();

            // Botões começam invisíveis
            btnAtualizar.Visible = false;
            btnDeletar.Visible = false;
            btnEdicao.Text = "Habilitar Edição";
        }

        public void CarregarDadosProdutos()
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
                                   ORDER BY nome ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    tabela = new DataTable();
                    adapter.Fill(tabela);

                    dgvDadosProdutos.DataSource = tabela;
                    dgvDadosProdutos.Columns["Id"].Visible = false;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
            }
        }

        private void FrmProdutos_Load_1(object sender, EventArgs e)
        {
            CarregarDadosProdutos();
        }

        // Botão habilitar edição
        private void btnEdicao_Click_1(object sender, EventArgs e)
        {
            if (!editando)
            {
                dgvDadosProdutos.ReadOnly = false;
                btnAtualizar.Visible = true;
                btnDeletar.Visible = true;
                btnEdicao.Text = "Bloquear Edição";
                editando = true;
            }
            else
            {
                dgvDadosProdutos.ReadOnly = true;
                btnAtualizar.Visible = false;
                btnDeletar.Visible = false;
                btnEdicao.Text = "Habilitar Edição";
                editando = false;
            }
        }

        // Botão cadastrar produto
        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar!",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // interrompe o cadastro
            }

            DialogResult confirmacao = MessageBox.Show(
                "Confirma cadastrar este produto?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacao == DialogResult.No)
                return;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO produtos (nome, valor) VALUES (@nome, @valor)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@valor", decimal.Parse(txtValor.Text, new System.Globalization.CultureInfo("pt-BR")));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
            }

            MessageBox.Show("Produto cadastrado com sucesso!");
            CarregarDadosProdutos();

            // Limpa os campos após cadastro
            txtNome.Clear();
            txtValor.Clear();
        }

        // Botão atualizar (salva alterações feitas na tabela)
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show(
                "Confirma atualizar os produtos?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacao == DialogResult.No)
                return;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvDadosProdutos.Rows)
                {
                    if (row.IsNewRow) continue;

                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    string nome = row.Cells["Nome"].Value.ToString();
                    decimal valor = Convert.ToDecimal(row.Cells["Valor"].Value);

                    string sql = "UPDATE produtos SET nome = @nome, valor = @valor WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Produtos atualizados com sucesso!");
            CarregarDadosProdutos();
        }

        // Botão deletar (remove linha selecionada)
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvDadosProdutos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDadosProdutos.CurrentRow.Cells["Id"].Value);
                string nome = dgvDadosProdutos.CurrentRow.Cells["Nome"].Value.ToString();

                DialogResult confirmacao = MessageBox.Show(
                    $"Confirma excluir o produto '{nome}'?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacao == DialogResult.No)
                    return;

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "DELETE FROM produtos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto excluído com sucesso!");
                CarregarDadosProdutos();
            }
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

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.ShowDialog();
            this.Close();
        }
    }
}

