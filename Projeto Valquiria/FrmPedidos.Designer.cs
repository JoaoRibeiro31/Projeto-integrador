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
            btnCliente = new Button();
            btnProduto = new Button();
            pnlMenu = new Panel();
            btnHome = new Button();
            btnPedido = new Button();
            btnEdicao = new Button();
            btnDeletar = new Button();
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
            pnlCadastro = new Panel();
            lblProduto = new Label();
            lblTitulo = new Label();
            dgvPedidos = new DataGridView();
            txtPesquisar = new TextBox();
            pnlMenu.SuspendLayout();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
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
            btnCliente.Size = new Size(181, 57);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.MediumSeaGreen;
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.Font = new Font("Segoe UI", 12F);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(104, 389);
            btnProduto.Margin = new Padding(3, 4, 3, 4);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(181, 63);
            btnProduto.TabIndex = 10;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.BackColor = Color.FromArgb(240, 192, 229);
            pnlMenu.BackgroundImage = (Image)resources.GetObject("pnlMenu.BackgroundImage");
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(btnPedido);
            pnlMenu.Controls.Add(btnProduto);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(397, 1055);
            pnlMenu.TabIndex = 15;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(211, 119, 215);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(157, 691);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(77, 77);
            btnHome.TabIndex = 12;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.MediumPurple;
            btnPedido.Cursor = Cursors.No;
            btnPedido.Enabled = false;
            btnPedido.Font = new Font("Segoe UI", 12F);
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(104, 240);
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
            btnEdicao.Location = new Point(1739, 211);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(75, 75);
            btnEdicao.TabIndex = 16;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(1739, 347);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(99, 39);
            btnDeletar.TabIndex = 18;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.Font = new Font("Segoe UI", 12F);
            btnCadastrar.Location = new Point(801, 104);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(213, 36);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar Pedido";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // cmbProdutos
            // 
            cmbProdutos.Font = new Font("Segoe UI", 12F);
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(128, 63);
            cmbProdutos.Margin = new Padding(3, 4, 3, 4);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(267, 36);
            cmbProdutos.TabIndex = 2;
            cmbProdutos.SelectedIndexChanged += cmbProdutos_SelectedIndexChanged_1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 12F);
            txtQuantidade.Location = new Point(833, 63);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(180, 34);
            txtQuantidade.TabIndex = 0;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged_1;
            // 
            // lblValorTotal
            // 
            lblValorTotal.BackColor = Color.White;
            lblValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(43, 104);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(111, 28);
            lblValorTotal.TabIndex = 6;
            lblValorTotal.Text = "Valor total";
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(43, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 28);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome Cliente:";
            // 
            // cmbClientes
            // 
            cmbClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(110, 16);
            cmbClientes.Margin = new Padding(3, 4, 3, 4);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(334, 36);
            cmbClientes.TabIndex = 0;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged_1;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 12F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(421, 104);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(252, 36);
            cmbStatus.TabIndex = 11;
            cmbStatus.Text = "Status";
            // 
            // lblValorP
            // 
            lblValorP.AutoSize = true;
            lblValorP.Font = new Font("Segoe UI", 12F);
            lblValorP.Location = new Point(401, 63);
            lblValorP.Name = "lblValorP";
            lblValorP.Size = new Size(134, 28);
            lblValorP.TabIndex = 12;
            lblValorP.Text = "Valor Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 12F);
            lblQuantidade.Location = new Point(702, 63);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(115, 28);
            lblQuantidade.TabIndex = 12;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblValorProduto
            // 
            lblValorProduto.BackColor = Color.Gainsboro;
            lblValorProduto.Font = new Font("Segoe UI", 12F);
            lblValorProduto.Location = new Point(546, 63);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(106, 28);
            lblValorProduto.TabIndex = 12;
            // 
            // lblContato
            // 
            lblContato.BackColor = Color.Gainsboro;
            lblContato.Font = new Font("Segoe UI", 12F);
            lblContato.Location = new Point(450, 16);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(563, 36);
            lblContato.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Gainsboro;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(165, 104);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(176, 28);
            lblTotal.TabIndex = 13;
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(lblProduto);
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
            pnlCadastro.Location = new Point(638, 760);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(1048, 149);
            pnlCadastro.TabIndex = 13;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 12F);
            lblProduto.Location = new Point(43, 63);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(84, 28);
            lblProduto.TabIndex = 14;
            lblProduto.Text = "Produto";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoEllipsis = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(931, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(455, 50);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Área de Cadastro de Pedidos";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(638, 211);
            dgvPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1048, 541);
            dgvPedidos.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(638, 153);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(1049, 34);
            txtPesquisar.TabIndex = 17;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnDeletar);
            Controls.Add(btnCliente);
            Controls.Add(txtPesquisar);
            Controls.Add(btnEdicao);
            Controls.Add(dgvPedidos);
            Controls.Add(lblTitulo);
            Controls.Add(pnlCadastro);
            Controls.Add(pnlMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidos_Load_1;
            pnlMenu.ResumeLayout(false);
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCliente;
        private Button btnProduto;
        private Panel pnlMenu;
        private Button btnPedido;
        private Button btnEdicao;
        private Button btnHome;
        private Button btnDeletar;
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
        private Panel pnlCadastro;
        private Label lblTitulo;
        private DataGridView dgvPedidos;
        private TextBox txtPesquisar;
        private Label lblProduto;
    }
}