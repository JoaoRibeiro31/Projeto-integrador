using System;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class panelConteudo : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        DataTable tabela = new DataTable();

        public panelConteudo()
        {
            InitializeComponent();

            // Eventos para reaplicar destaque
            dgvPedidos.Sorted += dgvPedidos_Sorted;
            dgvPedidos.DataBindingComplete += dgvPedidos_DataBindingComplete;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        // ---------- CARREGAR CLIENTES COM PENDÊNCIAS ----------
        public void CarregarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT cl.nome AS Nome,
                                          cl.contato AS Contato,
                                          SUM(p.valor_total) AS Pendencias
                                   FROM pedidos p
                                   INNER JOIN clientes cl ON p.cliente_id = cl.id
                                   WHERE p.status_pagamento = 'Pendente'
                                   GROUP BY cl.nome, cl.contato;";
//AND (cl.nome LIKE '%@filtro%' OR cl.contato = '%@filtro%')

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    tabela = new DataTable();
                    adapter.Fill(tabela);

                    dgvPedidos.DataSource = tabela;
                    dgvPedidos.ReadOnly = true;

                    // Formata coluna de Pendências como moeda
                    if (dgvPedidos.Columns.Contains("Pendencias"))
                    {
                        dgvPedidos.Columns["Pendencias"].DefaultCellStyle.Format = "C2";
                        dgvPedidos.Columns["Pendencias"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                        dgvPedidos.Columns["Pendencias"].HeaderText = "Pendências (R$)";
                    }

                    // Aplica destaque inicial
                    AplicarDestaquePendencias();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ---------- MÉTODO DE DESTAQUE ----------
        private void AplicarDestaquePendencias()
        {
            foreach (DataGridViewRow row in dgvPedidos.Rows)
            {
                if (row.Cells["Pendencias"].Value != null &&
                    row.Cells["Pendencias"].Value != DBNull.Value &&
                    decimal.TryParse(row.Cells["Pendencias"].Value.ToString(), out decimal pendencia))
                {
                    if (pendencia > 99)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                        row.DefaultCellStyle.Font = new Font(dgvPedidos.Font, FontStyle.Bold);
                    }
                    else
                    {
                        // volta ao estilo padrão
                        row.DefaultCellStyle.ForeColor = dgvPedidos.DefaultCellStyle.ForeColor;
                        row.DefaultCellStyle.Font = dgvPedidos.Font;
                    }
                }
            }
        }

        // ---------- EVENTOS PARA REAPLICAR DESTAQUE ----------
        private void dgvPedidos_Sorted(object sender, EventArgs e)
        {
            AplicarDestaquePendencias();
        }

        private void dgvPedidos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AplicarDestaquePendencias();
        }

        // ---------- NAVEGAÇÃO ----------
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.Show();
            this.Hide();
        }

        // ---------- PESQUISA ----------
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtPesquisar.Text.Replace("'", "''");

                if (string.IsNullOrWhiteSpace(filtro))
                {
                    tabela.DefaultView.RowFilter = "";
                }
                else
                {
                    tabela.DefaultView.RowFilter =
                        $"Nome LIKE '%{filtro}%' OR " +
                        $"Contato LIKE '%{filtro}%' OR " +
                        $"Convert(Pendencias, 'System.String') LIKE '%{filtro}%'";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao aplicar filtro de pesquisa: " + erro.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- SAIR DO SISTEMA ----------
        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            if (ConfirmarSaida())
            {
                Application.Exit();
            }
        }

        private bool ConfirmarSaida()
        {
            return MessageBox.Show(
                "Deseja sair do Projeto Valquíria?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes;
        }
    }
}
