using System;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Projeto_Valquiria
{
    public partial class frmHome : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        DataTable tabela = new DataTable();

        private System.Windows.Forms.Timer timerPesquisa = new System.Windows.Forms.Timer();

        public frmHome()
        {
            InitializeComponent();

            // Eventos para reaplicar destaque
            dgvPedidos.Sorted += dgvPedidos_Sorted;
            dgvPedidos.DataBindingComplete += dgvPedidos_DataBindingComplete;
        }

        // ---------- TIMER ----------
        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        // ---------- LOAD ----------
        private void Home_Load(object sender, EventArgs e)
        {
            //Teste de conexão
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                }
            }
            catch (MySqlException ex)
            {
                ErroHelper.MostrarErro("Erro de Conexão", "Não foi possível conectar ao banco de dados.");
                ErroHelper.LogErro(ex);
            }

            CarregarClientes();
            CarregarDados();

            // Cor de fundo geral da tabela
            dgvPedidos.BackgroundColor = Color.FromArgb(255, 220, 235);

            // Linhas alternadas (efeito suave)
            dgvPedidos.DefaultCellStyle.BackColor = Color.White;
            dgvPedidos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 240, 245);

            // Texto das células
            dgvPedidos.DefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);
            dgvPedidos.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);

            // Cor da seleção
            dgvPedidos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 100, 150);
            dgvPedidos.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho
            dgvPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 200, 220);
            dgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);
            dgvPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvPedidos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 200, 220);
            dgvPedidos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(80, 40, 100);


            // Bordas e estilo geral
            dgvPedidos.GridColor = Color.FromArgb(220, 180, 200);
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Borda arredondada
            UIHelper.ArredondarBorda(btnPedidos, 20);
            UIHelper.ArredondarBorda(btnProdutos, 20);
            UIHelper.ArredondarBorda(btnClientes, 20);
            UIHelper.ArredondarBorda(btnFecharApp, 20);
            UIHelper.ArredondarBorda(dgvPedidos, 20);
            UIHelper.ArredondarBorda(tlpDadosPedidos, 20);
            UIHelper.ArredondarBorda(tlpDadosProdutos, 20);
            UIHelper.ArredondarBorda(tlpDadosClientes, 20);
            UIHelper.ArredondarBorda(tlpDadosPendencias, 20);

            // Data e hora em tempo real
            timerDataHora.Start();

            // Intervalo de pesquisa
            timerPesquisa.Interval = 500;
            timerPesquisa.Tick += TimerPesquisa_Tick;

        }

        // ---------- CARREGAR CLIENTES COM PENDÊNCIAS ----------
        public void CarregarClientes(string filtro = "")
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT Nome, Contato, Pendencias
               FROM (
                   SELECT cl.nome AS Nome,
                          cl.contato AS Contato,
                          SUM(p.valor_total) AS Pendencias
                   FROM pedidos p
                   INNER JOIN clientes cl ON p.cliente_id = cl.id
                   WHERE p.status_pagamento = 'Pendente'
                   GROUP BY cl.nome, cl.contato
               ) AS sub
               WHERE (Nome LIKE @filtro
                      OR Contato LIKE @filtro
                      OR CAST(Pendencias AS CHAR) LIKE @filtro
                      OR REPLACE(CAST(Pendencias AS CHAR), '.', ',') LIKE @filtro
                      OR Pendencias = @valor)
               ORDER BY Nome ASC;";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    decimal valorPesquisa;
                    if (decimal.TryParse(filtro, out valorPesquisa))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@valor", valorPesquisa);
                    }
                    else
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@valor", -1);
                    }

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

        // ---------- CARREGAR DADOS ----------
        private void CarregarDados()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    //Dados Pedidos
                    string sqlPedidos = $"SELECT count(*) FROM pedidos WHERE status_pagamento = 'Pendente';";
                    MySqlCommand cmdP = new MySqlCommand(sqlPedidos, conn);
                    int quantidadePedidos = Convert.ToInt32(cmdP.ExecuteScalar());
                    lblDadosPedidos.Text = quantidadePedidos.ToString();

                    //Dados Produtos
                    string sqlProdutos = $"SELECT count(*) FROM produtos;";
                    MySqlCommand cmdPr = new MySqlCommand(sqlProdutos, conn);
                    int quantidadeProdutos = Convert.ToInt32(cmdPr.ExecuteScalar());
                    lblDadosProdutos.Text = quantidadeProdutos.ToString();

                    //Dados Clientes
                    string sqlClientes = $"SELECT count(*) FROM clientes;";
                    MySqlCommand cmdC = new MySqlCommand(sqlClientes, conn);
                    int quantidadeClientes = Convert.ToInt32(cmdC.ExecuteScalar());
                    lblDadosClientes.Text = quantidadeClientes.ToString();

                    //Dados Pendencias
                    string sqlValor = $"select sum(valor_total) AS 'Total' from pedidos where status_pagamento = 'Pendente';";
                    MySqlCommand cmdV = new MySqlCommand(sqlValor, conn);
                    object resultado = cmdV.ExecuteScalar();
                    decimal valor = resultado != DBNull.Value ? Convert.ToDecimal(resultado) : 0;
                    lblDadosPendencias.Text = valor.ToString("C", new CultureInfo("pt-BR"));
                }
                catch (Exception erro) 
                {
                    MessageBox.Show("Erro ao carregar os dados: " + erro.Message,
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
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(226, 62, 121);
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
            frmProdutos tela = new frmProdutos();
            tela.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos tela = new frmPedidos();
            tela.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes tela = new frmClientes();
            tela.Show();
            this.Hide();
        }

        // ---------- PESQUISA COM DELAY ----------
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
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
