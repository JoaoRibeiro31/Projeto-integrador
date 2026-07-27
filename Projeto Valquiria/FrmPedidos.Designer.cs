namespace Projeto_Valquiria
{
    partial class frmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            pnlNavegacao = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            btnPedidos = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            tlpHome = new TableLayoutPanel();
            btnHome = new Button();
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
            lblProduto = new Label();
            lblTitulo = new Label();
            dgvDadosPedidos = new DataGridView();
            txtPesquisar = new TextBox();
            tlpPrincipal = new TableLayoutPanel();
            tlpCadastro = new TableLayoutPanel();
            tlpLinha1 = new TableLayoutPanel();
            tlpLinha2 = new TableLayoutPanel();
            tlpLinha3 = new TableLayoutPanel();
            tlpEdicao = new TableLayoutPanel();
            btnEdicao = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            pnlNavegacao.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosPedidos).BeginInit();
            tlpPrincipal.SuspendLayout();
            tlpCadastro.SuspendLayout();
            tlpLinha1.SuspendLayout();
            tlpLinha2.SuspendLayout();
            tlpLinha3.SuspendLayout();
            tlpEdicao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavegacao
            // 
            pnlNavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlNavegacao.BackColor = Color.FromArgb(251, 225, 248);
            pnlNavegacao.BackgroundImage = (Image)resources.GetObject("pnlNavegacao.BackgroundImage");
            pnlNavegacao.BackgroundImageLayout = ImageLayout.Zoom;
            pnlNavegacao.Controls.Add(tlpNavegacao);
            pnlNavegacao.Location = new Point(0, 0);
            pnlNavegacao.Margin = new Padding(3, 4, 3, 4);
            pnlNavegacao.Name = "pnlNavegacao";
            pnlNavegacao.Size = new Size(400, 1102);
            pnlNavegacao.TabIndex = 0;
            // 
            // tlpNavegacao
            // 
            tlpNavegacao.BackColor = Color.Transparent;
            tlpNavegacao.ColumnCount = 3;
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.Controls.Add(btnPedidos, 1, 1);
            tlpNavegacao.Controls.Add(btnClientes, 1, 5);
            tlpNavegacao.Controls.Add(btnProdutos, 1, 3);
            tlpNavegacao.Controls.Add(tlpHome, 1, 7);
            tlpNavegacao.Dock = DockStyle.Fill;
            tlpNavegacao.Location = new Point(0, 0);
            tlpNavegacao.Name = "tlpNavegacao";
            tlpNavegacao.RowCount = 9;
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 21.9739F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 5.992882F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 7.99050951F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 5.992882F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 7.99050951F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 5.992882F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9833918F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 5.16264439F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9204F));
            tlpNavegacao.Size = new Size(400, 1102);
            tlpNavegacao.TabIndex = 1;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(251, 141, 188);
            btnPedidos.BackgroundImageLayout = ImageLayout.Zoom;
            btnPedidos.Cursor = Cursors.No;
            btnPedidos.Dock = DockStyle.Fill;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(166, 84, 118);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Image = (Image)resources.GetObject("btnPedidos.Image");
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(113, 246);
            btnPedidos.Margin = new Padding(3, 4, 3, 4);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(174, 58);
            btnPedidos.TabIndex = 1;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
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
            btnClientes.Location = new Point(113, 554);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(174, 58);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(103, 172, 241);
            btnProdutos.BackgroundImageLayout = ImageLayout.Zoom;
            btnProdutos.Dock = DockStyle.Fill;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 118, 173);
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(113, 400);
            btnProdutos.Margin = new Padding(3, 4, 3, 4);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(174, 58);
            btnProdutos.TabIndex = 2;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // tlpHome
            // 
            tlpHome.ColumnCount = 3;
            tlpHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpHome.Controls.Add(btnHome, 1, 0);
            tlpHome.Dock = DockStyle.Fill;
            tlpHome.Location = new Point(113, 773);
            tlpHome.Name = "tlpHome";
            tlpHome.RowCount = 1;
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHome.Size = new Size(174, 50);
            tlpHome.TabIndex = 4;
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = AccessibleRole.None;
            btnHome.BackColor = Color.FromArgb(255, 254, 254);
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 184, 183);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(212, 124, 155);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(29, 4);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(115, 42);
            btnHome.TabIndex = 1;
            btnHome.Text = "Voltar";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(103, 172, 241);
            btnCadastrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrar.Dock = DockStyle.Fill;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(77, 136, 199);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 89, 130);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(1004, 4);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(175, 35);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // cmbProdutos
            // 
            cmbProdutos.Dock = DockStyle.Fill;
            cmbProdutos.FlatStyle = FlatStyle.Flat;
            cmbProdutos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(171, 4);
            cmbProdutos.Margin = new Padding(3, 4, 3, 4);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(296, 36);
            cmbProdutos.TabIndex = 1;
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged_1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Dock = DockStyle.Fill;
            txtQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtQuantidade.Location = new Point(1076, 4);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(102, 34);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged_1;
            // 
            // lblValorTotal
            // 
            lblValorTotal.BackColor = Color.Transparent;
            lblValorTotal.Dock = DockStyle.Fill;
            lblValorTotal.FlatStyle = FlatStyle.Flat;
            lblValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.ForeColor = Color.FromArgb(229, 55, 119);
            lblValorTotal.Location = new Point(27, 0);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(163, 43);
            lblValorTotal.TabIndex = 0;
            lblValorTotal.Text = "Valor total:";
            lblValorTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            lblNome.Dock = DockStyle.Fill;
            lblNome.FlatStyle = FlatStyle.Flat;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(229, 55, 119);
            lblNome.Location = new Point(27, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(139, 43);
            lblNome.TabIndex = 0;
            lblNome.Text = "Cliente:";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbClientes
            // 
            cmbClientes.Dock = DockStyle.Fill;
            cmbClientes.FlatStyle = FlatStyle.Flat;
            cmbClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(220, 4);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(478, 36);
            cmbClientes.TabIndex = 1;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged_1;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(642, 4);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(199, 36);
            cmbStatus.TabIndex = 1;
            cmbStatus.Text = "Status";
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // lblValorP
            // 
            lblValorP.AutoSize = true;
            lblValorP.Dock = DockStyle.Fill;
            lblValorP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValorP.ForeColor = Color.FromArgb(229, 55, 119);
            lblValorP.Location = new Point(497, 0);
            lblValorP.Name = "lblValorP";
            lblValorP.Size = new Size(187, 43);
            lblValorP.TabIndex = 0;
            lblValorP.Text = "Valor do produto:";
            lblValorP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Dock = DockStyle.Fill;
            lblQuantidade.FlatStyle = FlatStyle.Flat;
            lblQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuantidade.ForeColor = Color.FromArgb(229, 55, 119);
            lblQuantidade.Location = new Point(907, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(139, 43);
            lblQuantidade.TabIndex = 0;
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblValorProduto
            // 
            lblValorProduto.BackColor = Color.FromArgb(174, 180, 227);
            lblValorProduto.Dock = DockStyle.Fill;
            lblValorProduto.FlatStyle = FlatStyle.Flat;
            lblValorProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValorProduto.ForeColor = Color.FromArgb(44, 131, 221);
            lblValorProduto.Location = new Point(714, 0);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(163, 43);
            lblValorProduto.TabIndex = 0;
            lblValorProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContato
            // 
            lblContato.BackColor = Color.FromArgb(174, 180, 227);
            lblContato.Dock = DockStyle.Fill;
            lblContato.FlatStyle = FlatStyle.Flat;
            lblContato.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblContato.ForeColor = Color.FromArgb(44, 131, 221);
            lblContato.Location = new Point(752, 0);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(429, 43);
            lblContato.TabIndex = 0;
            lblContato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(174, 180, 227);
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(44, 131, 221);
            lblTotal.Location = new Point(244, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(344, 43);
            lblTotal.TabIndex = 0;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Dock = DockStyle.Fill;
            lblProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProduto.ForeColor = Color.FromArgb(229, 55, 119);
            lblProduto.Location = new Point(27, 0);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(114, 43);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Produto:";
            lblProduto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(225, 103, 148);
            lblTitulo.Location = new Point(469, 62);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1216, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Área de Cadastro de Pedidos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDadosPedidos
            // 
            dgvDadosPedidos.AllowUserToAddRows = false;
            dgvDadosPedidos.AllowUserToDeleteRows = false;
            dgvDadosPedidos.AllowUserToResizeColumns = false;
            dgvDadosPedidos.AllowUserToResizeRows = false;
            dgvDadosPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDadosPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDadosPedidos.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvDadosPedidos.BorderStyle = BorderStyle.None;
            dgvDadosPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosPedidos.Dock = DockStyle.Fill;
            dgvDadosPedidos.EnableHeadersVisualStyles = false;
            dgvDadosPedidos.GridColor = SystemColors.InactiveCaptionText;
            dgvDadosPedidos.Location = new Point(469, 204);
            dgvDadosPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvDadosPedidos.Name = "dgvDadosPedidos";
            dgvDadosPedidos.ReadOnly = true;
            dgvDadosPedidos.RowHeadersVisible = false;
            dgvDadosPedidos.RowHeadersWidth = 51;
            dgvDadosPedidos.Size = new Size(1216, 520);
            dgvDadosPedidos.TabIndex = 4;
            dgvDadosPedidos.CellFormatting += dgvDadosPedidos_CellFormatting;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Dock = DockStyle.Fill;
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(469, 138);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar...";
            txtPesquisar.Size = new Size(1216, 34);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.Transparent;
            tlpPrincipal.ColumnCount = 4;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.833334F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.4375F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.6458321F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0588236F));
            tlpPrincipal.Controls.Add(dgvDadosPedidos, 2, 5);
            tlpPrincipal.Controls.Add(txtPesquisar, 2, 3);
            tlpPrincipal.Controls.Add(lblTitulo, 2, 1);
            tlpPrincipal.Controls.Add(tlpCadastro, 2, 7);
            tlpPrincipal.Controls.Add(tlpEdicao, 3, 5);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 9;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 5.88058758F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 5.50055F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 1.42014194F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 3.770377F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 2.60025978F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0550041F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 3.0003F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2616253F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 11.51115F));
            tlpPrincipal.Size = new Size(1920, 1055);
            tlpPrincipal.TabIndex = 2;
            // 
            // tlpCadastro
            // 
            tlpCadastro.BackColor = Color.FromArgb(251, 234, 244);
            tlpCadastro.ColumnCount = 1;
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCadastro.Controls.Add(tlpLinha1, 0, 1);
            tlpCadastro.Controls.Add(tlpLinha2, 0, 3);
            tlpCadastro.Controls.Add(tlpLinha3, 0, 5);
            tlpCadastro.Dock = DockStyle.Fill;
            tlpCadastro.Location = new Point(469, 762);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.RowCount = 7;
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tlpCadastro.Size = new Size(1216, 165);
            tlpCadastro.TabIndex = 2;
            // 
            // tlpLinha1
            // 
            tlpLinha1.ColumnCount = 7;
            tlpLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.998039F));
            tlpLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0016F));
            tlpLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.996077F));
            tlpLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.00535F));
            tlpLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.996077F));
            tlpLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.00481F));
            tlpLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.998039F));
            tlpLinha1.Controls.Add(lblNome, 1, 0);
            tlpLinha1.Controls.Add(cmbClientes, 3, 0);
            tlpLinha1.Controls.Add(lblContato, 5, 0);
            tlpLinha1.Dock = DockStyle.Fill;
            tlpLinha1.Location = new Point(3, 7);
            tlpLinha1.Name = "tlpLinha1";
            tlpLinha1.RowCount = 1;
            tlpLinha1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLinha1.Size = new Size(1210, 43);
            tlpLinha1.TabIndex = 1;
            // 
            // tlpLinha2
            // 
            tlpLinha2.ColumnCount = 13;
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.0031426F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.999541F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99990833F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9988537F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99990833F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.9997654F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99990833F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.9999352F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99990833F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.99945F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99990833F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.999878F));
            tlpLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.99990833F));
            tlpLinha2.Controls.Add(lblProduto, 1, 0);
            tlpLinha2.Controls.Add(lblQuantidade, 9, 0);
            tlpLinha2.Controls.Add(lblValorProduto, 7, 0);
            tlpLinha2.Controls.Add(txtQuantidade, 11, 0);
            tlpLinha2.Controls.Add(cmbProdutos, 3, 0);
            tlpLinha2.Controls.Add(lblValorP, 5, 0);
            tlpLinha2.Dock = DockStyle.Fill;
            tlpLinha2.Location = new Point(3, 60);
            tlpLinha2.Name = "tlpLinha2";
            tlpLinha2.RowCount = 1;
            tlpLinha2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLinha2.Size = new Size(1210, 43);
            tlpLinha2.TabIndex = 2;
            // 
            // tlpLinha3
            // 
            tlpLinha3.ColumnCount = 9;
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29F));
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tlpLinha3.Controls.Add(btnCadastrar, 7, 0);
            tlpLinha3.Controls.Add(cmbStatus, 5, 0);
            tlpLinha3.Controls.Add(lblTotal, 3, 0);
            tlpLinha3.Controls.Add(lblValorTotal, 1, 0);
            tlpLinha3.Dock = DockStyle.Fill;
            tlpLinha3.Location = new Point(3, 113);
            tlpLinha3.Name = "tlpLinha3";
            tlpLinha3.RowCount = 1;
            tlpLinha3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLinha3.Size = new Size(1210, 43);
            tlpLinha3.TabIndex = 3;
            // 
            // tlpEdicao
            // 
            tlpEdicao.ColumnCount = 3;
            tlpEdicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpEdicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpEdicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpEdicao.Controls.Add(btnEdicao, 1, 0);
            tlpEdicao.Controls.Add(btnAtualizar, 1, 2);
            tlpEdicao.Controls.Add(btnDeletar, 1, 4);
            tlpEdicao.Dock = DockStyle.Fill;
            tlpEdicao.Location = new Point(1691, 203);
            tlpEdicao.Name = "tlpEdicao";
            tlpEdicao.RowCount = 6;
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1341F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 1.532567F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7509575F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 1.532567F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7509575F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 52.29885F));
            tlpEdicao.Size = new Size(226, 522);
            tlpEdicao.TabIndex = 3;
            tlpEdicao.TabStop = true;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.BackgroundImageLayout = ImageLayout.Zoom;
            btnEdicao.Cursor = Cursors.Hand;
            btnEdicao.Dock = DockStyle.Fill;
            btnEdicao.FlatAppearance.BorderSize = 0;
            btnEdicao.FlatStyle = FlatStyle.Flat;
            btnEdicao.ForeColor = SystemColors.ControlText;
            btnEdicao.Location = new Point(78, 4);
            btnEdicao.Margin = new Padding(3, 4, 3, 4);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(69, 71);
            btnEdicao.TabIndex = 1;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.AutoSize = true;
            btnAtualizar.BackColor = Color.Transparent;
            btnAtualizar.BackgroundImage = (Image)resources.GetObject("btnAtualizar.BackgroundImage");
            btnAtualizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAtualizar.Dock = DockStyle.Fill;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(78, 90);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(69, 71);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.AutoSize = true;
            btnDeletar.BackColor = Color.Transparent;
            btnDeletar.BackgroundImage = (Image)resources.GetObject("btnDeletar.BackgroundImage");
            btnDeletar.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeletar.Dock = DockStyle.Fill;
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(78, 175);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(69, 71);
            btnDeletar.TabIndex = 3;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 246, 254);
            ClientSize = new Size(1920, 1055);
            Controls.Add(pnlNavegacao);
            Controls.Add(tlpPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidos_Load_1;
            pnlNavegacao.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tlpHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDadosPedidos).EndInit();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            tlpCadastro.ResumeLayout(false);
            tlpLinha1.ResumeLayout(false);
            tlpLinha2.ResumeLayout(false);
            tlpLinha2.PerformLayout();
            tlpLinha3.ResumeLayout(false);
            tlpEdicao.ResumeLayout(false);
            tlpEdicao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlNavegacao;
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
        private Label lblTitulo;
        private DataGridView dgvDadosPedidos;
        private TextBox txtPesquisar;
        private Label lblProduto;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpNavegacao;
        private Button btnPedidos;
        private Button btnClientes;
        private Button btnProdutos;
        private TableLayoutPanel tlpHome;
        private Button btnHome;
        private TableLayoutPanel tlpCadastro;
        private TableLayoutPanel tlpLinha1;
        private TableLayoutPanel tlpLinha2;
        private TableLayoutPanel tlpLinha3;
        private TableLayoutPanel tlpEdicao;
        private Button btnEdicao;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}