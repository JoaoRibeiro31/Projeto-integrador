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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            btnCliente = new Button();
            btnProduto = new Button();
            pnlMenu = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            btnPedido = new Button();
            tlpHome = new TableLayoutPanel();
            btnHome = new Button();
            btnEdicao = new Button();
            btnDeletar = new Button();
            btnCadastrar = new Button();
            cmbProdutos = new ComboBox();
            txtQuantidade = new TextBox();
            lblValorTotal = new Label();
            lblNome = new Label();
            cmbClientes = new ComboBox();
            cmbStatus = new ComboBox();
            lblValorP = new Label();
            lblQuantidade = new Label();
            lblValorProduto = new Label();
            lblContato = new Label();
            lblTotal = new Label();
            pnlCadastro = new Panel();
            lblProduto = new Label();
            lblTitulo = new Label();
            dgvPedidos = new DataGridView();
            txtPesquisar = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pnlMenu.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpHome.SuspendLayout();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.Dock = DockStyle.Fill;
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(99, 405);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(151, 42);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.MediumSeaGreen;
            btnProduto.Dock = DockStyle.Fill;
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.Font = new Font("Segoe UI", 12F);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(99, 293);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(151, 42);
            btnProduto.TabIndex = 10;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.BackColor = Color.FromArgb(240, 192, 229);
            pnlMenu.BackgroundImage = (Image)resources.GetObject("pnlMenu.BackgroundImage");
            pnlMenu.Controls.Add(tlpNavegacao);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(350, 810);
            pnlMenu.TabIndex = 15;
            // 
            // tlpNavegacao
            // 
            tlpNavegacao.BackColor = Color.Transparent;
            tlpNavegacao.ColumnCount = 3;
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.Controls.Add(btnPedido, 1, 1);
            tlpNavegacao.Controls.Add(btnCliente, 1, 5);
            tlpNavegacao.Controls.Add(btnProduto, 1, 3);
            tlpNavegacao.Controls.Add(tlpHome, 1, 7);
            tlpNavegacao.Dock = DockStyle.Fill;
            tlpNavegacao.Location = new Point(0, 0);
            tlpNavegacao.Margin = new Padding(3, 2, 3, 2);
            tlpNavegacao.Name = "tlpNavegacao";
            tlpNavegacao.RowCount = 9;
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5F));
            tlpNavegacao.Size = new Size(350, 810);
            tlpNavegacao.TabIndex = 13;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.MediumPurple;
            btnPedido.Cursor = Cursors.No;
            btnPedido.Dock = DockStyle.Fill;
            btnPedido.Enabled = false;
            btnPedido.Font = new Font("Segoe UI", 12F);
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(99, 181);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(151, 42);
            btnPedido.TabIndex = 11;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            // 
            // tlpHome
            // 
            tlpHome.ColumnCount = 3;
            tlpHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8710842F));
            tlpHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.25783F));
            tlpHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8710842F));
            tlpHome.Controls.Add(btnHome, 1, 0);
            tlpHome.Location = new Point(99, 516);
            tlpHome.Margin = new Padding(3, 2, 3, 2);
            tlpHome.Name = "tlpHome";
            tlpHome.RowCount = 1;
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHome.Size = new Size(150, 56);
            tlpHome.TabIndex = 19;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(211, 119, 215);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(41, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(66, 50);
            btnHome.TabIndex = 12;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdicao.Cursor = Cursors.Hand;
            btnEdicao.Dock = DockStyle.Fill;
            btnEdicao.FlatStyle = FlatStyle.Popup;
            btnEdicao.ForeColor = Color.Transparent;
            btnEdicao.Image = (Image)resources.GetObject("btnEdicao.Image");
            btnEdicao.Location = new Point(39, 2);
            btnEdicao.Margin = new Padding(3, 2, 3, 2);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(83, 73);
            btnEdicao.TabIndex = 16;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Dock = DockStyle.Fill;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(39, 110);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(83, 28);
            btnDeletar.TabIndex = 18;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(701, 78);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(186, 27);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar Pedido";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // cmbProdutos
            // 
            cmbProdutos.Font = new Font("Segoe UI", 12F);
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(112, 47);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(234, 29);
            cmbProdutos.TabIndex = 2;
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged_1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 12F);
            txtQuantidade.Location = new Point(729, 47);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(158, 29);
            txtQuantidade.TabIndex = 0;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged_1;
            // 
            // lblValorTotal
            // 
            lblValorTotal.BackColor = Color.White;
            lblValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(38, 78);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(97, 21);
            lblValorTotal.TabIndex = 6;
            lblValorTotal.Text = "Valor total";
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(38, 12);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 21);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome Cliente:";
            // 
            // cmbClientes
            // 
            cmbClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(96, 12);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(293, 29);
            cmbClientes.TabIndex = 0;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged_1;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 12F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(368, 78);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(221, 29);
            cmbStatus.TabIndex = 11;
            cmbStatus.Text = "Status";
            // 
            // lblValorP
            // 
            lblValorP.AutoSize = true;
            lblValorP.Font = new Font("Segoe UI", 12F);
            lblValorP.Location = new Point(351, 47);
            lblValorP.Name = "lblValorP";
            lblValorP.Size = new Size(106, 21);
            lblValorP.TabIndex = 12;
            lblValorP.Text = "Valor Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 12F);
            lblQuantidade.Location = new Point(614, 47);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(91, 21);
            lblQuantidade.TabIndex = 12;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblValorProduto
            // 
            lblValorProduto.BackColor = Color.Gainsboro;
            lblValorProduto.Font = new Font("Segoe UI", 12F);
            lblValorProduto.Location = new Point(478, 47);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(93, 21);
            lblValorProduto.TabIndex = 12;
            // 
            // lblContato
            // 
            lblContato.BackColor = Color.Gainsboro;
            lblContato.Font = new Font("Segoe UI", 12F);
            lblContato.Location = new Point(394, 12);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(493, 27);
            lblContato.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Gainsboro;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(144, 78);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(154, 21);
            lblTotal.TabIndex = 13;
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(lblProduto);
            pnlCadastro.Controls.Add(lblTotal);
            pnlCadastro.Controls.Add(lblContato);
            pnlCadastro.Controls.Add(lblValorProduto);
            pnlCadastro.Controls.Add(lblQuantidade);
            pnlCadastro.Controls.Add(lblValorP);
            pnlCadastro.Controls.Add(cmbStatus);
            pnlCadastro.Controls.Add(cmbClientes);
            pnlCadastro.Controls.Add(lblNome);
            pnlCadastro.Controls.Add(lblValorTotal);
            pnlCadastro.Controls.Add(txtQuantidade);
            pnlCadastro.Controls.Add(cmbProdutos);
            pnlCadastro.Controls.Add(btnCadastrar);
            pnlCadastro.Dock = DockStyle.Fill;
            pnlCadastro.Location = new Point(563, 563);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(914, 118);
            pnlCadastro.TabIndex = 13;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 12F);
            lblProduto.Location = new Point(38, 47);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(66, 21);
            lblProduto.TabIndex = 14;
            lblProduto.Text = "Produto";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoEllipsis = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(251, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(410, 39);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Área de Cadastro de Pedidos";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Location = new Point(563, 153);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(914, 381);
            dgvPedidos.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Dock = DockStyle.Fill;
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(563, 104);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(914, 29);
            txtPesquisar.TabIndex = 17;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6651573F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9992695F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.3363075F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9992657F));
            tableLayoutPanel1.Controls.Add(dgvPedidos, 2, 5);
            tableLayoutPanel1.Controls.Add(txtPesquisar, 2, 3);
            tableLayoutPanel1.Controls.Add(pnlCadastro, 2, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.1F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel1.Size = new Size(1664, 775);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.22823F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.54354F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.22823F));
            tableLayoutPanel2.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(563, 26);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(914, 39);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.67133F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.3286743F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel3.Controls.Add(btnDeletar, 1, 2);
            tableLayoutPanel3.Controls.Add(btnEdicao, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1483, 152);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70.83334F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.166666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 242F));
            tableLayoutPanel3.Size = new Size(178, 383);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1664, 775);
            Controls.Add(pnlMenu);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidos_Load_1;
            pnlMenu.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tlpHome.ResumeLayout(false);
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnCliente;
        private Button btnProduto;
        private Panel pnlMenu;
        private Button btnPedido;
        private Button btnEdicao;
        private Button btnHome;
        private Button btnDeletar;
        private Button btnCadastrar;
        private ComboBox cmbProdutos;
        private TextBox txtQuantidade;
        private Label lblValorTotal;
        private Label lblNome;
        private ComboBox cmbClientes;
        private ComboBox cmbStatus;
        private Label lblValorP;
        private Label lblQuantidade;
        private Label lblValorProduto;
        private Label lblContato;
        private Label lblTotal;
        private Panel pnlCadastro;
        private Label lblTitulo;
        private DataGridView dgvPedidos;
        private TextBox txtPesquisar;
        private Label lblProduto;
        private TableLayoutPanel tlpNavegacao;
        private TableLayoutPanel tlpHome;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}