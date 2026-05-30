using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class FrmClientes : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelConteudo tela = new panelConteudo();
            tela.ShowDialog();
            this.Close();
        }

        public void CarregarDadosClientes()
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = @"SELECT nome AS Nome,
                                      contato AS Contato,
                                      data_de_cadastro AS Cadastro
                               FROM clientes
                               ORDER BY data_de_cadastro DESC;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);

                dvgTabela.DataSource = tabela;
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


        private void btnCliente_Click(object sender, EventArgs e)
        {
            // Validação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtContato.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar o cliente!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = @"INSERT INTO clientes (nome, contato) VALUES (@nome, @contato)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@contato", txtContato.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }

            CarregarDadosClientes();

            // 🔄 Limpa os campos após cadastro
            txtNome.Clear();
            txtContato.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.ShowDialog();
            this.Close();
        }

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

        private bool editando = false; // variável de controle

        private void btnEdicao_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                dvgTabela.ReadOnly = false;   // libera edição da tabela
                btnAtualizar.Visible = true;  // mostra botão atualizar
                btnDeletar.Visible = true;    // mostra botão deletar
                editando = true;
            }
            else
            {
                dvgTabela.ReadOnly = true;    // bloqueia edição novamente
                btnAtualizar.Visible = false; // esconde botão atualizar
                btnDeletar.Visible = false;   // esconde botão deletar
                editando = false;
            }
        }

    }
}

