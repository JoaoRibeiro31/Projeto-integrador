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
using System.Globalization;

namespace Projeto_Valquiria
{
    public partial class FrmPedidos : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";

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

            dgvPedidos.ReadOnly = true;
            dgvPedidos.CellValueChanged += dgvPedidos_CellValueChanged;

        }

        // ---------- CLIENTES ----------
        private void CarregarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT id, nome, contato FROM clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbClientes.DataSource = dt;
                cmbClientes.DisplayMember = "nome";
                cmbClientes.ValueMember = "id";
                cmbClientes.Tag = dt;
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
                conn.Open();
                string sql = "SELECT id, nome, valor FROM produtos";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbProdutos.DataSource = dt;
                cmbProdutos.DisplayMember = "nome";
                cmbProdutos.ValueMember = "id";
                cmbProdutos.Tag = dt;
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
            }
        }

        // ---------- CADASTRAR PEDIDO ----------
        private void btnCadastrarPedido_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = @"INSERT INTO pedidos 
                               (cliente_id, produto_id, quantidade, valor_total, status_pagamento) 
                               VALUES (@cliente, @produto, @qtd, @total, @status)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cliente", cmbClientes.SelectedValue);
                cmd.Parameters.AddWithValue("@produto", cmbProdutos.SelectedValue);
                cmd.Parameters.AddWithValue("@qtd", int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@total", decimal.Parse(lblTotal.Text, new CultureInfo("pt-BR")));
                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido cadastrado com sucesso!");
            }

            CarregarPedidos(); // atualiza tabela
        }

        // ---------- DATAGRIDVIEW ----------
        private void CarregarPedidos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = @"SELECT p.id, c.nome AS Cliente, pr.nome AS Produto,
                                      p.quantidade, p.valor_total, p.data_pedido, p.status_pagamento
                               FROM pedidos p
                               JOIN clientes c ON p.cliente_id = c.id
                               JOIN produtos pr ON p.produto_id = pr.id
                               ORDER BY data_pedido desc ;";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPedidos.DataSource = dt;

                dgvPedidos.Columns["id"].Visible = false;

                if (dgvPedidos.Columns.Contains("status_pagamento"))
                {
                    dgvPedidos.Columns.Remove("status_pagamento");

                    DataGridViewComboBoxColumn comboStatus = new DataGridViewComboBoxColumn();
                    comboStatus.HeaderText = "Status";
                    comboStatus.Name = "status_pagamento";
                    comboStatus.DataPropertyName = "status_pagamento";
                    comboStatus.Items.Add("Pago");
                    comboStatus.Items.Add("Pendente");

                    dgvPedidos.Columns.Add(comboStatus);
                }
            }
        }

        private void dgvPedidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.Columns[e.ColumnIndex].Name == "status_pagamento" && e.RowIndex >= 0)
            {
                int idPedido = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells["id"].Value);
                string novoStatus = dgvPedidos.Rows[e.RowIndex].Cells["status_pagamento"].Value.ToString();

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "UPDATE pedidos SET status_pagamento = @status WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@status", novoStatus);
                    cmd.Parameters.AddWithValue("@id", idPedido);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        bool editando = false;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                dgvPedidos.ReadOnly = false; // libera edição geral
                                             // se quiser travar todas as outras colunas, pode fazer um loop:
                foreach (DataGridViewColumn col in dgvPedidos.Columns)
                {
                    col.ReadOnly = true; // trava todas
                }
                dgvPedidos.Columns["status_pagamento"].ReadOnly = false; // só libera status

                btnEditar.Text = "Bloquear Edição";
                editando = true;
            }
            else
            {
                dgvPedidos.ReadOnly = true; // volta a bloquear tudo
                btnEditar.Text = "Editar";
                editando = false;
            }
        }
    }
}
