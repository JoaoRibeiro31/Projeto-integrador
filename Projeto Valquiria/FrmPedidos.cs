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
            btnDeletar.Visible = false;
            btnAtualizar.Visible = false;
            cmbStatus.Items.Add("Pago");
            cmbStatus.Items.Add("Pendente");
            dgvDadosPedidos.ReadOnly = true;
            dgvDadosPedidos.CellValueChanged += dgvPedidos_CellValueChanged;
        }

        private void FrmPedidos_Load_1(object sender, EventArgs e)
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
            CarregarProdutos();
            CarregarPedidos();

            // limpa os campos de cadastro ao abrir
            cmbClientes.SelectedIndex = -1;
            cmbProdutos.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtQuantidade.Clear();
            lblValorProduto.Text = "";
            lblTotal.Text = "";
            lblContato.Text = "";

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

            // Borda arredondada
            UIHelper.ArredondarBorda(btnPedidos, 20);
            UIHelper.ArredondarBorda(btnProdutos, 20);
            UIHelper.ArredondarBorda(btnClientes, 20);
            UIHelper.ArredondarBorda(btnHome, 20);
            UIHelper.ArredondarBorda(dgvDadosPedidos, 20);
            UIHelper.ArredondarBorda(btnCadastrar, 20);
            UIHelper.ArredondarBorda(tlpCadastro, 20);
            UIHelper.ArredondarBorda(lblContato, 20);
            UIHelper.ArredondarBorda(lblTotal, 20);
            UIHelper.ArredondarBorda(lblValorProduto, 20);
        }

        // ---------- DATAGRIDVIEW ----------
        public void CarregarPedidos(string filtro = "")
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmdLocale = new MySqlCommand("SET lc_time_names = 'pt_BR';", conn);
                    cmdLocale.ExecuteNonQuery();

                    string sql = @"SET lc_time_names = 'pt_BR';

                                   SELECT p.id, 
                                   c.nome                                       AS Cliente, 
                                   pr.nome                                      AS Produto,
                                   p.quantidade                                 AS Quantidade, 
                                   REPLACE(FORMAT(p.valor_total, 2), '.', ',')  AS 'Valor Total',
                                   DATE_FORMAT(p.data_pedido, '%d/%m/%Y %H:%i') AS Data,
                                   DATE_FORMAT(p.data_pedido, '%W')             AS 'Dia da Semana',
                                   p.status_pagamento                           AS Status
                                   FROM pedidos p
                                   JOIN clientes c    ON p.cliente_id = c.id
                                   JOIN produtos pr   ON p.produto_id = pr.id
                                   WHERE (c.nome                                    LIKE @filtro
                                   OR pr.nome                                       LIKE @filtro
                                   OR p.quantidade                                  LIKE @filtro
                                   OR REPLACE(FORMAT(p.valor_total, 2), '.', ',')   LIKE @filtro
                                   OR DATE_FORMAT(p.data_pedido, '%d/%m/%Y %H:%i')  LIKE @filtro
                                   OR p.status_pagamento                            LIKE @filtro
                                   OR DATE_FORMAT(p.data_pedido, '%W')              LIKE @filtro)
                                   ORDER BY p.data_pedido DESC;";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    dt = new DataTable();
                    da.Fill(dt);

                    // Ajustes visuais no dvg
                    dgvDadosPedidos.DataSource = dt;
                    dgvDadosPedidos.Columns["id"].Visible = false;
                    dgvDadosPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDadosPedidos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvDadosPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgvDadosPedidos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvDadosPedidos.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                    ErroHelper.MostrarErro("Erro ao carregar pedidos: ", erro.Message);
                    ErroHelper.LogErro(erro);
                }
            }
        }

        private void dgvDadosPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDadosPedidos.Columns[e.ColumnIndex].Name == "Valor Total" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.Value = valor.ToString("C2", new CultureInfo("pt-BR"));
                    e.FormattingApplied = true;
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
                    ErroHelper.MostrarErro("Erro ao carregar clientes: ", erro.Message);
                    ErroHelper.LogErro(erro);
                }
            }
        }

        private void cmbClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RestaurarCampo(cmbProdutos);

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
                    ErroHelper.MostrarErro("Erro ao carregar produtos: ", erro.Message);
                    ErroHelper.LogErro(erro);
                }
            }
        }

        private decimal valorProdutoAtual = 0;

        private void cmbProdutos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RestaurarCampo(cmbProdutos);

            DataRowView row = cmbProdutos.SelectedItem as DataRowView;
            if (row != null)
            {
                valorProdutoAtual = Convert.ToDecimal(row["valor"]);
                lblValorProduto.Text = valorProdutoAtual.ToString("C2", new CultureInfo("pt-BR"));
                CalcularTotal();
            }
        }

        // ---------- QUANTIDADE / TOTAL ----------
        private void txtQuantidade_TextChanged_1(object sender, EventArgs e)
        {
            RestaurarCampo(cmbProdutos);

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (int.TryParse(txtQuantidade.Text, out int qtd))
            {
                decimal total = valorProdutoAtual * qtd;
                lblTotal.Text = total.ToString("C2", new CultureInfo("pt-BR"));
            }
        }

        // ---------- CADASTRAR PEDIDO ----------
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            // Resetar cores antes de validar
            RestaurarCampo(cmbClientes);
            RestaurarCampo(cmbProdutos);
            RestaurarCampo(cmbStatus);
            RestaurarCampo(txtQuantidade);

            // 🚫 Verificação de campos obrigatórios
            if (cmbClientes.SelectedIndex == -1)
            {
                ErroHelper.MostrarAviso("Selecione um cliente!");
                DestacarCampoInvalido(cmbClientes);
                return;
            }

            if (cmbProdutos.SelectedIndex == -1)
            {
                ErroHelper.MostrarAviso("Selecione um produto!");
                DestacarCampoInvalido(cmbProdutos);
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                ErroHelper.MostrarAviso("Selecione um status!");
                DestacarCampoInvalido(cmbStatus);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                ErroHelper.MostrarAviso("Digite uma quantidade!");
                DestacarCampoInvalido(txtQuantidade);
                return;
            }

            // 🔒 Validação da quantidade
            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd <= 0)
            {
                ErroHelper.MostrarAviso("Digite uma quantidade válida (maior que 0)!");
                DestacarCampoInvalido(txtQuantidade);
                return;
            }

            if (qtd > 999)
            {
                ErroHelper.MostrarAviso("A quantidade máxima permitida é 999 unidades!");
                DestacarCampoInvalido(txtQuantidade);
                return;
            }

            // Conversão
            if (!decimal.TryParse(lblTotal.Text, NumberStyles.Currency, new CultureInfo("pt-BR"), out decimal total))
            {
                ErroHelper.MostrarErro("Erro", "Não foi possível converter o valor total!");
                return;
            }

            // 🔒 Validação do valor total
            if (total <= 0)
            {
                ErroHelper.MostrarAviso("O valor total do pedido deve ser maior que 0!");
                return;
            }

            // Limite de valor
            if (total > 1500)
            {
                ErroHelper.MostrarAviso("O valor total excede o limite permitido!");
                return;
            }

            // Confirmação
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
                    ErroHelper.MostrarSucesso("Pedido cadastrado com sucesso!");
                }
                catch (Exception erro)
                {
                    ErroHelper.MostrarErro("Erro ao cadastrar pedido", erro.Message);
                    ErroHelper.LogErro(erro);
                }
            }

            CarregarPedidos();

            // 🔄 Limpa todos os campos após cadastro
            cmbClientes.SelectedIndex = -1;
            cmbProdutos.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtQuantidade.Clear();
            lblValorProduto.Text = "";
            lblTotal.Text = "";
            lblContato.Text = "";
        }

        // Métodos auxiliares
        private void DestacarCampoInvalido(Control campo)
        {
            campo.BackColor = Color.Yellow;
        }

        private void RestaurarCampo(Control campo)
        {
            campo.BackColor = SystemColors.Window;
        }

        // Eventos para restaurar cor ao interagir
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurarCampo(cmbProdutos);
        }

        // ---------- EDITAR ----------
        private void btnEdicao_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                dgvDadosPedidos.ReadOnly = false;
                btnDeletar.Visible = true;
                btnAtualizar.Visible = true;
                editando = true;
            }
            else
            {
                dgvDadosPedidos.ReadOnly = true;
                btnDeletar.Visible = false;
                btnAtualizar.Visible = false;
                editando = false;
            }

            dgvDadosPedidos.Columns["Dia da Semana"].ReadOnly = true;
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
                    ErroHelper.MostrarAviso("Status inválido! Use apenas 'Pago' ou 'Pendente'.");
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
                        ErroHelper.MostrarErro("Erro ao atualizar status: ", erro.Message);
                        ErroHelper.LogErro(erro);
                    }
                }
            }
        }

        // ---------- ATUALIZAR ----------
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int contadorAtualizados = 0;

            DialogResult confirmacao = MessageBox.Show(
                "Confirma atualizar os pedidos?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No) return;

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvDadosPedidos.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string cliente = row.Cells["Cliente"].Value?.ToString().Trim() ?? "";
                        string produto = row.Cells["Produto"].Value?.ToString().Trim() ?? "";

                        // 🚫 Validação de cliente e produto
                        if (string.IsNullOrEmpty(cliente))
                        {
                            ErroHelper.MostrarAviso("Cliente não informado. O pedido não pode ser atualizado.");
                            continue;
                        }

                        if (string.IsNullOrEmpty(produto))
                        {
                            ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: Produto não informado!");
                            continue;
                        }

                        // Verifica se cliente existe
                        string sqlCliente = "SELECT COUNT(*) FROM clientes WHERE nome = @nome";
                        MySqlCommand cmdCliente = new MySqlCommand(sqlCliente, conn);
                        cmdCliente.Parameters.AddWithValue("@nome", cliente);
                        int clienteExiste = Convert.ToInt32(cmdCliente.ExecuteScalar());

                        if (clienteExiste == 0)
                        {
                            ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: Cliente não encontrado na base!");
                            continue;
                        }

                        // Verifica se produto existe
                        string sqlProduto = "SELECT COUNT(*) FROM produtos WHERE nome = @nome";
                        MySqlCommand cmdProduto = new MySqlCommand(sqlProduto, conn);
                        cmdProduto.Parameters.AddWithValue("@nome", produto);
                        int produtoExiste = Convert.ToInt32(cmdProduto.ExecuteScalar());

                        if (produtoExiste == 0)
                        {
                            ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: Produto '{produto}' não encontrado na base!");
                            continue;
                        }

                        // 🚫 Validação de campos obrigatórios
                        if (row.Cells["Quantidade"].Value == null || row.Cells["Valor Total"].Value == null)
                        {
                            ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: Quantidade e Valor Total não podem ser nulos!");
                            continue;
                        }

                        int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                        string valorTexto = row.Cells["Valor Total"].Value?.ToString().Trim() ?? "";

                        valorTexto = valorTexto.Replace("R$", "").Trim();

                        if (!decimal.TryParse(valorTexto, NumberStyles.Any, new CultureInfo("pt-BR"), out decimal valorTotal) || valorTotal <= 0)
                        {
                            ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: O valor total informado não é válido!");
                            continue;
                        }


                        if (quantidade <= 0)
                        {
                            ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: A quantidade deve ser maior que 0!");
                            continue;
                        }

                        if (valorTotal <= 0)
                        {
                            ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: O valor total deve ser maior que 0!");
                            continue;
                        }

                        DateTime dataPedido = Convert.ToDateTime(row.Cells["Data"].Value);
                        int id = Convert.ToInt32(row.Cells["id"].Value);

                        // Verificação de alterações
                        string sqlCheck = @"SELECT c.nome AS Cliente, pr.nome AS Produto, 
                                           p.quantidade, p.valor_total, p.data_pedido
                                    FROM pedidos p
                                    JOIN clientes c ON p.cliente_id = c.id
                                    JOIN produtos pr ON p.produto_id = pr.id
                                    WHERE p.id = @id";

                        MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                        cmdCheck.Parameters.AddWithValue("@id", id);

                        bool houveAlteracao = false;

                        using (var reader = cmdCheck.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string clienteAtual = reader.GetString("Cliente");
                                string produtoAtual = reader.GetString("Produto");
                                int qtdAtual = reader.GetInt32("quantidade");
                                decimal valorAtual = reader.GetDecimal("valor_total");
                                DateTime dataAtual = reader.GetDateTime("data_pedido");

                                if (cliente != clienteAtual || produto != produtoAtual ||
                                    quantidade != qtdAtual || valorTotal != valorAtual ||
                                    dataPedido != dataAtual)
                                {
                                    houveAlteracao = true;
                                }
                            }
                        }

                        if (houveAlteracao)
                        {
                            // Busca o ID do cliente pelo nome
                            string sqlClienteId = "SELECT id FROM clientes WHERE nome = @nome";
                            MySqlCommand cmdClienteId = new MySqlCommand(sqlClienteId, conn);
                            cmdClienteId.Parameters.AddWithValue("@nome", cliente);
                            object clienteIdObj = cmdClienteId.ExecuteScalar();

                            if (clienteIdObj == null)
                            {
                                ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: Cliente não encontrado na base!");
                                continue;
                            }
                            int clienteId = Convert.ToInt32(clienteIdObj);

                            // Busca o ID do produto pelo nome
                            string sqlProdutoId = "SELECT id FROM produtos WHERE nome = @nome";
                            MySqlCommand cmdProdutoId = new MySqlCommand(sqlProdutoId, conn);
                            cmdProdutoId.Parameters.AddWithValue("@nome", produto);
                            object produtoIdObj = cmdProdutoId.ExecuteScalar();

                            if (produtoIdObj == null)
                            {
                                ErroHelper.MostrarAviso($"Pedido do(a) cliente {cliente}: Produto '{produto}' não encontrado na base!");
                                continue;
                            }
                            int produtoId = Convert.ToInt32(produtoIdObj);

                            // Atualiza pedido incluindo cliente e produto
                            string sqlUpdate = @"UPDATE pedidos 
                         SET cliente_id = @clienteId, produto_id = @produtoId,
                             quantidade = @qtd, valor_total = @valor, data_pedido = @data
                         WHERE id = @id";

                            MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                            cmdUpdate.Parameters.AddWithValue("@clienteId", clienteId);
                            cmdUpdate.Parameters.AddWithValue("@produtoId", produtoId);
                            cmdUpdate.Parameters.AddWithValue("@qtd", quantidade);
                            cmdUpdate.Parameters.AddWithValue("@valor", valorTotal);
                            cmdUpdate.Parameters.AddWithValue("@data", dataPedido);
                            cmdUpdate.Parameters.AddWithValue("@id", id);
                            cmdUpdate.ExecuteNonQuery();

                            contadorAtualizados++;
                        }

                    }

                    if (contadorAtualizados == 0)
                        ErroHelper.MostrarAviso("Nenhuma alteração realizada.");
                    else if (contadorAtualizados == 1)
                        ErroHelper.MostrarSucesso("Pedido atualizado com sucesso!");
                    else
                        ErroHelper.MostrarSucesso($"Pedidos atualizados com sucesso! ({contadorAtualizados} registros)");
                }
                catch (Exception erro)
                {
                    ErroHelper.MostrarErro("Erro ao atualizar pedidos: ", erro.Message);
                    ErroHelper.LogErro(erro);
                }
            }

            CarregarPedidos();
        }


        // ---------- DELETAR ----------
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvDadosPedidos.CurrentRow == null || dgvDadosPedidos.CurrentRow.IsNewRow)
            {
                ErroHelper.MostrarAviso("Selecione um pedido para excluir!");
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

                    ErroHelper.MostrarSucesso("Pedido excluído com sucesso!");
                }
                catch (Exception erro)
                {
                    ErroHelper.MostrarErro("Erro ao excluir pedido: ", erro.Message);
                    ErroHelper.LogErro(erro);
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
            frmClientes tela = new frmClientes();
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
