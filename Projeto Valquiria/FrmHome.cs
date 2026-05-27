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
using System.Data;

namespace Projeto_Valquiria
{
    public partial class panelConteudo : Form
    {

        MySqlConnection Conexao;
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        public panelConteudo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.ShowDialog();
            this.Hide();
        }

        public void CarregarClientes()
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();

                string sql = @"select cl.nome               AS Nome,
	                                  cl.contato            AS Contato,
                                      SUM(p.valor_total)    AS Pendências
                                      FROM pedidos p
                                      INNER JOIN clientes cl ON p.cliente_id = cl.id
                                      WHERE p.status_pagamento = 'Pendente'
                                      group by cl.nome;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                DataTable tabela = new DataTable();

                adapter.Fill(tabela);

                dgvPedidos.DataSource = tabela;
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

        private void Home_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.ShowDialog();
            this.Hide();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
