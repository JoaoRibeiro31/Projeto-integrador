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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            txtPesquisar = new TextBox();
            dgvPedidos = new DataGridView();
            pnlMenu = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            btnPedidos = new Button();
            btnProdutos = new Button();
            btnClientes = new Button();
            tlpBtnFecharApp = new TableLayoutPanel();
            btnFecharApp = new Button();
            lblTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tlpTituloSubtitulo = new TableLayoutPanel();
            lblSubtitulo = new Label();
            tlpDataHora = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            lblHora = new Label();
            pictureBox2 = new PictureBox();
            lblData = new Label();
            timerDataHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            pnlMenu.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpBtnFecharApp.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tlpTituloSubtitulo.SuspendLayout();
            tlpDataHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Arial Narrow", 12F);
            txtPesquisar.Location = new Point(638, 141);
            txtPesquisar.Margin = new Padding(3, 5, 3, 5);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar...";
            txtPesquisar.Size = new Size(1030, 30);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToOrderColumns = true;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.GridColor = SystemColors.InactiveCaptionText;
            dgvPedidos.Location = new Point(638, 207);
            dgvPedidos.Margin = new Padding(3, 5, 3, 5);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(1031, 624);
            dgvPedidos.TabIndex = 5;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.AutoScroll = true;
            pnlMenu.BackColor = Color.FromArgb(253, 217, 246);
            pnlMenu.BackgroundImage = (Image)resources.GetObject("pnlMenu.BackgroundImage");
            pnlMenu.BackgroundImageLayout = ImageLayout.Zoom;
            pnlMenu.Controls.Add(tlpNavegacao);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 5, 3, 5);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(400, 1102);
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
            tlpNavegacao.Controls.Add(btnPedidos, 1, 1);
            tlpNavegacao.Controls.Add(btnProdutos, 1, 3);
            tlpNavegacao.Controls.Add(btnClientes, 1, 5);
            tlpNavegacao.Controls.Add(tlpBtnFecharApp, 1, 7);
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
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 5.172414F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 24.954628F));
            tlpNavegacao.Size = new Size(400, 1102);
            tlpNavegacao.TabIndex = 18;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(251, 141, 188);
            btnPedidos.Dock = DockStyle.Fill;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(166, 84, 118);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Image = (Image)resources.GetObject("btnPedidos.Image");
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(113, 247);
            btnPedidos.Margin = new Padding(3, 5, 3, 5);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(174, 56);
            btnPedidos.TabIndex = 0;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(103, 172, 241);
            btnProdutos.Dock = DockStyle.Fill;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 118, 173);
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(113, 401);
            btnProdutos.Margin = new Padding(3, 5, 3, 5);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(174, 56);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(251, 141, 188);
            btnClientes.BackgroundImageLayout = ImageLayout.Zoom;
            btnClientes.Dock = DockStyle.Fill;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(166, 84, 118);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(113, 555);
            btnClientes.Margin = new Padding(3, 5, 3, 5);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(174, 56);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // tlpBtnFecharApp
            // 
            tlpBtnFecharApp.BackgroundImageLayout = ImageLayout.Zoom;
            tlpBtnFecharApp.ColumnCount = 3;
            tlpBtnFecharApp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tlpBtnFecharApp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tlpBtnFecharApp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tlpBtnFecharApp.Controls.Add(btnFecharApp, 1, 0);
            tlpBtnFecharApp.Dock = DockStyle.Fill;
            tlpBtnFecharApp.Location = new Point(113, 773);
            tlpBtnFecharApp.Name = "tlpBtnFecharApp";
            tlpBtnFecharApp.RowCount = 1;
            tlpBtnFecharApp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBtnFecharApp.Size = new Size(174, 50);
            tlpBtnFecharApp.TabIndex = 7;
            // 
            // btnFecharApp
            // 
            btnFecharApp.BackColor = Color.FromArgb(255, 254, 254);
            btnFecharApp.BackgroundImageLayout = ImageLayout.Zoom;
            btnFecharApp.Dock = DockStyle.Fill;
            btnFecharApp.FlatAppearance.BorderSize = 0;
            btnFecharApp.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 184, 183);
            btnFecharApp.FlatStyle = FlatStyle.Flat;
            btnFecharApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFecharApp.ForeColor = Color.FromArgb(212, 124, 155);
            btnFecharApp.Image = (Image)resources.GetObject("btnFecharApp.Image");
            btnFecharApp.ImageAlign = ContentAlignment.MiddleLeft;
            btnFecharApp.Location = new Point(34, 5);
            btnFecharApp.Margin = new Padding(3, 5, 3, 5);
            btnFecharApp.Name = "btnFecharApp";
            btnFecharApp.Size = new Size(105, 40);
            btnFecharApp.TabIndex = 3;
            btnFecharApp.Text = "Sair";
            btnFecharApp.UseVisualStyleBackColor = false;
            btnFecharApp.Click += btnFecharApp_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(225, 103, 148);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(421, 51);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Bem-vinda!";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3F));
            tableLayoutPanel2.Controls.Add(dgvPedidos, 2, 5);
            tableLayoutPanel2.Controls.Add(txtPesquisar, 2, 3);
            tableLayoutPanel2.Controls.Add(tlpTituloSubtitulo, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.23222744F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2369671F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.421801F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 3.772277F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.574257F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.50495F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.18812F));
            tableLayoutPanel2.Size = new Size(1920, 1055);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // tlpTituloSubtitulo
            // 
            tlpTituloSubtitulo.ColumnCount = 3;
            tlpTituloSubtitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.9788857F));
            tlpTituloSubtitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9462566F));
            tlpTituloSubtitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.0748558F));
            tlpTituloSubtitulo.Controls.Add(lblTitulo, 0, 0);
            tlpTituloSubtitulo.Controls.Add(lblSubtitulo, 0, 1);
            tlpTituloSubtitulo.Controls.Add(tlpDataHora, 2, 0);
            tlpTituloSubtitulo.Dock = DockStyle.Fill;
            tlpTituloSubtitulo.Location = new Point(638, 16);
            tlpTituloSubtitulo.Name = "tlpTituloSubtitulo";
            tlpTituloSubtitulo.RowCount = 2;
            tlpTituloSubtitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTituloSubtitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTituloSubtitulo.Size = new Size(1042, 102);
            tlpTituloSubtitulo.TabIndex = 18;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Dock = DockStyle.Fill;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.Location = new Point(3, 51);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(421, 51);
            lblSubtitulo.TabIndex = 18;
            lblSubtitulo.Text = "Escolha uma opção no menu ao lado para começar.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpDataHora
            // 
            tlpDataHora.BackColor = Color.FromArgb(247, 251, 254);
            tlpDataHora.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tlpDataHora.ColumnCount = 4;
            tlpDataHora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.785203F));
            tlpDataHora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.9474945F));
            tlpDataHora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.785203F));
            tlpDataHora.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.7207642F));
            tlpDataHora.Controls.Add(pictureBox1, 0, 0);
            tlpDataHora.Controls.Add(lblHora, 3, 0);
            tlpDataHora.Controls.Add(pictureBox2, 2, 0);
            tlpDataHora.Controls.Add(lblData, 1, 0);
            tlpDataHora.Dock = DockStyle.Fill;
            tlpDataHora.Location = new Point(617, 3);
            tlpDataHora.Name = "tlpDataHora";
            tlpDataHora.RowCount = 1;
            tlpDataHora.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDataHora.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDataHora.Size = new Size(422, 45);
            tlpDataHora.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHora.Location = new Point(247, 11);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(169, 23);
            lblHora.TabIndex = 2;
            lblHora.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Location = new Point(205, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblData.Location = new Point(48, 11);
            lblData.Name = "lblData";
            lblData.Size = new Size(148, 23);
            lblData.TabIndex = 1;
            lblData.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timerDataHora
            // 
            timerDataHora.Interval = 1000;
            timerDataHora.Tick += timerDataHora_Tick;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 246, 254);
            ClientSize = new Size(1920, 1055);
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
            tlpBtnFecharApp.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tlpTituloSubtitulo.ResumeLayout(false);
            tlpTituloSubtitulo.PerformLayout();
            tlpDataHora.ResumeLayout(false);
            tlpDataHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPesquisar;
        private DataGridView dgvPedidos;
        private Panel pnlMenu;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlpNavegacao;
        private Button btnPedidos;
        private Button btnProdutos;
        private Button btnFecharApp;
        private Button btnClientes;
        private TableLayoutPanel tlpBtnFecharApp;
        private TableLayoutPanel tlpTituloSubtitulo;
        private Label lblSubtitulo;
        private TableLayoutPanel tlpDataHora;
        private PictureBox pictureBox1;
        private Label lblData;
        private Label lblHora;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerDataHora;
    }
}