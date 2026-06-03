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
            lblTitulo = new Label();
            txtNome = new TextBox();
            txtContato = new TextBox();
            btnCadastrar = new Button();
            lblNome = new Label();
            lblContato = new Label();
            pnlCadastro = new Panel();
            dvgTabela = new DataGridView();
            btnHome = new Button();
            btnCliente = new Button();
            btnPedidos = new Button();
            btnProdutos = new Button();
            txtPesquisar = new TextBox();
            btnEdicao = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            pnlMenu = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            tlpHome = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).BeginInit();
            pnlMenu.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpHome.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitulo.BackColor = Color.White;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(281, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(351, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Área de cadastro de clientes";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(84, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(819, 29);
            txtNome.TabIndex = 1;
            // 
            // txtContato
            // 
            txtContato.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContato.Font = new Font("Segoe UI", 12F);
            txtContato.Location = new Point(95, 63);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(677, 29);
            txtContato.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Right;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(802, 63);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(101, 29);
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
            lblNome.Location = new Point(6, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblContato
            // 
            lblContato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.White;
            lblContato.Font = new Font("Segoe UI", 15F);
            lblContato.Location = new Point(6, 64);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(87, 28);
            lblContato.TabIndex = 5;
            lblContato.Text = "Contato:";
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
            pnlCadastro.Location = new Point(563, 563);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(914, 102);
            pnlCadastro.TabIndex = 6;
            // 
            // dvgTabela
            // 
            dvgTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTabela.Dock = DockStyle.Fill;
            dvgTabela.Location = new Point(563, 153);
            dvgTabela.Name = "dvgTabela";
            dvgTabela.RowHeadersWidth = 51;
            dvgTabela.Size = new Size(914, 381);
            dvgTabela.TabIndex = 7;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(41, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(66, 50);
            btnHome.TabIndex = 3;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnVoltar_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.Cursor = Cursors.No;
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(99, 405);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(151, 42);
            btnCliente.TabIndex = 10;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.MediumPurple;
            btnPedidos.FlatStyle = FlatStyle.Popup;
            btnPedidos.Font = new Font("Segoe UI", 12F);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Location = new Point(99, 181);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(151, 42);
            btnPedidos.TabIndex = 9;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.MediumSeaGreen;
            btnProdutos.FlatStyle = FlatStyle.Popup;
            btnProdutos.Font = new Font("Segoe UI", 12F);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(99, 293);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(151, 42);
            btnProdutos.TabIndex = 11;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Dock = DockStyle.Fill;
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(563, 104);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(914, 29);
            txtPesquisar.TabIndex = 18;
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
            btnEdicao.Size = new Size(83, 68);
            btnEdicao.TabIndex = 19;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAtualizar.AutoSize = true;
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(38, 110);
            btnAtualizar.Margin = new Padding(3, 2, 3, 2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(83, 30);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(38, 155);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(83, 30);
            btnDeletar.TabIndex = 20;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
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
            pnlMenu.TabIndex = 21;
            // 
            // tlpNavegacao
            // 
            tlpNavegacao.BackColor = Color.Transparent;
            tlpNavegacao.ColumnCount = 3;
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            tlpNavegacao.Controls.Add(btnPedidos, 1, 1);
            tlpNavegacao.Controls.Add(tlpHome, 1, 7);
            tlpNavegacao.Controls.Add(btnProdutos, 1, 3);
            tlpNavegacao.Controls.Add(btnCliente, 1, 5);
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
            tlpNavegacao.TabIndex = 14;
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6651573F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9992695F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.3363075F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9992657F));
            tableLayoutPanel1.Controls.Add(dvgTabela, 2, 5);
            tableLayoutPanel1.Controls.Add(pnlCadastro, 2, 7);
            tableLayoutPanel1.Controls.Add(txtPesquisar, 2, 3);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5F));
            tableLayoutPanel1.Size = new Size(1664, 775);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7F));
            tableLayoutPanel2.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(563, 26);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.Size = new Size(914, 39);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.3835316F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.61646F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.Controls.Add(btnDeletar, 1, 4);
            tableLayoutPanel3.Controls.Add(btnAtualizar, 1, 2);
            tableLayoutPanel3.Controls.Add(btnEdicao, 1, 0);
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
            tableLayoutPanel3.Size = new Size(178, 383);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 226, 100);
            ClientSize = new Size(1664, 775);
            Controls.Add(pnlMenu);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmClientes_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).EndInit();
            pnlMenu.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tlpHome.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNome;
        private TextBox txtContato;
        private Button btnCadastrar;
        private Label lblNome;
        private Label lblContato;
        private Panel pnlCadastro;
        private DataGridView dvgTabela;
        private Button btnHome;
        private Button btnCliente;
        private Button btnPedidos;
        private Button btnProdutos;
        private TextBox txtPesquisar;
        private Button btnEdicao;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Panel pnlMenu;
        private TableLayoutPanel tlpNavegacao;
        private TableLayoutPanel tlpHome;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}