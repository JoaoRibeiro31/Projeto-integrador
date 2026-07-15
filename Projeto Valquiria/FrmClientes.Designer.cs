namespace Projeto_Valquiria
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            txtNome = new TextBox();
            txtContato = new TextBox();
            btnCadastrar = new Button();
            lblNome = new Label();
            lblContato = new Label();
            pnlCadastro = new Panel();
            dgvDadosClientes = new DataGridView();
            txtPesquisar = new TextBox();
            btnEdicao = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            tlpPrincipal = new TableLayoutPanel();
            tlpEdicao = new TableLayoutPanel();
            lblTitulo = new Label();
            pnlNavegacao = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            btnPedidos = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            tlpHome = new TableLayoutPanel();
            btnHome = new Button();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosClientes).BeginInit();
            tlpPrincipal.SuspendLayout();
            tlpEdicao.SuspendLayout();
            pnlNavegacao.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpHome.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(96, 16);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(932, 34);
            txtNome.TabIndex = 1;
            // 
            // txtContato
            // 
            txtContato.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContato.Font = new Font("Segoe UI", 12F);
            txtContato.Location = new Point(109, 111);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(770, 34);
            txtContato.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Right;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(914, 97);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(115, 39);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar Cliente";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.White;
            lblNome.Font = new Font("Segoe UI", 15F);
            lblNome.Location = new Point(7, 17);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(89, 35);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContato
            // 
            lblContato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.White;
            lblContato.Font = new Font("Segoe UI", 15F);
            lblContato.Location = new Point(7, 85);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(108, 35);
            lblContato.TabIndex = 5;
            lblContato.Text = "Contato:";
            lblContato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCadastro
            // 
            pnlCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(btnCadastrar);
            pnlCadastro.Controls.Add(txtNome);
            pnlCadastro.Controls.Add(txtContato);
            pnlCadastro.Controls.Add(lblNome);
            pnlCadastro.Controls.Add(lblContato);
            pnlCadastro.Location = new Point(638, 763);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(1042, 163);
            pnlCadastro.TabIndex = 6;
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
            dgvDadosClientes.TabIndex = 7;
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
            txtPesquisar.TabIndex = 18;
            txtPesquisar.TabStop = false;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.BackgroundImageLayout = ImageLayout.Center;
            btnEdicao.Cursor = Cursors.Hand;
            btnEdicao.FlatStyle = FlatStyle.Popup;
            btnEdicao.Location = new Point(43, 4);
            btnEdicao.Margin = new Padding(3, 4, 3, 4);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(95, 91);
            btnEdicao.TabIndex = 19;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAtualizar.AutoSize = true;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(43, 159);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(122, 39);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(43, 219);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(122, 39);
            btnDeletar.TabIndex = 20;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
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
            tlpPrincipal.Controls.Add(pnlCadastro, 2, 7);
            tlpPrincipal.Controls.Add(txtPesquisar, 2, 3);
            tlpPrincipal.Controls.Add(tlpEdicao, 3, 5);
            tlpPrincipal.Controls.Add(lblTitulo, 2, 1);
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
            tlpPrincipal.TabIndex = 22;
            // 
            // tlpEdicao
            // 
            tlpEdicao.ColumnCount = 3;
            tlpEdicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1134758F));
            tlpEdicao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.88653F));
            tlpEdicao.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tlpEdicao.Controls.Add(btnDeletar, 1, 4);
            tlpEdicao.Controls.Add(btnAtualizar, 1, 2);
            tlpEdicao.Controls.Add(btnEdicao, 1, 0);
            tlpEdicao.Dock = DockStyle.Fill;
            tlpEdicao.Location = new Point(1686, 203);
            tlpEdicao.Name = "tlpEdicao";
            tlpEdicao.RowCount = 6;
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 72.22222F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpEdicao.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            tlpEdicao.Size = new Size(231, 522);
            tlpEdicao.TabIndex = 20;
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
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Área de Cadastro de Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlNavegacao
            // 
            pnlNavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlNavegacao.BackColor = Color.FromArgb(240, 192, 229);
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
            tlpNavegacao.TabIndex = 24;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(251, 141, 188);
            btnPedidos.BackgroundImageLayout = ImageLayout.Zoom;
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
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
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
            btnProdutos.TabIndex = 17;
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
            tlpHome.TabIndex = 19;
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
            btnHome.TabIndex = 0;
            btnHome.Text = "Voltar";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 246, 254);
            ClientSize = new Size(1920, 1055);
            Controls.Add(pnlNavegacao);
            Controls.Add(tlpPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmClientes_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosClientes).EndInit();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            tlpEdicao.ResumeLayout(false);
            tlpEdicao.PerformLayout();
            pnlNavegacao.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tlpHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNome;
        private TextBox txtContato;
        private Button btnCadastrar;
        private Label lblNome;
        private Label lblContato;
        private Panel pnlCadastro;
        private DataGridView dgvDadosClientes;
        private TextBox txtPesquisar;
        private Button btnEdicao;
        private Button btnAtualizar;
        private Button btnDeletar;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpEdicao;
        private Panel pnlNavegacao;
        private TableLayoutPanel tlpNavegacao;
        private Button btnPedidos;
        private Button btnClientes;
        private Button btnProdutos;
        private TableLayoutPanel tlpHome;
        private Button btnHome;
        private Label lblTitulo;
    }
}