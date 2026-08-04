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
            pnlNavegacao = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            btnPedidos = new Button();
            btnProdutos = new Button();
            btnClientes = new Button();
            tlpBtnFecharApp = new TableLayoutPanel();
            btnFecharApp = new Button();
            tlpConfiguracao = new TableLayoutPanel();
            btnConfiguracao = new Button();
            lblTitulo = new Label();
            tlpPrincipal = new TableLayoutPanel();
            tlpTituloSubtitulo = new TableLayoutPanel();
            lblSubtitulo = new Label();
            tlpDataHora = new TableLayoutPanel();
            picData = new PictureBox();
            lblHora = new Label();
            picHora = new PictureBox();
            lblData = new Label();
            tlpDados = new TableLayoutPanel();
            tlpDadosPedidos = new TableLayoutPanel();
            picDadosPedidos = new PictureBox();
            tlpLblPedidos = new TableLayoutPanel();
            lblDadosPedidos = new Label();
            lblTlpPedidos = new Label();
            tlpDadosProdutos = new TableLayoutPanel();
            picDadosProdutos = new PictureBox();
            tlpLblProdutos = new TableLayoutPanel();
            lblDadosProdutos = new Label();
            lblTlpProdutos = new Label();
            tlpDadosClientes = new TableLayoutPanel();
            picDadosClientes = new PictureBox();
            tlpLblClientes = new TableLayoutPanel();
            lblDadosClientes = new Label();
            lblTlpClientes = new Label();
            tlpDadosPendencias = new TableLayoutPanel();
            picDadosPendencias = new PictureBox();
            tlpLblPendencias = new TableLayoutPanel();
            lblDadosPendencias = new Label();
            lblTlpPendencias = new Label();
            timerDataHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            pnlNavegacao.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpBtnFecharApp.SuspendLayout();
            tlpConfiguracao.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            tlpTituloSubtitulo.SuspendLayout();
            tlpDataHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHora).BeginInit();
            tlpDados.SuspendLayout();
            tlpDadosPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDadosPedidos).BeginInit();
            tlpLblPedidos.SuspendLayout();
            tlpDadosProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDadosProdutos).BeginInit();
            tlpLblProdutos.SuspendLayout();
            tlpDadosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDadosClientes).BeginInit();
            tlpLblClientes.SuspendLayout();
            tlpDadosPendencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDadosPendencias).BeginInit();
            tlpLblPendencias.SuspendLayout();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.Font = new Font("Arial Narrow", 12F);
            txtPesquisar.Location = new Point(638, 141);
            txtPesquisar.Margin = new Padding(3, 5, 3, 5);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar...";
            txtPesquisar.Size = new Size(1042, 30);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AllowUserToResizeColumns = false;
            dgvPedidos.AllowUserToResizeRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.GridColor = SystemColors.InactiveCaptionText;
            dgvPedidos.Location = new Point(638, 207);
            dgvPedidos.Margin = new Padding(3, 5, 3, 5);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1042, 639);
            dgvPedidos.TabIndex = 5;
            // 
            // pnlNavegacao
            // 
            pnlNavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlNavegacao.AutoScroll = true;
            pnlNavegacao.BackColor = Color.FromArgb(251, 225, 248);
            pnlNavegacao.BackgroundImage = (Image)resources.GetObject("pnlNavegacao.BackgroundImage");
            pnlNavegacao.BackgroundImageLayout = ImageLayout.Zoom;
            pnlNavegacao.Controls.Add(tlpNavegacao);
            pnlNavegacao.Location = new Point(0, 0);
            pnlNavegacao.Margin = new Padding(3, 5, 3, 5);
            pnlNavegacao.Name = "pnlNavegacao";
            pnlNavegacao.Size = new Size(400, 1080);
            pnlNavegacao.TabIndex = 1;
            // 
            // tlpNavegacao
            // 
            tlpNavegacao.BackColor = Color.Transparent;
            tlpNavegacao.ColumnCount = 3;
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.Controls.Add(btnPedidos, 1, 1);
            tlpNavegacao.Controls.Add(btnProdutos, 1, 3);
            tlpNavegacao.Controls.Add(btnClientes, 1, 5);
            tlpNavegacao.Controls.Add(tlpBtnFecharApp, 1, 7);
            tlpNavegacao.Controls.Add(tlpConfiguracao, 1, 6);
            tlpNavegacao.Dock = DockStyle.Fill;
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
            tlpNavegacao.Size = new Size(400, 1080);
            tlpNavegacao.TabIndex = 1;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(251, 141, 188);
            btnPedidos.BackgroundImageLayout = ImageLayout.Zoom;
            btnPedidos.Cursor = Cursors.Hand;
            btnPedidos.Dock = DockStyle.Fill;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(166, 84, 118);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Image = (Image)resources.GetObject("btnPedidos.Image");
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(113, 242);
            btnPedidos.Margin = new Padding(3, 5, 3, 5);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(174, 54);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(103, 172, 241);
            btnProdutos.BackgroundImageLayout = ImageLayout.Zoom;
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.Dock = DockStyle.Fill;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 118, 173);
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(113, 392);
            btnProdutos.Margin = new Padding(3, 5, 3, 5);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(174, 54);
            btnProdutos.TabIndex = 3;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(251, 141, 188);
            btnClientes.BackgroundImageLayout = ImageLayout.Zoom;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Dock = DockStyle.Fill;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(166, 84, 118);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(113, 542);
            btnClientes.Margin = new Padding(3, 5, 3, 5);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(174, 54);
            btnClientes.TabIndex = 4;
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
            tlpBtnFecharApp.Location = new Point(113, 755);
            tlpBtnFecharApp.Name = "tlpBtnFecharApp";
            tlpBtnFecharApp.RowCount = 1;
            tlpBtnFecharApp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBtnFecharApp.Size = new Size(174, 49);
            tlpBtnFecharApp.TabIndex = 6;
            // 
            // btnFecharApp
            // 
            btnFecharApp.BackColor = Color.FromArgb(255, 254, 254);
            btnFecharApp.BackgroundImageLayout = ImageLayout.Zoom;
            btnFecharApp.Cursor = Cursors.Hand;
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
            btnFecharApp.Size = new Size(105, 39);
            btnFecharApp.TabIndex = 0;
            btnFecharApp.Text = "Sair";
            btnFecharApp.UseVisualStyleBackColor = false;
            btnFecharApp.Click += btnFecharApp_Click;
            // 
            // tlpConfiguracao
            // 
            tlpConfiguracao.ColumnCount = 3;
            tlpConfiguracao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpConfiguracao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpConfiguracao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpConfiguracao.Controls.Add(btnConfiguracao, 1, 1);
            tlpConfiguracao.Dock = DockStyle.Fill;
            tlpConfiguracao.Location = new Point(113, 604);
            tlpConfiguracao.Name = "tlpConfiguracao";
            tlpConfiguracao.RowCount = 3;
            tlpConfiguracao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpConfiguracao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpConfiguracao.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpConfiguracao.Size = new Size(174, 145);
            tlpConfiguracao.TabIndex = 5;
            tlpConfiguracao.TabStop = true;
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.BackgroundImage = (Image)resources.GetObject("btnConfiguracao.BackgroundImage");
            btnConfiguracao.BackgroundImageLayout = ImageLayout.Zoom;
            btnConfiguracao.Cursor = Cursors.Hand;
            btnConfiguracao.Dock = DockStyle.Fill;
            btnConfiguracao.FlatAppearance.BorderSize = 0;
            btnConfiguracao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConfiguracao.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConfiguracao.FlatStyle = FlatStyle.Flat;
            btnConfiguracao.ForeColor = SystemColors.ControlText;
            btnConfiguracao.Location = new Point(46, 40);
            btnConfiguracao.Margin = new Padding(3, 4, 3, 4);
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Size = new Size(81, 64);
            btnConfiguracao.TabIndex = 0;
            btnConfiguracao.UseVisualStyleBackColor = true;
            btnConfiguracao.Click += btnConfiguracao_Click;
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
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bem-vinda!";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.Transparent;
            tlpPrincipal.ColumnCount = 4;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3F));
            tlpPrincipal.Controls.Add(dgvPedidos, 2, 5);
            tlpPrincipal.Controls.Add(txtPesquisar, 2, 3);
            tlpPrincipal.Controls.Add(tlpTituloSubtitulo, 2, 1);
            tlpPrincipal.Controls.Add(tlpDados, 2, 6);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 7;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 1.232227F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 10.23697F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 1.421801F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 3.772277F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 2.574257F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 61.50495F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 19.18812F));
            tlpPrincipal.Size = new Size(1920, 1055);
            tlpPrincipal.TabIndex = 2;
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
            tlpTituloSubtitulo.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Dock = DockStyle.Fill;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.Location = new Point(3, 51);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(421, 51);
            lblSubtitulo.TabIndex = 0;
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
            tlpDataHora.Controls.Add(picData, 0, 0);
            tlpDataHora.Controls.Add(lblHora, 3, 0);
            tlpDataHora.Controls.Add(picHora, 2, 0);
            tlpDataHora.Controls.Add(lblData, 1, 0);
            tlpDataHora.Dock = DockStyle.Fill;
            tlpDataHora.Location = new Point(617, 3);
            tlpDataHora.Name = "tlpDataHora";
            tlpDataHora.RowCount = 1;
            tlpDataHora.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDataHora.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDataHora.Size = new Size(422, 45);
            tlpDataHora.TabIndex = 0;
            // 
            // picData
            // 
            picData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picData.Image = (Image)resources.GetObject("picData.Image");
            picData.Location = new Point(6, 6);
            picData.Name = "picData";
            picData.Size = new Size(33, 33);
            picData.TabIndex = 0;
            picData.TabStop = false;
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
            // picHora
            // 
            picHora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picHora.Image = (Image)resources.GetObject("picHora.Image");
            picHora.Location = new Point(205, 6);
            picHora.Name = "picHora";
            picHora.Size = new Size(33, 33);
            picHora.TabIndex = 3;
            picHora.TabStop = false;
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
            // tlpDados
            // 
            tlpDados.BackColor = Color.FromArgb(253, 253, 255);
            tlpDados.ColumnCount = 9;
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tlpDados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tlpDados.Controls.Add(tlpDadosPedidos, 1, 1);
            tlpDados.Controls.Add(tlpDadosProdutos, 3, 1);
            tlpDados.Controls.Add(tlpDadosClientes, 5, 1);
            tlpDados.Controls.Add(tlpDadosPendencias, 7, 1);
            tlpDados.Dock = DockStyle.Fill;
            tlpDados.Location = new Point(638, 854);
            tlpDados.Name = "tlpDados";
            tlpDados.RowCount = 3;
            tlpDados.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tlpDados.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tlpDados.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tlpDados.Size = new Size(1042, 198);
            tlpDados.TabIndex = 0;
            // 
            // tlpDadosPedidos
            // 
            tlpDadosPedidos.BackColor = Color.FromArgb(253, 237, 247);
            tlpDadosPedidos.ColumnCount = 2;
            tlpDadosPedidos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpDadosPedidos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpDadosPedidos.Controls.Add(picDadosPedidos, 0, 0);
            tlpDadosPedidos.Controls.Add(tlpLblPedidos, 1, 0);
            tlpDadosPedidos.Dock = DockStyle.Fill;
            tlpDadosPedidos.Location = new Point(23, 40);
            tlpDadosPedidos.Name = "tlpDadosPedidos";
            tlpDadosPedidos.RowCount = 1;
            tlpDadosPedidos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDadosPedidos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDadosPedidos.Size = new Size(228, 117);
            tlpDadosPedidos.TabIndex = 0;
            // 
            // picDadosPedidos
            // 
            picDadosPedidos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picDadosPedidos.BackColor = Color.Transparent;
            picDadosPedidos.Image = (Image)resources.GetObject("picDadosPedidos.Image");
            picDadosPedidos.Location = new Point(3, 16);
            picDadosPedidos.Name = "picDadosPedidos";
            picDadosPedidos.Size = new Size(85, 85);
            picDadosPedidos.TabIndex = 0;
            picDadosPedidos.TabStop = false;
            // 
            // tlpLblPedidos
            // 
            tlpLblPedidos.ColumnCount = 1;
            tlpLblPedidos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLblPedidos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLblPedidos.Controls.Add(lblDadosPedidos, 0, 0);
            tlpLblPedidos.Controls.Add(lblTlpPedidos, 0, 1);
            tlpLblPedidos.Dock = DockStyle.Fill;
            tlpLblPedidos.Location = new Point(94, 3);
            tlpLblPedidos.Name = "tlpLblPedidos";
            tlpLblPedidos.RowCount = 2;
            tlpLblPedidos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLblPedidos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLblPedidos.Size = new Size(131, 111);
            tlpLblPedidos.TabIndex = 0;
            // 
            // lblDadosPedidos
            // 
            lblDadosPedidos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDadosPedidos.AutoSize = true;
            lblDadosPedidos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDadosPedidos.ForeColor = Color.FromArgb(229, 55, 119);
            lblDadosPedidos.Location = new Point(3, 20);
            lblDadosPedidos.Name = "lblDadosPedidos";
            lblDadosPedidos.Size = new Size(125, 35);
            lblDadosPedidos.TabIndex = 0;
            // 
            // lblTlpPedidos
            // 
            lblTlpPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTlpPedidos.AutoSize = true;
            lblTlpPedidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTlpPedidos.Location = new Point(3, 55);
            lblTlpPedidos.Name = "lblTlpPedidos";
            lblTlpPedidos.Size = new Size(125, 46);
            lblTlpPedidos.TabIndex = 0;
            lblTlpPedidos.Text = "Pedidos \r\npendentes";
            // 
            // tlpDadosProdutos
            // 
            tlpDadosProdutos.BackColor = Color.FromArgb(174, 180, 227);
            tlpDadosProdutos.ColumnCount = 2;
            tlpDadosProdutos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpDadosProdutos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpDadosProdutos.Controls.Add(picDadosProdutos, 0, 0);
            tlpDadosProdutos.Controls.Add(tlpLblProdutos, 1, 0);
            tlpDadosProdutos.Dock = DockStyle.Fill;
            tlpDadosProdutos.Location = new Point(277, 40);
            tlpDadosProdutos.Name = "tlpDadosProdutos";
            tlpDadosProdutos.RowCount = 1;
            tlpDadosProdutos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDadosProdutos.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDadosProdutos.Size = new Size(228, 117);
            tlpDadosProdutos.TabIndex = 0;
            // 
            // picDadosProdutos
            // 
            picDadosProdutos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picDadosProdutos.BackColor = Color.Transparent;
            picDadosProdutos.Image = (Image)resources.GetObject("picDadosProdutos.Image");
            picDadosProdutos.Location = new Point(3, 16);
            picDadosProdutos.Name = "picDadosProdutos";
            picDadosProdutos.Size = new Size(85, 85);
            picDadosProdutos.TabIndex = 0;
            picDadosProdutos.TabStop = false;
            // 
            // tlpLblProdutos
            // 
            tlpLblProdutos.ColumnCount = 1;
            tlpLblProdutos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLblProdutos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLblProdutos.Controls.Add(lblDadosProdutos, 0, 0);
            tlpLblProdutos.Controls.Add(lblTlpProdutos, 0, 1);
            tlpLblProdutos.Dock = DockStyle.Fill;
            tlpLblProdutos.Location = new Point(94, 3);
            tlpLblProdutos.Name = "tlpLblProdutos";
            tlpLblProdutos.RowCount = 2;
            tlpLblProdutos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLblProdutos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLblProdutos.Size = new Size(131, 111);
            tlpLblProdutos.TabIndex = 0;
            // 
            // lblDadosProdutos
            // 
            lblDadosProdutos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDadosProdutos.AutoSize = true;
            lblDadosProdutos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDadosProdutos.ForeColor = Color.FromArgb(44, 131, 221);
            lblDadosProdutos.Location = new Point(3, 20);
            lblDadosProdutos.Name = "lblDadosProdutos";
            lblDadosProdutos.Size = new Size(125, 35);
            lblDadosProdutos.TabIndex = 0;
            // 
            // lblTlpProdutos
            // 
            lblTlpProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTlpProdutos.AutoSize = true;
            lblTlpProdutos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTlpProdutos.Location = new Point(3, 55);
            lblTlpProdutos.Name = "lblTlpProdutos";
            lblTlpProdutos.Size = new Size(125, 46);
            lblTlpProdutos.TabIndex = 0;
            lblTlpProdutos.Text = "Produto\r\ncadastrados";
            // 
            // tlpDadosClientes
            // 
            tlpDadosClientes.BackColor = Color.FromArgb(253, 237, 247);
            tlpDadosClientes.ColumnCount = 2;
            tlpDadosClientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpDadosClientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpDadosClientes.Controls.Add(picDadosClientes, 0, 0);
            tlpDadosClientes.Controls.Add(tlpLblClientes, 1, 0);
            tlpDadosClientes.Dock = DockStyle.Fill;
            tlpDadosClientes.Location = new Point(531, 40);
            tlpDadosClientes.Name = "tlpDadosClientes";
            tlpDadosClientes.RowCount = 1;
            tlpDadosClientes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDadosClientes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDadosClientes.Size = new Size(228, 117);
            tlpDadosClientes.TabIndex = 0;
            // 
            // picDadosClientes
            // 
            picDadosClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picDadosClientes.BackColor = Color.Transparent;
            picDadosClientes.Image = (Image)resources.GetObject("picDadosClientes.Image");
            picDadosClientes.Location = new Point(3, 16);
            picDadosClientes.Name = "picDadosClientes";
            picDadosClientes.Size = new Size(85, 85);
            picDadosClientes.TabIndex = 0;
            picDadosClientes.TabStop = false;
            // 
            // tlpLblClientes
            // 
            tlpLblClientes.ColumnCount = 1;
            tlpLblClientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLblClientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLblClientes.Controls.Add(lblDadosClientes, 0, 0);
            tlpLblClientes.Controls.Add(lblTlpClientes, 0, 1);
            tlpLblClientes.Dock = DockStyle.Fill;
            tlpLblClientes.Location = new Point(94, 3);
            tlpLblClientes.Name = "tlpLblClientes";
            tlpLblClientes.RowCount = 2;
            tlpLblClientes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLblClientes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLblClientes.Size = new Size(131, 111);
            tlpLblClientes.TabIndex = 0;
            // 
            // lblDadosClientes
            // 
            lblDadosClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDadosClientes.AutoSize = true;
            lblDadosClientes.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDadosClientes.ForeColor = Color.FromArgb(229, 55, 119);
            lblDadosClientes.Location = new Point(3, 20);
            lblDadosClientes.Name = "lblDadosClientes";
            lblDadosClientes.Size = new Size(125, 35);
            lblDadosClientes.TabIndex = 0;
            // 
            // lblTlpClientes
            // 
            lblTlpClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTlpClientes.AutoSize = true;
            lblTlpClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTlpClientes.Location = new Point(3, 55);
            lblTlpClientes.Name = "lblTlpClientes";
            lblTlpClientes.Size = new Size(125, 46);
            lblTlpClientes.TabIndex = 0;
            lblTlpClientes.Text = "Clientes \r\ncadastrados";
            // 
            // tlpDadosPendencias
            // 
            tlpDadosPendencias.BackColor = Color.FromArgb(174, 180, 227);
            tlpDadosPendencias.ColumnCount = 2;
            tlpDadosPendencias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpDadosPendencias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpDadosPendencias.Controls.Add(picDadosPendencias, 0, 0);
            tlpDadosPendencias.Controls.Add(tlpLblPendencias, 1, 0);
            tlpDadosPendencias.Dock = DockStyle.Fill;
            tlpDadosPendencias.Location = new Point(785, 40);
            tlpDadosPendencias.Name = "tlpDadosPendencias";
            tlpDadosPendencias.RowCount = 1;
            tlpDadosPendencias.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDadosPendencias.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDadosPendencias.Size = new Size(228, 117);
            tlpDadosPendencias.TabIndex = 0;
            // 
            // picDadosPendencias
            // 
            picDadosPendencias.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picDadosPendencias.BackColor = Color.Transparent;
            picDadosPendencias.Image = (Image)resources.GetObject("picDadosPendencias.Image");
            picDadosPendencias.Location = new Point(3, 16);
            picDadosPendencias.Name = "picDadosPendencias";
            picDadosPendencias.Size = new Size(85, 85);
            picDadosPendencias.TabIndex = 0;
            picDadosPendencias.TabStop = false;
            // 
            // tlpLblPendencias
            // 
            tlpLblPendencias.ColumnCount = 1;
            tlpLblPendencias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLblPendencias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLblPendencias.Controls.Add(lblDadosPendencias, 0, 0);
            tlpLblPendencias.Controls.Add(lblTlpPendencias, 0, 1);
            tlpLblPendencias.Dock = DockStyle.Fill;
            tlpLblPendencias.Location = new Point(94, 3);
            tlpLblPendencias.Name = "tlpLblPendencias";
            tlpLblPendencias.RowCount = 2;
            tlpLblPendencias.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLblPendencias.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLblPendencias.Size = new Size(131, 111);
            tlpLblPendencias.TabIndex = 0;
            // 
            // lblDadosPendencias
            // 
            lblDadosPendencias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDadosPendencias.AutoSize = true;
            lblDadosPendencias.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDadosPendencias.ForeColor = Color.FromArgb(44, 131, 221);
            lblDadosPendencias.Location = new Point(3, 32);
            lblDadosPendencias.Name = "lblDadosPendencias";
            lblDadosPendencias.Size = new Size(125, 23);
            lblDadosPendencias.TabIndex = 0;
            // 
            // lblTlpPendencias
            // 
            lblTlpPendencias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTlpPendencias.AutoSize = true;
            lblTlpPendencias.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTlpPendencias.Location = new Point(3, 55);
            lblTlpPendencias.Name = "lblTlpPendencias";
            lblTlpPendencias.Size = new Size(125, 46);
            lblTlpPendencias.TabIndex = 0;
            lblTlpPendencias.Text = "Total de\r\npendências";
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
            Controls.Add(pnlNavegacao);
            Controls.Add(tlpPrincipal);
            Margin = new Padding(3, 5, 3, 5);
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormClosed += frmHome_FormClosed;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            pnlNavegacao.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tlpBtnFecharApp.ResumeLayout(false);
            tlpConfiguracao.ResumeLayout(false);
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            tlpTituloSubtitulo.ResumeLayout(false);
            tlpTituloSubtitulo.PerformLayout();
            tlpDataHora.ResumeLayout(false);
            tlpDataHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picData).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHora).EndInit();
            tlpDados.ResumeLayout(false);
            tlpDadosPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDadosPedidos).EndInit();
            tlpLblPedidos.ResumeLayout(false);
            tlpLblPedidos.PerformLayout();
            tlpDadosProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDadosProdutos).EndInit();
            tlpLblProdutos.ResumeLayout(false);
            tlpLblProdutos.PerformLayout();
            tlpDadosClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDadosClientes).EndInit();
            tlpLblClientes.ResumeLayout(false);
            tlpLblClientes.PerformLayout();
            tlpDadosPendencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDadosPendencias).EndInit();
            tlpLblPendencias.ResumeLayout(false);
            tlpLblPendencias.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPesquisar;
        private DataGridView dgvPedidos;
        private Panel pnlNavegacao;
        private Label lblTitulo;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpNavegacao;
        private Button btnPedidos;
        private Button btnProdutos;
        private Button btnFecharApp;
        private Button btnClientes;
        private TableLayoutPanel tlpBtnFecharApp;
        private TableLayoutPanel tlpTituloSubtitulo;
        private Label lblSubtitulo;
        private TableLayoutPanel tlpDataHora;
        private PictureBox picData;
        private Label lblData;
        private Label lblHora;
        private PictureBox picHora;
        private System.Windows.Forms.Timer timerDataHora;
        private TableLayoutPanel tlpDados;
        private TableLayoutPanel tlpDadosPedidos;
        private PictureBox picDadosPedidos;
        private TableLayoutPanel tlpDadosProdutos;
        private PictureBox picDadosProdutos;
        private TableLayoutPanel tlpDadosClientes;
        private PictureBox picDadosClientes;
        private TableLayoutPanel tlpDadosPendencias;
        private PictureBox picDadosPendencias;
        private TableLayoutPanel tlpLblPedidos;
        private Label lblDadosPedidos;
        private TableLayoutPanel tlpLblProdutos;
        private Label lblDadosProdutos;
        private TableLayoutPanel tlpLblClientes;
        private Label lblDadosClientes;
        private TableLayoutPanel tlpLblPendencias;
        private Label lblDadosPendencias;
        private Label lblTlpPedidos;
        private Label lblTlpProdutos;
        private Label lblTlpClientes;
        private Label lblTlpPendencias;
        private TableLayoutPanel tlpConfiguracao;
        private Button btnConfiguracao;
    }
}