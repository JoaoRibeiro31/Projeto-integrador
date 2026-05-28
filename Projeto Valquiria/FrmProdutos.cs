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

        public FrmProdutos()
        {
            InitializeComponent();
        }

        DataTable tabela = new DataTable();

        public void CarregarDadosProdutos()
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();

                string sql = @"select nome     AS Nome,
                                      valor    AS Valor
                                from produtos
                                ORDER BY nome asc";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);


                adapter.Fill(tabela);

                dgvDadosProdutos.DataSource = tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            CarregarDadosProdutos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelConteudo tela = new panelConteudo();
            tela.ShowDialog();
            this.Close();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO produtos (nome, valor) 
                                      VALUES  (@nome, @valor)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@valor", decimal.Parse(txtValor.Text, new System.Globalization.CultureInfo("pt-BR")));


                cmd.ExecuteNonQuery();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro.Message);
            }

            finally
            {
                conn.Close();
            }

            CarregarDadosProdutos();

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.ShowDialog();
            this.Close();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.ShowDialog();
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPesquisar.Text.Replace("'", "''");

            tabela.DefaultView.RowFilter =
             $"Nome LIKE '%{filtro}%'";
        }
    }
}
