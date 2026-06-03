namespace Projeto_Valquiria
{
    partial class panelConteudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelConteudo));
            txtPesquisar = new TextBox();
            dgvPedidos = new DataGridView();
            btnPedido = new Button();
            btnProduto = new Button();
            btnFecharApp = new Button();
            btnCliente = new Button();
            lblDesligar = new Label();
            pnlMenu = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Arial Narrow", 12F);
            txtPesquisar.Location = new Point(729, 204);
            txtPesquisar.Margin = new Padding(3, 5, 3, 5);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(1197, 30);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToOrderColumns = true;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(729, 281);
            dgvPedidos.Margin = new Padding(3, 5, 3, 5);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(1198, 721);
            dgvPedidos.TabIndex = 5;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.MediumPurple;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Segoe UI", 12F);
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(104, 240);
            btnPedido.Margin = new Padding(3, 5, 3, 5);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(181, 63);
            btnPedido.TabIndex = 0;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedidos_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.MediumSeaGreen;
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.Font = new Font("Segoe UI", 12F);
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(104, 389);
            btnProduto.Margin = new Padding(3, 5, 3, 5);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(181, 63);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProdutos_Click;
            // 
            // btnFecharApp
            // 
            btnFecharApp.BackColor = Color.Transparent;
            btnFecharApp.BackgroundImage = (Image)resources.GetObject("btnFecharApp.BackgroundImage");
            btnFecharApp.BackgroundImageLayout = ImageLayout.Stretch;
            btnFecharApp.FlatStyle = FlatStyle.Popup;
            btnFecharApp.Location = new Point(157, 691);
            btnFecharApp.Margin = new Padding(3, 5, 3, 5);
            btnFecharApp.Name = "btnFecharApp";
            btnFecharApp.Size = new Size(77, 77);
            btnFecharApp.TabIndex = 3;
            btnFecharApp.UseVisualStyleBackColor = false;
            btnFecharApp.Click += btnFecharApp_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.Font = new Font("Segoe UI", 12F);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(104, 540);
            btnCliente.Margin = new Padding(3, 5, 3, 5);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(181, 63);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // lblDesligar
            // 
            lblDesligar.BackColor = Color.Pink;
            lblDesligar.BorderStyle = BorderStyle.FixedSingle;
            lblDesligar.Enabled = false;
            lblDesligar.Location = new Point(157, 773);
            lblDesligar.Name = "lblDesligar";
            lblDesligar.Size = new Size(77, 33);
            lblDesligar.TabIndex = 7;
            lblDesligar.Text = "Desligar";
            lblDesligar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.AutoScroll = true;
            pnlMenu.BackColor = Color.FromArgb(240, 192, 229);
            pnlMenu.BackgroundImage = (Image)resources.GetObject("pnlMenu.BackgroundImage");
            pnlMenu.Controls.Add(btnPedido);
            pnlMenu.Controls.Add(lblDesligar);
            pnlMenu.Controls.Add(btnProduto);
            pnlMenu.Controls.Add(btnFecharApp);
            pnlMenu.Controls.Add(btnCliente);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 5, 3, 5);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(397, 1055);
            pnlMenu.TabIndex = 16;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.White;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(1263, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(111, 67);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Home";
            // 
            // panelConteudo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 190);
            ClientSize = new Size(1924, 1055);
            Controls.Add(lblTitulo);
            Controls.Add(pnlMenu);
            Controls.Add(dgvPedidos);
            Controls.Add(txtPesquisar);
            Margin = new Padding(3, 5, 3, 5);
            Name = "panelConteudo";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPesquisar;
        private DataGridView dgvPedidos;
        private Button btnPedido;
        private Button btnProduto;
        private Button btnFecharApp;
        private Button btnCliente;
        private Label lblDesligar;
        private Panel pnlMenu;
        private Label lblTitulo;
    }
}