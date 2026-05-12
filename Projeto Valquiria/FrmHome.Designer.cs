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
            lblPesquisar = new Label();
            dgvPedidos = new DataGridView();
            btnProdutos = new Button();
            ((System.ComponentModel.ISupportInitialize)panelMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(312, 1055);
            panelMenu.TabIndex = 0;
            panelMenu.TabStop = false;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(247, 157, 189);
            btnPedidos.Location = new Point(25, 37);
            btnPedidos.Margin = new Padding(3, 4, 3, 4);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(261, 168);
            btnPedidos.TabIndex = 0;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += button1_Click;
            // 
            // btnDados
            // 
            btnDados.BackColor = Color.FromArgb(247, 157, 189);
            btnDados.Location = new Point(25, 559);
            btnDados.Margin = new Padding(3, 4, 3, 4);
            btnDados.Name = "btnDados";
            btnDados.Size = new Size(261, 168);
            btnDados.TabIndex = 2;
            btnDados.Text = "Dados";
            btnDados.UseVisualStyleBackColor = false;
            btnDados.Click += button1_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(977, 121);
            txtPesquisar.Margin = new Padding(3, 4, 3, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(597, 27);
            txtPesquisar.TabIndex = 6;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.White;
            lblPesquisar.BorderStyle = BorderStyle.FixedSingle;
            lblPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesquisar.Location = new Point(894, 123);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(87, 25);
            lblPesquisar.TabIndex = 4;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToOrderColumns = true;
            dgvPedidos.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(631, 213);
            dgvPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(1262, 956);
            dgvPedidos.TabIndex = 5;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.FromArgb(247, 157, 189);
            btnProdutos.Location = new Point(25, 284);
            btnProdutos.Margin = new Padding(3, 4, 3, 4);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(261, 168);
            btnProdutos.TabIndex = 7;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += button1_Click_1;
            // 
            // panelConteudo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 174, 250);
            ClientSize = new Size(1627, 1055);
            Controls.Add(btnProdutos);
            Controls.Add(dgvPedidos);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnDados);
            Controls.Add(btnPedidos);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblPesquisar;
        private DataGridView dgvPedidos;
        private Button btnProdutos;
    }
}