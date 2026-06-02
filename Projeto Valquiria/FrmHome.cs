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

        private System.Windows.Forms.Timer timerPesquisa = new System.Windows.Forms.Timer();

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

            // Cor de fundo geral da tabela
            dgvPedidos.BackgroundColor = Color.FromArgb(240, 192, 229); // rosa claro do layout

            // Linhas alternadas (efeito suave)
            dgvPedidos.DefaultCellStyle.BackColor = Color.White;
            dgvPedidos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 230, 240); // tom rosado pastel

            // Texto das células
            dgvPedidos.DefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100); // lilás escuro
            dgvPedidos.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);

            // Cor da seleção
            dgvPedidos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(164, 92, 218); // roxo dos botões
            dgvPedidos.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho
            dgvPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 192, 229);
            dgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);
            dgvPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvPedidos.EnableHeadersVisualStyles = false;

            // Bordas e estilo geral
            dgvPedidos.GridColor = Color.FromArgb(200, 160, 210);
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Centraliza o texto do cabeçalho (títulos das colunas)
            dgvPedidos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // ---------- CARREGAR CLIENTES COM PENDÊNCIAS ----------
        public void CarregarClientes(string filtro = "")
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
                                     AND (cl.nome LIKE @filtro
                                          OR cl.contato LIKE @filtro
                                          OR p.valor_total LIKE @filtro)
                                   GROUP BY cl.nome, cl.contato
                                   ORDER BY Nome ASC;";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    tabela = new DataTable();
                    adapter.Fill(tabela);

                    dgvPedidos.DataSource = tabela;
                    dgvPedidos.ReadOnly = true;

                    if (dgvPedidos.Columns.Contains("Pendencias"))
                    {
                        dgvPedidos.Columns["Pendencias"].DefaultCellStyle.Format = "C2";
                        dgvPedidos.Columns["Pendencias"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                        dgvPedidos.Columns["Pendencias"].HeaderText = "Pendências (R$)";
                    }

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

        // ---------- PESQUISA COM DELAY ----------
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
            timerPesquisa.Interval = 500; // meio segundo

            // evita acumular handlers
            timerPesquisa.Tick -= TimerPesquisa_Tick;
            timerPesquisa.Tick += TimerPesquisa_Tick;

            timerPesquisa.Start();
        }

        private void TimerPesquisa_Tick(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
            CarregarClientes(txtPesquisar.Text);
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
