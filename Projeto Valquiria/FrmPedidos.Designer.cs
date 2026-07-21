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
            pnlNavegacao = new Panel();
            tlpNavegacao = new TableLayoutPanel();
            btnPedidos = new Button();
            btnClientes = new Button();
            btnProdutos = new Button();
            tlpHome = new TableLayoutPanel();
            btnHome = new Button();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pnlNavegacao.SuspendLayout();
            tlpNavegacao.SuspendLayout();
            tlpHome.SuspendLayout();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
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
            pnlNavegacao.TabIndex = 15;
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
            tlpNavegacao.TabIndex = 25;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(251, 141, 188);
            btnPedidos.BackgroundImageLayout = ImageLayout.Zoom;
            btnPedidos.Cursor = Cursors.No;
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
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(251, 141, 188);
            btnClientes.BackgroundImageLayout = ImageLayout.Zoom;
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
            btnClientes.Click += btnClientes_Click;
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
            // btnEdicao
            // 
            btnEdicao.BackgroundImageLayout = ImageLayout.Center;
            btnEdicao.Cursor = Cursors.Hand;
            btnEdicao.FlatStyle = FlatStyle.Popup;
            btnEdicao.ForeColor = Color.Transparent;
            btnEdicao.Image = (Image)resources.GetObject("btnEdicao.Image");
            btnEdicao.Location = new Point(44, 4);
            btnEdicao.Margin = new Padding(3, 4, 3, 4);
            btnEdicao.Name = "btnEdicao";
            btnEdicao.Size = new Size(95, 91);
            btnEdicao.TabIndex = 16;
            btnEdicao.UseVisualStyleBackColor = true;
            btnEdicao.Click += btnEdicao_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.AutoSize = true;
            btnDeletar.Font = new Font("Segoe UI", 12F);
            btnDeletar.Location = new Point(44, 157);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(95, 37);
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
            pnlCadastro.Dock = DockStyle.Fill;
            pnlCadastro.Location = new Point(649, 766);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(1056, 160);
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
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(290, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(474, 53);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Área de Cadastro de Pedidos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Location = new Point(649, 208);
            dgvPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(1056, 519);
            dgvPedidos.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Dock = DockStyle.Fill;
            txtPesquisar.Font = new Font("Segoe UI", 12F);
            txtPesquisar.Location = new Point(649, 141);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(1056, 34);
            txtPesquisar.TabIndex = 17;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6651573F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9992695F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.3363075F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9992657F));
            tableLayoutPanel1.Controls.Add(dgvPedidos, 2, 5);
            tableLayoutPanel1.Controls.Add(txtPesquisar, 2, 3);
            tableLayoutPanel1.Controls.Add(pnlCadastro, 2, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 3, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.1F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tableLayoutPanel1.Size = new Size(1920, 1055);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.22823F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.54354F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.22823F));
            tableLayoutPanel2.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(649, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1056, 53);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.67133F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.3286743F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel3.Controls.Add(btnDeletar, 1, 2);
            tableLayoutPanel3.Controls.Add(btnEdicao, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1711, 207);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70.83334F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.166666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 323F));
            tableLayoutPanel3.Size = new Size(206, 521);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1920, 1055);
            Controls.Add(pnlNavegacao);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidos_Load_1;
            pnlNavegacao.ResumeLayout(false);
            tlpNavegacao.ResumeLayout(false);
            tlpHome.ResumeLayout(false);
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlNavegacao;
        private Button btnEdicao;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tlpNavegacao;
        private Button btnPedidos;
        private Button btnClientes;
        private Button btnProdutos;
        private TableLayoutPanel tlpHome;
        private Button btnHome;
    }
}