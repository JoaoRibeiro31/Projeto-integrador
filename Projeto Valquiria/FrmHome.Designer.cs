namespace Projeto_Valquiria
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            txtPesquisar = new TextBox();
            dgvPedidos = new DataGridView();
            pnlMenu = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            btnPedido = new Button();
            btnProduto = new Button();
            btnCliente = new Button();
            lblDesligar = new Label();
            btnFecharApp = new Button();
            lblTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            pnlMenu.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Dock = DockStyle.Fill;
            txtPesquisar.Font = new Font("Arial Narrow", 12F);
            txtPesquisar.Location = new Point(631, 138);
            txtPesquisar.Margin = new Padding(3, 5, 3, 5);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(1032, 30);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToOrderColumns = true;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Location = new Point(631, 202);
            dgvPedidos.Margin = new Padding(3, 5, 3, 5);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(1032, 625);
            dgvPedidos.TabIndex = 5;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.AutoScroll = true;
            pnlMenu.BackColor = Color.FromArgb(240, 192, 229);
            pnlMenu.BackgroundImage = (Image)resources.GetObject("pnlMenu.BackgroundImage");
            pnlMenu.Controls.Add(tlpNavegacao);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 5, 3, 5);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(400, 1080);
            pnlMenu.TabIndex = 16;
            // 
            // tlpNavegacao
            // 
            tlpNavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tlpNavegacao.BackColor = Color.Transparent;
            tlpNavegacao.ColumnCount = 3;
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.Controls.Add(btnPedido, 1, 1);
            tlpNavegacao.Controls.Add(btnProduto, 1, 3);
            tlpNavegacao.Controls.Add(btnCliente, 1, 5);
            tlpNavegacao.Controls.Add(lblDesligar, 1, 8);
            tlpNavegacao.Controls.Add(btnFecharApp, 1, 7);
            tlpNavegacao.Location = new Point(0, 0);
            tlpNavegacao.Name = "tlpNavegacao";
            tlpNavegacao.RowCount = 9;
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tlpNavegacao.Size = new Size(400, 1080);
            tlpNavegacao.TabIndex = 18;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.MediumPurple;
            btnPedido.Dock = DockStyle.Fill;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Segoe UI", 12F);
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(113, 242);
            btnPedido.Margin = new Padding(3, 5, 3, 5);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(174, 54);
            btnPedido.TabIndex = 0;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedidos_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.MediumSeaGreen;
            btnProduto.Dock = DockStyle.Fill;
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.Font = new Font("Segoe UI", 12F);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(113, 392);
            btnProduto.Margin = new Padding(3, 5, 3, 5);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(174, 54);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProdutos_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.Dock = DockStyle.Fill;
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(113, 542);
            btnCliente.Margin = new Padding(3, 5, 3, 5);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(174, 54);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // lblDesligar
            // 
            lblDesligar.Anchor = AnchorStyles.Top;
            lblDesligar.BackColor = Color.Pink;
            lblDesligar.BorderStyle = BorderStyle.FixedSingle;
            lblDesligar.Enabled = false;
            lblDesligar.Location = new Point(161, 827);
            lblDesligar.Name = "lblDesligar";
            lblDesligar.Size = new Size(77, 33);
            lblDesligar.TabIndex = 7;
            lblDesligar.Text = "Desligar";
            lblDesligar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFecharApp
            // 
            btnFecharApp.Anchor = AnchorStyles.None;
            btnFecharApp.BackColor = Color.Transparent;
            btnFecharApp.BackgroundImage = (Image)resources.GetObject("btnFecharApp.BackgroundImage");
            btnFecharApp.BackgroundImageLayout = ImageLayout.Stretch;
            btnFecharApp.FlatStyle = FlatStyle.Popup;
            btnFecharApp.Location = new Point(161, 757);
            btnFecharApp.Margin = new Padding(3, 5, 3, 5);
            btnFecharApp.Name = "btnFecharApp";
            btnFecharApp.Size = new Size(77, 65);
            btnFecharApp.TabIndex = 3;
            btnFecharApp.UseVisualStyleBackColor = false;
            btnFecharApp.Click += btnFecharApp_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.BackColor = Color.White;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(1091, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(111, 47);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Home";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3F));
            tableLayoutPanel2.Controls.Add(lblTitulo, 2, 1);
            tableLayoutPanel2.Controls.Add(dgvPedidos, 2, 5);
            tableLayoutPanel2.Controls.Add(txtPesquisar, 2, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 3.069307F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.554455F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.336634F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 3.772277F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.574257F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.50495F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.18812F));
            tableLayoutPanel2.Size = new Size(1902, 1033);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 190);
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlMenu);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            pnlMenu.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPesquisar;
        private DataGridView dgvPedidos;
        private Panel pnlMenu;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlpNavegacao;
        private Button btnPedido;
        private Button btnProduto;
        private Label lblDesligar;
        private Button btnFecharApp;
        private Button btnCliente;
    }
}