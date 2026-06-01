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
            pnlNavegacao = new Panel();
            btnCliente = new Button();
            btnProduto = new Button();
            btnPedido = new Button();
            lblTitulo = new Label();
            txtPesquisar = new TextBox();
            btnEdicao = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).BeginInit();
            pnlCadastro.SuspendLayout();
            pnlNavegacao.SuspendLayout();
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
            btnHome.Location = new Point(14, 33);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(61, 75);
            btnHome.TabIndex = 3;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // dgvDadosProdutos
            // 
            dgvDadosProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDadosProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosProdutos.Location = new Point(402, 229);
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
            lblNome.Size = new Size(142, 33);
            lblNome.TabIndex = 1;

            // 
            // lblPreco
            // 
            lblPreco.BackColor = Color.White;
            lblPreco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(32, 59);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(127, 29);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Valor do Produto";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(190, 13);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex: Bolo";
            txtNome.Size = new Size(383, 29);
            txtNome.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 10F);
            txtValor.Location = new Point(190, 55);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ex: 9,99";
            txtValor.Size = new Size(383, 30);
            txtValor.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(611, 13);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 56);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar Produto";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastroProduto_Click;
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(btnCadastrar);
            pnlCadastro.Controls.Add(lblNome);
            pnlCadastro.Controls.Add(txtValor);
            pnlCadastro.Controls.Add(lblPreco);
            pnlCadastro.Controls.Add(txtNome);
            pnlCadastro.Location = new Point(402, 805);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(795, 104);
            pnlCadastro.TabIndex = 4;
            // 
            // pnlNavegacao
            // 
            pnlNavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlNavegacao.BackColor = Color.FromArgb(159, 214, 242);
            pnlNavegacao.Controls.Add(btnCliente);
            pnlNavegacao.Controls.Add(btnProduto);
            pnlNavegacao.Controls.Add(btnPedido);
            pnlNavegacao.Controls.Add(btnHome);
            pnlNavegacao.Location = new Point(0, 0);
            pnlNavegacao.Margin = new Padding(3, 4, 3, 4);
            pnlNavegacao.Name = "pnlNavegacao";
            pnlNavegacao.Size = new Size(312, 925);
            pnlNavegacao.TabIndex = 6;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(70, 475);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(181, 63);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(56, 206, 22);
            btnProduto.Cursor = Cursors.No;
            btnProduto.Enabled = false;
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(70, 404);
            btnProduto.Margin = new Padding(3, 4, 3, 4);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(181, 63);
            btnProduto.TabIndex = 5;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(70, 333);
            btnPedido.Margin = new Padding(3, 4, 3, 4);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(181, 63);
            btnPedido.TabIndex = 4;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.White;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(754, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(425, 59);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Área de Cadastro de Produtos";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(505, 153);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(829, 27);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImage = (Image)resources.GetObject("btnEdicao.BackgroundImage");
            btnEdicao.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdicao.FlatStyle = FlatStyle.Flat;
            btnEdicao.Location = new Point(1480, 229);
            btnEdicao.Margin = new Padding(3, 4, 3, 4);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(65, 81);
            btnEdicao.TabIndex = 8;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(1480, 367);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(1480, 404);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 10;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 226, 176);
            ClientSize = new Size(1637, 925);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEdicao);
            Controls.Add(txtPesquisar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvDadosProdutos);
            Controls.Add(pnlCadastro);
            Controls.Add(pnlNavegacao);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            WindowState = FormWindowState.Maximized;
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).EndInit();
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            pnlNavegacao.ResumeLayout(false);
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
        private Panel pnlNavegacao;
        private Button btnCliente;
        private Button btnProduto;
        private Button btnPedido;
        private Label lblTitulo;
        private TextBox txtPesquisar;
        private Button btnEdicao;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}