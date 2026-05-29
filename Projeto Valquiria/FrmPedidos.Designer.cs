namespace Projeto_Valquiria
{
    partial class FrmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbClientes = new ComboBox();
            btnCadastroCliente = new Button();
            cmbProdutos = new ComboBox();
            lblValor = new Label();
            btnCadastrarPedido = new Button();
            btnProduto = new Button();
            a = new Label();
            panel1 = new Panel();
            lblTotal = new Label();
            lblContato = new Label();
            lblValorProduto = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbStatus = new ComboBox();
            label1 = new Label();
            txtQuantidade = new TextBox();
            dgvPedidos = new DataGridView();
            panel2 = new Panel();
            btnHome = new Button();
            btnPedido = new Button();
            btnEditar = new Button();
            txtPesquisar = new TextBox();
            btnDeletar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(148, 12);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(293, 29);
            cmbClientes.TabIndex = 0;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged_1;
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCadastroCliente.FlatStyle = FlatStyle.Popup;
            btnCadastroCliente.ForeColor = Color.White;
            btnCadastroCliente.Location = new Point(61, 354);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(158, 43);
            btnCadastroCliente.TabIndex = 1;
            btnCadastroCliente.Text = "Cliente";
            btnCadastroCliente.UseVisualStyleBackColor = false;
            btnCadastroCliente.Click += btnCadastroCliente_Click;
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(16, 47);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(176, 23);
            cmbProdutos.TabIndex = 2;
            cmbProdutos.Text = "Produtos";
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged_1;
            // 
            // lblValor
            // 
            lblValor.BackColor = Color.White;
            lblValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(16, 79);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(187, 27);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor total";
            // 
            // btnCadastrarPedido
            // 
            btnCadastrarPedido.BackColor = Color.White;
            btnCadastrarPedido.Location = new Point(452, 77);
            btnCadastrarPedido.Name = "btnCadastrarPedido";
            btnCadastrarPedido.Size = new Size(195, 27);
            btnCadastrarPedido.TabIndex = 9;
            btnCadastrarPedido.Text = "Cadastrar Pedido";
            btnCadastrarPedido.UseVisualStyleBackColor = false;
            btnCadastrarPedido.Click += btnCadastrarPedido_Click_1;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(56, 206, 22);
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(61, 301);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(158, 47);
            btnProduto.TabIndex = 10;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // a
            // 
            a.AutoEllipsis = true;
            a.BackColor = Color.White;
            a.BorderStyle = BorderStyle.FixedSingle;
            a.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a.Location = new Point(648, 27);
            a.Name = "a";
            a.Size = new Size(369, 46);
            a.TabIndex = 11;
            a.Text = "Área de Cadastro de Pedidos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblContato);
            panel1.Controls.Add(lblValorProduto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(cmbClientes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(cmbProdutos);
            panel1.Controls.Add(btnCadastrarPedido);
            panel1.Location = new Point(352, 570);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 112);
            panel1.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.DimGray;
            lblTotal.Location = new Point(122, 82);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 19);
            lblTotal.TabIndex = 13;
            // 
            // lblContato
            // 
            lblContato.BackColor = Color.Gainsboro;
            lblContato.Location = new Point(462, 12);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(442, 29);
            lblContato.TabIndex = 12;
            // 
            // lblValorProduto
            // 
            lblValorProduto.BackColor = Color.Gainsboro;
            lblValorProduto.Location = new Point(313, 50);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(79, 15);
            lblValorProduto.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 50);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 12;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 50);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 12;
            label2.Text = "Valor Produto";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(244, 79);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(148, 23);
            cmbStatus.TabIndex = 11;
            cmbStatus.Text = "Status";
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 10;
            label1.Text = "Nome Cliente:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(524, 47);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(141, 23);
            txtQuantidade.TabIndex = 0;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged_1;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(352, 140);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(917, 406);
            dgvPedidos.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(159, 214, 242);
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(btnPedido);
            panel2.Controls.Add(btnCadastroCliente);
            panel2.Controls.Add(btnProduto);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 694);
            panel2.TabIndex = 15;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(255, 226, 100);
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(12, 25);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(53, 56);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.Cursor = Cursors.No;
            btnPedido.Enabled = false;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(61, 250);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(158, 47);
            btnPedido.TabIndex = 11;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.ForeColor = Color.Transparent;
            btnEditar.Location = new Point(1315, 120);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(66, 52);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(440, 93);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(726, 23);
            txtPesquisar.TabIndex = 17;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(1315, 217);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(82, 22);
            btnDeletar.TabIndex = 18;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 190, 249);
            ClientSize = new Size(1432, 694);
            Controls.Add(btnDeletar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(dgvPedidos);
            Controls.Add(a);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FrmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidos_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private Button btnCadastroCliente;
        private ComboBox cmbProdutos;
        private Label lblValor;
        private Button btnCadastrarPedido;
        private Button btnProduto;
        private Label a;
        private Panel panel1;
        private TextBox txtQuantidade;
        private Label label1;
        private ComboBox cmbStatus;
        private Label label2;
        private Label lblContato;
        private Label lblValorProduto;
        private Label label3;
        private DataGridView dgvPedidos;
        private Panel panel2;
        private Button btnPedido;
        private Label lblTotal;
        private Button btnEditar;
        private Button btnHome;
        private TextBox txtPesquisar;
        private Button btnDeletar;
    }
}