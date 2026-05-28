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
            panelMenu = new PictureBox();
            btnPedidos = new Button();
            btnDados = new Button();
            txtPesquisar = new TextBox();
            dgvPedidos = new DataGridView();
            btnProdutos = new Button();
            btnPedido = new Button();
            btnProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)panelMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(159, 214, 242);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(273, 694);
            panelMenu.TabIndex = 0;
            panelMenu.TabStop = false;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(164, 92, 218);
            btnPedidos.FlatStyle = FlatStyle.Popup;
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Location = new Point(61, 264);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(158, 47);
            btnPedidos.TabIndex = 0;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += button1_Click;
            // 
            // btnDados
            // 
            btnDados.BackColor = Color.FromArgb(253, 208, 23);
            btnDados.FlatStyle = FlatStyle.Popup;
            btnDados.ForeColor = Color.White;
            btnDados.Location = new Point(61, 403);
            btnDados.Name = "btnDados";
            btnDados.Size = new Size(158, 47);
            btnDados.TabIndex = 2;
            btnDados.Text = "Dados";
            btnDados.UseVisualStyleBackColor = false;
            btnDados.Click += button1_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(570, 98);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar:";
            txtPesquisar.Size = new Size(726, 23);
            txtPesquisar.TabIndex = 6;
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
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(247, 157, 189);
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(61, 337);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(158, 47);
            btnProdutos.TabIndex = 7;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += button1_Click_1;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(164, 92, 218);
            btnPedido.FlatStyle = FlatStyle.Popup;
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(61, 264);
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
            btnProduto.Location = new Point(61, 337);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(158, 47);
            btnProduto.TabIndex = 7;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += button1_Click_1;
            // 
            // panelConteudo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 190);
            ClientSize = new Size(1345, 694);
            Controls.Add(btnProduto);
            Controls.Add(btnProdutos);
            Controls.Add(dgvPedidos);
            Controls.Add(txtPesquisar);
            Controls.Add(btnDados);
            Controls.Add(btnPedido);
            Controls.Add(btnPedidos);
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
        private Button btnPedidos;
        private Button btnDados;
        private TextBox txtPesquisar;
        private DataGridView dgvPedidos;
        private Button btnProdutos;
        private Button btnPedido;
        private Button btnProduto;
    }
}