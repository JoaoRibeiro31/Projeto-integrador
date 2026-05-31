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

            dgvPedidos.ReadOnly = true;
            dgvPedidos.CellValueChanged += dgvPedidos_CellValueChanged;

            // limpa os campos de cadastro ao abrir
            cmbClientes.SelectedIndex = -1;
            cmbProdutos.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtQuantidade.Clear();
            lblValorProduto.Text = "";
            lblTotal.Text = "";
            lblContato.Text = "";   // 🔄 limpa também o contato

            // botão deletar começa escondido
            btnDeletar.Visible = false;
        }


        // ---------- CLIENTES ----------
        private void CarregarClientes()
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = "SELECT id, nome, contato FROM clientes";
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
            finally
            {
                conn.Close();
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
            MySqlConnection conn = new MySqlConnection(conexao);

            try
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
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar produtos: " + erro.Message);
            }
            finally
            {
                conn.Close();
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
                lblTotal.Text = total.ToString("C2", new CultureInfo("pt-BR"));
                lblTotal.ForeColor = Color.Green;
            }
        }

        // ---------- CADASTRAR PEDIDO ----------
        private void btnCadastrarPedido_Click_1(object sender, EventArgs e)
        {
            // Validação dos campos obrigatórios
            if (cmbClientes.SelectedIndex == -1 || cmbProdutos.SelectedIndex == -1 ||
                cmbStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar o pedido!",
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

            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = @"INSERT INTO pedidos 
                       (cliente_id, produto_id, quantidade, valor_total, status_pagamento) 
                       VALUES (@cliente, @produto, @qtd, @total, @status)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cliente", cmbClientes.SelectedValue);
                cmd.Parameters.AddWithValue("@produto", cmbProdutos.SelectedValue);
                cmd.Parameters.AddWithValue("@qtd", int.Parse(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@total", decimal.Parse(lblTotal.Text, new System.Globalization.CultureInfo("pt-BR")));
                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar pedido: " + erro.Message);
            }
            finally
            {
                conn.Close();
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



        // ---------- DATAGRIDVIEW ----------
        private void CarregarPedidos()
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = @"SELECT p.id, c.nome AS Cliente, pr.nome AS Produto,
                              p.quantidade, p.valor_total, p.data_pedido, p.status_pagamento
                       FROM pedidos p
                       JOIN clientes c ON p.cliente_id = c.id
                       JOIN produtos pr ON p.produto_id = pr.id
                       ORDER BY data_pedido desc;";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
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
                    comboStatus.ReadOnly = false;

                    dgvPedidos.Columns.Add(comboStatus);
                }

                dgvPedidos.ReadOnly = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar pedidos: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void dgvPedidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.Columns[e.ColumnIndex].Name == "status_pagamento" && e.RowIndex >= 0)
            {
                int idPedido = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells["id"].Value);
                string novoStatus = dgvPedidos.Rows[e.RowIndex].Cells["status_pagamento"].Value.ToString();

                MySqlConnection conn = new MySqlConnection(conexao);

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
                finally
                {
                    conn.Close();
                }
            }
        }


        // ---------- EDITAR / DELETAR ----------
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                btnEditar.Text = "Bloquear Edição";
                dgvPedidos.ReadOnly = false; // libera edição
                btnDeletar.Visible = true;   // mostra botão deletar
                editando = true;
            }
            else
            {
                btnEditar.Text = "Editar";
                dgvPedidos.ReadOnly = true;  // bloqueia edição
                btnDeletar.Visible = false;  // esconde botão deletar
                editando = false;
            }
        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null || dgvPedidos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecione um pedido para excluir!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPedido = Convert.ToInt32(dgvPedidos.CurrentRow.Cells["id"].Value);

            DialogResult confirmacao = MessageBox.Show(
                "Confirma excluir este pedido?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.No)
                return;

            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                string sql = "DELETE FROM pedidos WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idPedido);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido excluído com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir pedido: " + erro.Message);
            }
            finally
            {
                conn.Close(); // garante que o banco será fechado
            }

            CarregarPedidos(); // atualiza a tabela
        }

        // ---------- NAVEGAÇÃO ----------
        private void btnHome_Click(object sender, EventArgs e)
        {
            panelConteudo tela = new panelConteudo();
            tela.ShowDialog();
            this.Close();
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

        // ---------- PESQUISA ----------
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtPesquisar.Text.Replace("'", "''");

                if (string.IsNullOrWhiteSpace(filtro))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    dt.DefaultView.RowFilter =
                        $"Cliente LIKE '%{filtro}%' OR " +
                        $"Produto LIKE '%{filtro}%' OR " +
                        $"Convert(quantidade, 'System.String') LIKE '%{filtro}%' OR " +
                        $"Convert(valor_total, 'System.String') LIKE '%{filtro}%' OR " +
                        $"Convert(data_pedido, 'System.String') LIKE '%{filtro}%' OR " +
                        $"status_pagamento LIKE '%{filtro}%'";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao aplicar filtro de pesquisa: " + erro.Message);
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }
    }
}