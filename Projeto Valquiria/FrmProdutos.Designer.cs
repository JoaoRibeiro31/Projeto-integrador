namespace Projeto_Valquiria
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            btnHome = new Button();
            dgvDadosProdutos = new DataGridView();
            lblNome = new Label();
            lblPreco = new Label();
            txtNome = new TextBox();
            txtValor = new TextBox();
            btnCadastrar = new Button();
            pnlCadastro = new Panel();
            lblProduto = new Label();
            btnCliente = new Button();
            btnProduto = new Button();
            btnPedido = new Button();
            lblTitulo = new Label();
            txtPesquisar = new TextBox();
            btnEdicao = new Button();
            pnlMenu = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            tlpHome = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).BeginInit();
            pnlCadastro.SuspendLayout();
            pnlMenu.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpHome.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = AccessibleRole.None;
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(41, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(66, 50);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // dgvDadosProdutos
            // 
            dgvDadosProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDadosProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosProdutos.Dock = DockStyle.Fill;
            dgvDadosProdutos.Location = new Point(563, 153);
            dgvDadosProdutos.Name = "dgvDadosProdutos";
            dgvDadosProdutos.RowHeadersWidth = 51;
            dgvDadosProdutos.Size = new Size(914, 381);
            dgvDadosProdutos.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.BackColor = Color.White;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(15, 10);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(69, 25);
            lblNome.TabIndex = 1;
            // 
            // lblPreco
            // 
            lblPreco.BackColor = Color.White;
            lblPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(14, 63);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(147, 22);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Valor do Produto";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(89, 12);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex: Bolo";
            txtNome.Size = new Size(813, 29);
            txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 12F);
            txtValor.Location = new Point(154, 63);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ex: 9,99";
            txtValor.Size = new Size(617, 29);
            txtValor.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(788, 63);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(114, 26);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar Produto";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastroProduto_Click;
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(lblProduto);
            pnlCadastro.Controls.Add(btnCadastrar);
            pnlCadastro.Controls.Add(lblNome);
            pnlCadastro.Controls.Add(txtValor);
            pnlCadastro.Controls.Add(lblPreco);
            pnlCadastro.Controls.Add(txtNome);
            pnlCadastro.Dock = DockStyle.Fill;
            pnlCadastro.Location = new Point(563, 563);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(914, 102);
            pnlCadastro.TabIndex = 4;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 12F);
            lblProduto.Location = new Point(10, 12);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(66, 21);
            lblProduto.TabIndex = 7;
            lblProduto.Text = "Produto";
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(99, 405);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(151, 42);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.MediumSeaGreen;
            btnProduto.Cursor = Cursors.No;
            btnProduto.Font = new Font("Segoe UI", 12F);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(99, 293);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(151, 42);
            btnProduto.TabIndex = 17;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.MediumPurple;
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.Font = new Font("Segoe UI", 12F);
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(99, 181);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(151, 42);
            btnPedido.TabIndex = 1;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.White;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(245, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(423, 39);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Área de Cadastro de Produtos";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(563, 104);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(914, 29);
            txtPesquisar.TabIndex = 3;
            txtPesquisar.TabStop = false;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.BackgroundImageLayout = ImageLayout.Center;
            btnEdicao.Cursor = Cursors.Hand;
            btnEdicao.FlatStyle = FlatStyle.Popup;
            btnEdicao.Location = new Point(38, 3);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(82, 68);
            btnEdicao.TabIndex = 7;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
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
            pnlMenu.TabIndex = 22;
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
            tlpNavegacao.TabIndex = 23;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.66516F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9992666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.33631F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9992666F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 5);
            tableLayoutPanel1.Controls.Add(txtPesquisar, 2, 3);
            tableLayoutPanel1.Controls.Add(dgvDadosProdutos, 2, 5);
            tableLayoutPanel1.Controls.Add(pnlCadastro, 2, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5F));
            tableLayoutPanel1.Size = new Size(1664, 775);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.3835316F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.61646F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tableLayoutPanel3.Controls.Add(btnEdicao, 1, 0);
            tableLayoutPanel3.Controls.Add(btnAtualizar, 1, 2);
            tableLayoutPanel3.Controls.Add(btnDeletar, 1, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1483, 152);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 72.22222F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 195F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(178, 383);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // btnAtualizar
            // 
            btnAtualizar.AutoSize = true;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(38, 110);
            btnAtualizar.Margin = new Padding(3, 2, 3, 2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(82, 30);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.AutoSize = true;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(38, 155);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(82, 30);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5265255F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.9469452F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5265255F));
            tableLayoutPanel2.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(563, 26);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(914, 39);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // FrmProdutos
            // 
            AcceptButton = btnCadastrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1664, 775);
            Controls.Add(pnlMenu);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).EndInit();
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            pnlMenu.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tlpHome.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private DataGridView dgvDadosProdutos;
        private Label lblNome;
        private Label lblPreco;
        private TextBox txtNome;
        private TextBox txtValor;
        private Button btnCadastrar;
        private Panel pnlCadastro;
        private Button btnCliente;
        private Button btnProduto;
        private Button btnPedido;
        private Label lblTitulo;
        private TextBox txtPesquisar;
        private Button btnEdicao;
        private Panel pnlMenu;
        private Label lblProduto;
        private TableLayoutPanel tlpNavegacao;
        private TableLayoutPanel tlpHome;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnDeletar;
        private Button btnAtualizar;
        private TableLayoutPanel tableLayoutPanel2;
    }
}