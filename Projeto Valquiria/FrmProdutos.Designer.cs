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
            btnAtualizar = new Button();
            btnDeletar = new Button();
            pnlMenu = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).BeginInit();
            pnlCadastro.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = AccessibleRole.None;
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(157, 690);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(77, 77);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // dgvDadosProdutos
            // 
            dgvDadosProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDadosProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosProdutos.Location = new Point(638, 211);
            dgvDadosProdutos.Margin = new Padding(3, 4, 3, 4);
            dgvDadosProdutos.Name = "dgvDadosProdutos";
            dgvDadosProdutos.RowHeadersWidth = 51;
            dgvDadosProdutos.Size = new Size(1048, 541);
            dgvDadosProdutos.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.BackColor = Color.White;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.Location = new Point(17, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(79, 33);
            lblNome.TabIndex = 1;
            // 
            // lblPreco
            // 
            lblPreco.BackColor = Color.White;
            lblPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(16, 84);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(168, 29);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Valor do Produto";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(102, 16);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex: Bolo";
            txtNome.Size = new Size(929, 34);
            txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 12F);
            txtValor.Location = new Point(176, 84);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ex: 9,99";
            txtValor.Size = new Size(705, 34);
            txtValor.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(901, 84);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(130, 34);
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
            pnlCadastro.Location = new Point(638, 760);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(1048, 147);
            pnlCadastro.TabIndex = 4;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 12F);
            lblProduto.Location = new Point(12, 16);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(84, 28);
            lblProduto.TabIndex = 7;
            lblProduto.Text = "Produto";
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(104, 540);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(181, 63);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.MediumSeaGreen;
            btnProduto.Cursor = Cursors.No;
            btnProduto.Enabled = false;
            btnProduto.Font = new Font("Segoe UI", 12F);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(104, 390);
            btnProduto.Margin = new Padding(3, 4, 3, 4);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(181, 63);
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
            btnPedido.Location = new Point(104, 240);
            btnPedido.Margin = new Padding(3, 4, 3, 4);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(181, 63);
            btnPedido.TabIndex = 1;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.White;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(923, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(477, 50);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Área de Cadastro de Produtos";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(638, 153);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(1048, 34);
            txtPesquisar.TabIndex = 3;
            txtPesquisar.TabStop = false;
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
            btnEdicao.TabIndex = 7;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 12F);
            btnAtualizar.Location = new Point(1739, 303);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(99, 39);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(1739, 347);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(99, 39);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.BackColor = Color.FromArgb(240, 192, 229);
            pnlMenu.BackgroundImage = (Image)resources.GetObject("pnlMenu.BackgroundImage");
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(btnCliente);
            pnlMenu.Controls.Add(btnPedido);
            pnlMenu.Controls.Add(btnProduto);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(397, 1185);
            pnlMenu.TabIndex = 22;
            // 
            // FrmProdutos
            // 
            AcceptButton = btnCadastrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlMenu);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEdicao);
            Controls.Add(txtPesquisar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvDadosProdutos);
            Controls.Add(pnlCadastro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).EndInit();
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnAtualizar;
        private Button btnDeletar;
        private Panel pnlMenu;
        private Label lblProduto;
    }
}