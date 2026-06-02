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
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.White;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(936, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(450, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Área de cadastro de clientes";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(96, 16);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(935, 34);
            txtNome.TabIndex = 1;
            // 
            // txtContato
            // 
            txtContato.Font = new Font("Segoe UI", 12F);
            txtContato.Location = new Point(109, 84);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(773, 34);
            txtContato.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(901, 84);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(130, 34);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar Cliente";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.White;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(12, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.White;
            lblContato.Font = new Font("Segoe UI", 12F);
            lblContato.Location = new Point(16, 84);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(87, 28);
            lblContato.TabIndex = 5;
            lblContato.Text = "Contato:";
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(btnCadastrar);
            pnlCadastro.Controls.Add(txtNome);
            pnlCadastro.Controls.Add(txtContato);
            pnlCadastro.Controls.Add(lblNome);
            pnlCadastro.Controls.Add(lblContato);
            pnlCadastro.Location = new Point(638, 760);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(1048, 147);
            pnlCadastro.TabIndex = 6;
            // 
            // dvgTabela
            // 
            dvgTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTabela.Location = new Point(638, 211);
            dvgTabela.Margin = new Padding(3, 4, 3, 4);
            dvgTabela.Name = "dvgTabela";
            dvgTabela.RowHeadersWidth = 51;
            dvgTabela.Size = new Size(1048, 541);
            dvgTabela.TabIndex = 7;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(157, 690);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(77, 77);
            btnHome.TabIndex = 3;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnVoltar_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.Cursor = Cursors.No;
            btnCliente.Enabled = false;
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(104, 540);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(181, 63);
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
            btnPedidos.Location = new Point(104, 240);
            btnPedidos.Margin = new Padding(3, 4, 3, 4);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(181, 63);
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
            btnProdutos.Location = new Point(104, 390);
            btnProdutos.Margin = new Padding(3, 4, 3, 4);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(181, 63);
            btnProdutos.TabIndex = 11;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(638, 153);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(1048, 34);
            txtPesquisar.TabIndex = 18;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdicao.FlatStyle = FlatStyle.Flat;
            btnEdicao.Location = new Point(1739, 211);
            btnEdicao.Margin = new Padding(3, 4, 3, 4);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(75, 75);
            btnEdicao.TabIndex = 19;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(1739, 303);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(99, 39);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(1739, 347);
            btnDeletar.Margin = new Padding(3, 4, 3, 4);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(99, 39);
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
            pnlMenu.Controls.Add(btnPedidos);
            pnlMenu.Controls.Add(btnProdutos);
            pnlMenu.Controls.Add(btnCliente);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(397, 1055);
            pnlMenu.TabIndex = 21;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 226, 100);
            ClientSize = new Size(1924, 925);
            Controls.Add(pnlMenu);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEdicao);
            Controls.Add(txtPesquisar);
            Controls.Add(dvgTabela);
            Controls.Add(lblTitulo);
            Controls.Add(pnlCadastro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmClientes_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).EndInit();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}