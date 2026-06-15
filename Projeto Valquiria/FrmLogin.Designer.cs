namespace Projeto_Valquiria
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnEntrar = new Button();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnEsqueci = new Button();
            tlpPrincipal = new TableLayoutPanel();
            tlpLogin = new TableLayoutPanel();
            lblTitulo = new Label();
            btnMostrarSenha = new Button();
            tlpPrincipal.SuspendLayout();
            tlpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSize = true;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Dock = DockStyle.Fill;
            btnEntrar.Font = new Font("Segoe UI", 11F);
            btnEntrar.Location = new Point(3, 449);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(456, 38);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(3, 193);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(456, 32);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(3, 321);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(456, 32);
            txtSenha.TabIndex = 2;
            // 
            // btnEsqueci
            // 
            btnEsqueci.Cursor = Cursors.Hand;
            btnEsqueci.Dock = DockStyle.Fill;
            btnEsqueci.Font = new Font("Segoe UI", 11F);
            btnEsqueci.Location = new Point(3, 515);
            btnEsqueci.Name = "btnEsqueci";
            btnEsqueci.Size = new Size(456, 38);
            btnEsqueci.TabIndex = 3;
            btnEsqueci.Text = "Esqueci a Senha";
            btnEsqueci.UseVisualStyleBackColor = true;
            btnEsqueci.Click += btnEsqueci_Click;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackgroundImage = (Image)resources.GetObject("tlpPrincipal.BackgroundImage");
            tlpPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.9932F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.712328F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.3203373F));
            tlpPrincipal.Controls.Add(tlpLogin, 1, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 21.9790668F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 68.22074F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 9.80019F));
            tlpPrincipal.Size = new Size(1898, 1029);
            tlpPrincipal.TabIndex = 4;
            // 
            // tlpLogin
            // 
            tlpLogin.BackColor = Color.Transparent;
            tlpLogin.ColumnCount = 2;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.4F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.6F));
            tlpLogin.Controls.Add(btnEsqueci, 0, 9);
            tlpLogin.Controls.Add(btnEntrar, 0, 7);
            tlpLogin.Controls.Add(lblTitulo, 0, 1);
            tlpLogin.Controls.Add(txtSenha, 0, 5);
            tlpLogin.Controls.Add(txtLogin, 0, 3);
            tlpLogin.Controls.Add(btnMostrarSenha, 1, 5);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(1312, 229);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 11;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 4.61693668F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 13.56225F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 9.226639F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 5.467626F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12.94964F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 5.467626F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12.94964F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 6.42360973F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 3.283178F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 6.42450953F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5563183F));
            tlpLogin.Size = new Size(500, 695);
            tlpLogin.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 40F);
            lblTitulo.ForeColor = Color.FromArgb(194, 24, 91);
            lblTitulo.Location = new Point(3, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(456, 94);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bem-vinda!";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMostrarSenha
            // 
            btnMostrarSenha.Cursor = Cursors.Hand;
            btnMostrarSenha.Dock = DockStyle.Fill;
            btnMostrarSenha.FlatAppearance.BorderSize = 0;
            btnMostrarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnMostrarSenha.FlatStyle = FlatStyle.Flat;
            btnMostrarSenha.ForeColor = Color.Transparent;
            btnMostrarSenha.Image = Properties.Resources.olhofechado;
            btnMostrarSenha.Location = new Point(465, 321);
            btnMostrarSenha.Name = "btnMostrarSenha";
            btnMostrarSenha.Size = new Size(32, 32);
            btnMostrarSenha.TabIndex = 4;
            btnMostrarSenha.TabStop = false;
            btnMostrarSenha.UseVisualStyleBackColor = true;
            btnMostrarSenha.Click += btnMostrarSenha_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(239, 209, 209);
            ClientSize = new Size(1898, 1029);
            Controls.Add(tlpPrincipal);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += frmLogin_Load;
            tlpPrincipal.ResumeLayout(false);
            tlpLogin.ResumeLayout(false);
            tlpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEntrar;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEsqueci;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpLogin;
        private Label lblTitulo;
        private Button btnMostrarSenha;
    }
}
