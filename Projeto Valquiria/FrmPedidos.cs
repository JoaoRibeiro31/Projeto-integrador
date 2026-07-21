using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class FrmPedidos : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        private System.Windows.Forms.Timer timerPesquisa = new System.Windows.Forms.Timer();
        DataTable dt = new DataTable();
        bool editando = false;

        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load_1(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarProdutos();
            CarregarPedidos();

            cmbStatus.Items.Add("Pago");
            cmbStatus.Items.Add("Pendente");

            dgvDadosPedidos.ReadOnly = true;
            dgvDadosPedidos.CellValueChanged += dgvPedidos_CellValueChanged;

            // limpa os campos de cadastro ao abrir
            cmbClientes.SelectedIndex = -1;
            cmbProdutos.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtQuantidade.Clear();
            lblValorProduto.Text = "";
            lblTotal.Text = "";
            lblContato.Text = "";

            btnDeletar.Visible = false;

            // Cor de fundo geral da tabela
            dgvDadosPedidos.BackgroundColor = Color.FromArgb(255, 220, 235);

            // Linhas alternadas (efeito suave)
            dgvDadosPedidos.DefaultCellStyle.BackColor = Color.White;
            dgvDadosPedidos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 240, 245);

            // Texto das células
            dgvDadosPedidos.DefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);
            dgvDadosPedidos.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);

            // Cor da seleção
            dgvDadosPedidos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 100, 150);
            dgvDadosPedidos.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cabeçalho
            dgvDadosPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 200, 220);
            dgvDadosPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 40, 100);
            dgvDadosPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvDadosPedidos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 200, 220);
            dgvDadosPedidos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(80, 40, 100);

            // Bordas e estilo geral
            dgvDadosPedidos.GridColor = Color.FromArgb(220, 180, 200);
            dgvDadosPedidos.BorderStyle = BorderStyle.None;
            dgvDadosPedidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

        }

        // ---------- DATAGRIDVIEW ----------
        public void CarregarPedidos(string filtro = "")
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT p.id, 
                                          c.nome                AS Cliente, 
                                          pr.nome               AS Produto,
                                          p.quantidade          AS Quantidade, 
                                          p.valor_total         AS 'Valor Total',
                                          p.data_pedido         AS Data, 
                                          p.status_pagamento    AS Status
                           FROM pedidos p
                           JOIN clientes c ON p.cliente_id = c.id
                           JOIN produtos pr ON p.produto_id = pr.id
                           WHERE (c.nome LIKE @filtro
                                  OR pr.nome LIKE @filtro
                                  OR p.quantidade LIKE @filtro
                                  OR p.valor_total LIKE @filtro
                                  OR p.data_pedido LIKE @filtro
                                  OR p.status_pagamento LIKE @filtro)
                           ORDER BY data_pedido DESC;";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    dt = new DataTable();
                    da.Fill(dt);

                    dgvDadosPedidos.DataSource = dt;
                    dgvDadosPedidos.Columns["id"].Visible = false;

                    if (dgvDadosPedidos.Columns.Contains("Status"))
                    {
                        dgvDadosPedidos.Columns.Remove("Status");

                        DataGridViewComboBoxColumn comboStatus = new DataGridViewComboBoxColumn();
                        comboStatus.HeaderText = "Status";
                        comboStatus.Name = "Status";
                        comboStatus.DataPropertyName = "Status";
                        comboStatus.Items.Add("Pago");
                        comboStatus.Items.Add("Pendente");
                        comboStatus.ReadOnly = false;

                        dgvDadosPedidos.Columns.Add(comboStatus);
                    }

                    dgvDadosPedidos.ReadOnly = false;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar pedidos: " + erro.Message);
                }
            }
        }

        // ---------- PESQUISA COM DELAY ----------
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
            timerPesquisa.Interval = 500; // meio segundo

            timerPesquisa.Tick -= TimerPesquisa_Tick;
            timerPesquisa.Tick += TimerPesquisa_Tick;

            timerPesquisa.Start();
        }

        private void TimerPesquisa_Tick(object sender, EventArgs e)
        {
            timerPesquisa.Stop();
            CarregarPedidos(txtPesquisar.Text);
        }

        // ---------- CLIENTES ----------
        private void CarregarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, nome, contato FROM clientes ORDER BY nome asc";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    dt = new DataTable();
                    da.Fill(dt);

                    cmbClientes.DataSource = dt;
                    cmbClientes.DisplayMember = "nome";
                    cmbClientes.ValueMember = "id";
                    cmbClientes.Tag = dt;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + erro.Message);
                }
            }
        }

        private void cmbClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataRowView row = cmbClientes.SelectedItem as DataRowView;
            if (row != null)
            {
                lblContato.Text = row["contato"].ToString();
            }
        }

        // ---------- PRODUTOS ----------
        private void CarregarProdutos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, nome, valor FROM produtos ORDER BY nome ASC;";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProdutos.DataSource = dt;
                    cmbProdutos.DisplayMember = "nome";
                    cmbProdutos.ValueMember = "id";
                    cmbProdutos.Tag = dt;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + erro.Message);
                }
            }
        }

        private void cmbProdutos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataRowView row = cmbProdutos.SelectedItem as DataRowView;
            if (row != null)
            {
                decimal valor = Convert.ToDecimal(row["valor"]);
                lblValorProduto.Text = valor.ToString("N2", new CultureInfo("pt-BR"));
                CalcularTotal();
            }
        }

        // ---------- QUANTIDADE / TOTAL ----------
        private void txtQuantidade_TextChanged_1(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (decimal.TryParse(lblValorProduto.Text, out decimal valorProduto) &&
                int.TryParse(txtQuantidade.Text, out int qtd))
            {
                decimal total = valorProduto * qtd;
                lblTotal.Text = total.ToString("N2", new CultureInfo("pt-BR"));
                lblTotal.ForeColor = Color.Green;
            }
        }

        // ---------- CADASTRAR PEDIDO ----------
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            // 🚫 Verificação de campos obrigatórios
            if (cmbClientes.SelectedIndex == -1 || cmbProdutos.SelectedIndex == -1 ||
                cmbStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar o pedido!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔒 Validação da quantidade
            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd <= 0)
            {
                MessageBox.Show("Digite uma quantidade válida (maior que 0)!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (qtd > 999)
            {
                MessageBox.Show("A quantidade máxima permitida é 999 unidades!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔒 Validação do valor total
            if (!decimal.TryParse(lblTotal.Text, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal total) || total <= 0)
            {
                MessageBox.Show("O valor total do pedido deve ser maior que 0!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                "Confirma cadastrar este pedido?",
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
                    string sql = @"INSERT INTO pedidos 
                                   (cliente_id, produto_id, quantidade, valor_total, status_pagamento) 
                                   VALUES (@cliente, @produto, @qtd, @total, @status)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cliente", cmbClientes.SelectedValue);
                    cmd.Parameters.AddWithValue("@produto", cmbProdutos.SelectedValue);
                    cmd.Parameters.AddWithValue("@qtd", qtd);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pedido cadastrado com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao cadastrar pedido: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarPedidos(); // atualiza tabela

            // 🔄 Limpa todos os campos após cadastro
            cmbClientes.SelectedIndex = -1;
            cmbProdutos.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtQuantidade.Clear();
            lblValorProduto.Text = "";
            lblTotal.Text = "";
            lblContato.Text = "";
        }

        // ---------- ATUALIZA STATUS ----------
        private void dgvPedidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDadosPedidos.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                int idPedido = Convert.ToInt32(dgvDadosPedidos.Rows[e.RowIndex].Cells["id"].Value);
                string novoStatus = dgvDadosPedidos.Rows[e.RowIndex].Cells["Status"].Value?.ToString();

                // 🚫 Validação do status
                if (novoStatus != "Pago" && novoStatus != "Pendente")
                {
                    MessageBox.Show("Status inválido! Use apenas 'Pago' ou 'Pendente'.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarPedidos();
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    try
                    {
                        conn.Open();
                        string sql = "UPDATE pedidos SET status_pagamento = @status WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@status", novoStatus);
                        cmd.Parameters.AddWithValue("@id", idPedido);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao atualizar status: " + erro.Message);
                    }
                }
            }
        }

        // ---------- EDITAR / DELETAR ----------
        private void btnEdicao_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                dgvDadosPedidos.ReadOnly = false;
                btnDeletar.Visible = true;
                editando = true;
            }
            else
            {
                dgvDadosPedidos.ReadOnly = true;
                btnDeletar.Visible = false;
                editando = false;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvDadosPedidos.CurrentRow == null || dgvDadosPedidos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecione um pedido para excluir!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPedido = Convert.ToInt32(dgvDadosPedidos.CurrentRow.Cells["id"].Value);
            string cliente = dgvDadosPedidos.CurrentRow.Cells["Cliente"].Value.ToString();
            string produto = dgvDadosPedidos.CurrentRow.Cells["Produto"].Value.ToString();

            DialogResult confirmacao = MessageBox.Show(
                $"Confirma excluir o pedido do cliente '{cliente}' para o produto '{produto}'?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.No)
                return;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM pedidos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idPedido);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pedido excluído com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao excluir pedido: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            CarregarPedidos();
        }

        // ---------- NAVEGAÇÃO ----------
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes tela = new FrmClientes();
            tela.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome tela = new FrmHome();
            tela.Show();
            this.Hide();
        }
    }
}
