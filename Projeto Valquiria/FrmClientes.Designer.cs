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
            panelMenu = new PictureBox();
            btnHome = new Button();
            btnCliente = new Button();
            btnPedidos = new Button();
            btnProdutos = new Button();
            txtPesquisar = new TextBox();
            btnEdicao = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelMenu).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.White;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(754, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(450, 66);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Área de cadastro de clientes";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(87, 15);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(755, 27);
            txtNome.TabIndex = 1;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(87, 83);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(611, 27);
            txtContato.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(721, 92);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(130, 31);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar Cliente";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.White;
            lblNome.Location = new Point(499, 796);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.White;
            lblContato.Location = new Point(487, 870);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(65, 20);
            lblContato.TabIndex = 5;
            lblContato.Text = "Contato:";
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(btnCadastrar);
            pnlCadastro.Controls.Add(txtNome);
            pnlCadastro.Controls.Add(txtContato);
            pnlCadastro.Location = new Point(468, 778);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(882, 147);
            pnlCadastro.TabIndex = 6;
            // 
            // dvgTabela
            // 
            dvgTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTabela.Location = new Point(402, 229);
            dvgTabela.Margin = new Padding(3, 4, 3, 4);
            dvgTabela.Name = "dvgTabela";
            dvgTabela.RowHeadersWidth = 51;
            dvgTabela.Size = new Size(1048, 541);
            dvgTabela.TabIndex = 7;
            dvgTabela.CellContentClick += dvgTabela_CellContentClick;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(159, 214, 242);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 925);
            panelMenu.TabIndex = 8;
            panelMenu.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(159, 214, 242);
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(14, 33);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 75);
            btnHome.TabIndex = 3;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnVoltar_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.Cursor = Cursors.No;
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(70, 475);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(181, 63);
            btnCliente.TabIndex = 10;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(164, 92, 218);
            btnPedidos.FlatStyle = FlatStyle.Popup;
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Location = new Point(70, 333);
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
            btnProdutos.BackColor = Color.FromArgb(56, 206, 22);
            btnProdutos.FlatStyle = FlatStyle.Popup;
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(70, 404);
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
            txtPesquisar.Location = new Point(505, 153);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(829, 27);
            txtPesquisar.TabIndex = 18;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdicao.FlatStyle = FlatStyle.Flat;
            btnEdicao.Location = new Point(1512, 229);
            btnEdicao.Margin = new Padding(3, 4, 3, 4);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(75, 69);
            btnEdicao.TabIndex = 19;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(1503, 349);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(86, 31);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(1501, 388);
            btnDeletar.Margin = new Padding(3, 4, 3, 4);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(86, 31);
            btnDeletar.TabIndex = 20;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 226, 100);
            ClientSize = new Size(1637, 925);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEdicao);
            Controls.Add(txtPesquisar);
            Controls.Add(btnProdutos);
            Controls.Add(btnCliente);
            Controls.Add(btnPedidos);
            Controls.Add(btnHome);
            Controls.Add(dvgTabela);
            Controls.Add(lblContato);
            Controls.Add(lblNome);
            Controls.Add(lblTitulo);
            Controls.Add(pnlCadastro);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += FrmClientes_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTabela).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelMenu).EndInit();
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
        private PictureBox panelMenu;
        private Button btnHome;
        private Button btnCliente;
        private Button btnPedidos;
        private Button btnProdutos;
        private TextBox txtPesquisar;
        private Button btnEdicao;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}