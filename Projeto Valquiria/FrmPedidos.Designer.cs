namespace Projeto_Valquiria
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            cmbClientes = new ComboBox();
            btnCliente = new Button();
            cmbProdutos = new ComboBox();
            lblValorTotal = new Label();
            btnCadastrar = new Button();
            btnProduto = new Button();
            a = new Label();
            pnlCadastro = new Panel();
            lblTotal = new Label();
            lblContato = new Label();
            lblValorProduto = new Label();
            lblQuantidade = new Label();
            lblValorP = new Label();
            cmbStatus = new ComboBox();
            lblNome = new Label();
            txtQuantidade = new TextBox();
            dgvPedidos = new DataGridView();
            pnlNavegacao = new Panel();
            btnHome = new Button();
            btnPedido = new Button();
            btnEdicao = new Button();
            txtPesquisar = new TextBox();
            btnDeletar = new Button();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            pnlNavegacao.SuspendLayout();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(169, 16);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(334, 36);
            cmbClientes.TabIndex = 0;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged_1;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(70, 472);
            btnCliente.Margin = new Padding(3, 4, 3, 4);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(181, 57);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(18, 63);
            cmbProdutos.Margin = new Padding(3, 4, 3, 4);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(201, 28);
            cmbProdutos.TabIndex = 2;
            cmbProdutos.Text = "Produtos";
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged_1;
            // 
            // lblValorTotal
            // 
            lblValorTotal.BackColor = Color.White;
            lblValorTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(18, 105);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(214, 36);
            lblValorTotal.TabIndex = 6;
            lblValorTotal.Text = "Valor total";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.Location = new Point(517, 103);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(223, 36);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar Pedido";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(56, 206, 22);
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(70, 401);
            btnProduto.Margin = new Padding(3, 4, 3, 4);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(181, 63);
            btnProduto.TabIndex = 10;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // a
            // 
            a.AutoEllipsis = true;
            a.BackColor = Color.White;
            a.BorderStyle = BorderStyle.FixedSingle;
            a.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a.Location = new Point(754, 33);
            a.Name = "a";
            a.Size = new Size(455, 61);
            a.TabIndex = 11;
            a.Text = "Área de Cadastro de Pedidos";
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(lblTotal);
            pnlCadastro.Controls.Add(lblContato);
            pnlCadastro.Controls.Add(lblValorProduto);
            pnlCadastro.Controls.Add(lblQuantidade);
            pnlCadastro.Controls.Add(lblValorP);
            pnlCadastro.Controls.Add(cmbStatus);
            pnlCadastro.Controls.Add(cmbClientes);
            pnlCadastro.Controls.Add(lblNome);
            pnlCadastro.Controls.Add(lblValorTotal);
            pnlCadastro.Controls.Add(txtQuantidade);
            pnlCadastro.Controls.Add(cmbProdutos);
            pnlCadastro.Controls.Add(btnCadastrar);
            pnlCadastro.Location = new Point(402, 760);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(1048, 149);
            pnlCadastro.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.WhiteSmoke;
            lblTotal.Location = new Point(139, 109);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(93, 25);
            lblTotal.TabIndex = 13;
            // 
            // lblContato
            // 
            lblContato.BackColor = Color.Gainsboro;
            lblContato.Location = new Point(528, 16);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(505, 39);
            lblContato.TabIndex = 12;
            // 
            // lblValorProduto
            // 
            lblValorProduto.BackColor = Color.Gainsboro;
            lblValorProduto.Location = new Point(358, 67);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(90, 20);
            lblValorProduto.TabIndex = 12;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(488, 67);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(87, 20);
            lblQuantidade.TabIndex = 12;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblValorP
            // 
            lblValorP.AutoSize = true;
            lblValorP.Location = new Point(261, 67);
            lblValorP.Name = "lblValorP";
            lblValorP.Size = new Size(100, 20);
            lblValorP.TabIndex = 12;
            lblValorP.Text = "Valor Produto";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(279, 105);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(169, 28);
            cmbStatus.TabIndex = 11;
            cmbStatus.Text = "Status";
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(35, 21);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(113, 28);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome Cliente:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(599, 63);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(161, 27);
            txtQuantidade.TabIndex = 0;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged_1;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(402, 211);
            dgvPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1048, 541);
            dgvPedidos.TabIndex = 14;
            // 
            // pnlNavegacao
            // 
            pnlNavegacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlNavegacao.BackColor = Color.FromArgb(159, 214, 242);
            pnlNavegacao.Controls.Add(btnHome);
            pnlNavegacao.Controls.Add(btnPedido);
            pnlNavegacao.Controls.Add(btnCliente);
            pnlNavegacao.Controls.Add(btnProduto);
            pnlNavegacao.Location = new Point(0, 0);
            pnlNavegacao.Margin = new Padding(3, 4, 3, 4);
            pnlNavegacao.Name = "pnlNavegacao";
            pnlNavegacao.Size = new Size(312, 925);
            pnlNavegacao.TabIndex = 15;
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
            btnHome.TabIndex = 12;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.Cursor = Cursors.No;
            btnPedido.Enabled = false;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(70, 333);
            btnPedido.Margin = new Padding(3, 4, 3, 4);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(181, 63);
            btnPedido.TabIndex = 11;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            // 
            // btnEdicao
            // 
            btnEdicao.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdicao.Cursor = Cursors.Hand;
            btnEdicao.FlatStyle = FlatStyle.Popup;
            btnEdicao.ForeColor = Color.Transparent;
            btnEdicao.Image = (Image)resources.GetObject("btnEdicao.Image");
            btnEdicao.Location = new Point(1503, 211);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(75, 69);
            btnEdicao.TabIndex = 16;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(402, 153);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(1048, 27);
            txtPesquisar.TabIndex = 17;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(1503, 333);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 29);
            btnDeletar.TabIndex = 18;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 190, 249);
            ClientSize = new Size(1637, 925);
            Controls.Add(btnDeletar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnEdicao);
            Controls.Add(dgvPedidos);
            Controls.Add(a);
            Controls.Add(pnlCadastro);
            Controls.Add(pnlNavegacao);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidos_Load_1;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            pnlNavegacao.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private Button btnCliente;
        private ComboBox cmbProdutos;
        private Label lblValorTotal;
        private Button btnCadastrar;
        private Button btnProduto;
        private Label a;
        private Panel pnlCadastro;
        private TextBox txtQuantidade;
        private Label lblNome;
        private ComboBox cmbStatus;
        private Label lblValorP;
        private Label lblContato;
        private Label lblValorProduto;
        private Label lblQuantidade;
        private DataGridView dgvPedidos;
        private Panel pnlNavegacao;
        private Button btnPedido;
        private Label lblTotal;
        private Button btnEdicao;
        private Button btnHome;
        private TextBox txtPesquisar;
        private Button btnDeletar;
    }
}