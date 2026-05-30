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
            panelMenu = new PictureBox();
            txtPesquisar = new TextBox();
            dgvPedidos = new DataGridView();
            btnPedido = new Button();
            btnProduto = new Button();
            btnFecharApp = new Button();
            btnCliente = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)panelMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMenu.BackColor = Color.FromArgb(159, 214, 242);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(273, 694);
            panelMenu.TabIndex = 0;
            panelMenu.TabStop = false;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(570, 98);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(726, 23);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToOrderColumns = true;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(539, 139);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(779, 522);
            dgvPedidos.TabIndex = 5;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(61, 250);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(158, 47);
            btnPedido.TabIndex = 0;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += button1_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.FromArgb(56, 206, 22);
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.ForeColor = Color.White;
            btnProduto.Location = new Point(61, 303);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(158, 47);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += button1_Click_1;
            // 
            // btnFecharApp
            // 
            btnFecharApp.BackColor = Color.FromArgb(159, 214, 242);
            btnFecharApp.BackgroundImage = (Image)resources.GetObject("btnFecharApp.BackgroundImage");
            btnFecharApp.BackgroundImageLayout = ImageLayout.Stretch;
            btnFecharApp.FlatStyle = FlatStyle.Popup;
            btnFecharApp.Location = new Point(30, 588);
            btnFecharApp.Name = "btnFecharApp";
            btnFecharApp.Size = new Size(62, 58);
            btnFecharApp.TabIndex = 3;
            btnFecharApp.UseVisualStyleBackColor = false;
            btnFecharApp.Click += btnFecharApp_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(253, 208, 23);
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(61, 356);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(158, 47);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Pink;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Enabled = false;
            label1.Location = new Point(30, 649);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 7;
            label1.Text = "Desligar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelConteudo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 190);
            ClientSize = new Size(1432, 694);
            Controls.Add(label1);
            Controls.Add(btnFecharApp);
            Controls.Add(btnCliente);
            Controls.Add(btnProduto);
            Controls.Add(dgvPedidos);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPedido);
            Controls.Add(panelMenu);
            Name = "panelConteudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)panelMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox panelMenu;
        private TextBox txtPesquisar;
        private DataGridView dgvPedidos;
        private Button btnPedido;
        private Button btnProduto;
        private Button btnFecharApp;
        private Button btnCliente;
        private Label label1;
    }
}