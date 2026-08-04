namespace Projeto_Valquiria
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            dgvDadosClientes = new DataGridView();
            txtPesquisar = new TextBox();
            tlpPrincipal = new TableLayoutPanel();
            lblTitulo = new Label();
            tlpCadastro = new TableLayoutPanel();
            lblNome = new Label();
            tlpBtnTxtValor = new TableLayoutPanel();
            btnCadastrar = new Button();
            txtContato = new TextBox();
            lblContato = new Label();
            tlpTxtProduto = new TableLayoutPanel();
            txtNome = new TextBox();
            tlpEdicao = new TableLayoutPanel();
            btnEdicao = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            pnlNavegacao = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            btnPedidos = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            tlpHome = new TableLayoutPanel();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDadosClientes).BeginInit();
            tlpPrincipal.SuspendLayout();
            tlpCadastro.SuspendLayout();
            tlpBtnTxtValor.SuspendLayout();
            tlpTxtProduto.SuspendLayout();
            tlpEdicao.SuspendLayout();
            pnlNavegacao.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpHome.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDadosClientes
            // 
            dgvDadosClientes.AllowUserToAddRows = false;
            dgvDadosClientes.AllowUserToDeleteRows = false;
            dgvDadosClientes.AllowUserToResizeColumns = false;
            dgvDadosClientes.AllowUserToResizeRows = false;
            dgvDadosClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDadosClientes.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvDadosClientes.BorderStyle = BorderStyle.None;
            dgvDadosClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosClientes.Dock = DockStyle.Fill;
            dgvDadosClientes.EnableHeadersVisualStyles = false;
            dgvDadosClientes.GridColor = SystemColors.InactiveCaptionText;
            dgvDadosClientes.Location = new Point(638, 204);
            dgvDadosClientes.Margin = new Padding(3, 4, 3, 4);
            dgvDadosClientes.Name = "dgvDadosClientes";
            dgvDadosClientes.ReadOnly = true;
            dgvDadosClientes.RowHeadersVisible = false;
            dgvDadosClientes.RowHeadersWidth = 51;
            dgvDadosClientes.Size = new Size(1042, 520);
            dgvDadosClientes.TabIndex = 4;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Dock = DockStyle.Fill;
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(638, 138);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar...";
            txtPesquisar.Size = new Size(1042, 34);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.Transparent;
            tlpPrincipal.ColumnCount = 4;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3F));
            tlpPrincipal.Controls.Add(dgvDadosClientes, 2, 5);
            tlpPrincipal.Controls.Add(txtPesquisar, 2, 3);
            tlpPrincipal.Controls.Add(lblTitulo, 2, 1);
            tlpPrincipal.Controls.Add(tlpCadastro, 2, 7);
            tlpPrincipal.Controls.Add(tlpEdicao, 3, 5);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 9;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 5.880588F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 5.50055F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 1.420142F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 3.770377F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 2.60025978F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0550041F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 3.0003F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2616253F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 11.51115F));
            tlpPrincipal.Size = new Size(1920, 1055);
            tlpPrincipal.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(225, 103, 148);
            lblTitulo.Location = new Point(638, 62);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1042, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Área de Cadastro de Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpCadastro
            // 
            tlpCadastro.BackColor = Color.FromArgb(251, 234, 244);
            tlpCadastro.ColumnCount = 5;
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.458214F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1727448F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.91938579F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.6142044F));
            tlpCadastro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.7463975F));
            tlpCadastro.Controls.Add(lblNome, 1, 1);
            tlpCadastro.Controls.Add(tlpBtnTxtValor, 3, 3);
            tlpCadastro.Controls.Add(lblContato, 1, 3);
            tlpCadastro.Controls.Add(tlpTxtProduto, 3, 1);
            tlpCadastro.Dock = DockStyle.Fill;
            tlpCadastro.Location = new Point(638, 762);
            tlpCadastro.Name = "tlpCadastro";
            tlpCadastro.RowCount = 5;
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpCadastro.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCadastro.Size = new Size(1042, 165);
            tlpCadastro.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Dock = DockStyle.Fill;
            lblNome.FlatStyle = FlatStyle.Flat;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(229, 55, 119);
            lblNome.Location = new Point(39, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 49);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpBtnTxtValor
            // 
            tlpBtnTxtValor.ColumnCount = 3;
            tlpBtnTxtValor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpBtnTxtValor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpBtnTxtValor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBtnTxtValor.Controls.Add(btnCadastrar, 2, 0);
            tlpBtnTxtValor.Controls.Add(txtContato, 0, 0);
            tlpBtnTxtValor.Dock = DockStyle.Fill;
            tlpBtnTxtValor.Location = new Point(165, 101);
            tlpBtnTxtValor.Name = "tlpBtnTxtValor";
            tlpBtnTxtValor.RowCount = 1;
            tlpBtnTxtValor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBtnTxtValor.Size = new Size(834, 43);
            tlpBtnTxtValor.TabIndex = 2;
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
            btnCadastrar.Location = new Point(672, 4);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(159, 35);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtContato
            // 
            txtContato.BorderStyle = BorderStyle.None;
            txtContato.Cursor = Cursors.IBeam;
            txtContato.Dock = DockStyle.Fill;
            txtContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContato.Location = new Point(3, 4);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.MaxLength = 80;
            txtContato.Name = "txtContato";
            txtContato.PlaceholderText = "Ex: (11) 91234-5678 ou contato@padariacentral.com";
            txtContato.Size = new Size(653, 27);
            txtContato.TabIndex = 1;
            // 
            // lblContato
            // 
            lblContato.BackColor = Color.Transparent;
            lblContato.Dock = DockStyle.Fill;
            lblContato.FlatStyle = FlatStyle.Flat;
            lblContato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.ForeColor = Color.FromArgb(229, 55, 119);
            lblContato.Location = new Point(39, 98);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(100, 49);
            lblContato.TabIndex = 0;
            lblContato.Text = "Contato:";
            lblContato.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpTxtProduto
            // 
            tlpTxtProduto.ColumnCount = 1;
            tlpTxtProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTxtProduto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTxtProduto.Controls.Add(txtNome, 0, 0);
            tlpTxtProduto.Dock = DockStyle.Fill;
            tlpTxtProduto.Location = new Point(165, 19);
            tlpTxtProduto.Name = "tlpTxtProduto";
            tlpTxtProduto.RowCount = 1;
            tlpTxtProduto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTxtProduto.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTxtProduto.Size = new Size(834, 43);
            tlpTxtProduto.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Dock = DockStyle.Fill;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(3, 4);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.MaxLength = 120;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex: João Pereira";
            txtNome.Size = new Size(828, 27);
            txtNome.TabIndex = 1;
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
            tlpEdicao.Location = new Point(1686, 203);
            tlpEdicao.Name = "tlpEdicao";
            tlpEdicao.RowCount = 6;
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1341F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 1.532567F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7509575F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 1.532567F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7509575F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 52.29885F));
            tlpEdicao.Size = new Size(231, 522);
            tlpEdicao.TabIndex = 3;
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
            btnEdicao.Location = new Point(79, 4);
            btnEdicao.Margin = new Padding(3, 4, 3, 4);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(71, 71);
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
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.Dock = DockStyle.Fill;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(79, 90);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(71, 71);
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
            btnDeletar.Cursor = Cursors.Hand;
            btnDeletar.Dock = DockStyle.Fill;
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(79, 175);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(71, 71);
            btnDeletar.TabIndex = 3;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
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
            btnPedidos.Cursor = Cursors.Hand;
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
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(251, 141, 188);
            btnClientes.BackgroundImageLayout = ImageLayout.Zoom;
            btnClientes.Cursor = Cursors.No;
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
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
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
            btnProdutos.Location = new Point(113, 400);
            btnProdutos.Margin = new Padding(3, 4, 3, 4);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(174, 58);
            btnProdutos.TabIndex = 3;
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
            tlpHome.TabIndex = 5;
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = AccessibleRole.None;
            btnHome.BackColor = Color.FromArgb(255, 254, 254);
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.Cursor = Cursors.Hand;
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
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 246, 254);
            ClientSize = new Size(1920, 1055);
            Controls.Add(pnlNavegacao);
            Controls.Add(tlpPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormClosed += frmClientes_FormClosed;
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDadosClientes).EndInit();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            tlpCadastro.ResumeLayout(false);
            tlpCadastro.PerformLayout();
            tlpBtnTxtValor.ResumeLayout(false);
            tlpBtnTxtValor.PerformLayout();
            tlpTxtProduto.ResumeLayout(false);
            tlpTxtProduto.PerformLayout();
            tlpEdicao.ResumeLayout(false);
            tlpEdicao.PerformLayout();
            pnlNavegacao.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tlpHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDadosClientes;
        private TextBox txtPesquisar;
        private TableLayoutPanel tlpPrincipal;
        private Panel pnlNavegacao;
        private TableLayoutPanel tlpNavegacao;
        private Button btnPedidos;
        private Button btnClientes;
        private Button btnProdutos;
        private TableLayoutPanel tlpHome;
        private Button btnHome;
        private Label lblTitulo;
        private TableLayoutPanel tlpCadastro;
        private Label lblNome;
        private TableLayoutPanel tlpBtnTxtValor;
        private Button btnCadastrar;
        private TextBox txtContato;
        private Label lblContato;
        private TableLayoutPanel tlpTxtProduto;
        private TextBox txtNome;
        private TableLayoutPanel tlpEdicao;
        private Button btnEdicao;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}