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
            btnMostrarSenha = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tlpPrincipal.SuspendLayout();
            tlpLogin.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSize = true;
            btnEntrar.BackColor = Color.FromArgb(71, 139, 236);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Dock = DockStyle.Fill;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(41, 433);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(461, 48);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(41, 177);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(461, 32);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(41, 305);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(461, 32);
            txtSenha.TabIndex = 2;
            // 
            // btnEsqueci
            // 
            btnEsqueci.BackColor = Color.FromArgb(239, 246, 254);
            btnEsqueci.Cursor = Cursors.Hand;
            btnEsqueci.Dock = DockStyle.Fill;
            btnEsqueci.FlatAppearance.BorderColor = Color.FromArgb(237, 142, 186);
            btnEsqueci.FlatAppearance.BorderSize = 2;
            btnEsqueci.FlatStyle = FlatStyle.Flat;
            btnEsqueci.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEsqueci.ForeColor = Color.FromArgb(237, 142, 186);
            btnEsqueci.Image = (Image)resources.GetObject("btnEsqueci.Image");
            btnEsqueci.ImageAlign = ContentAlignment.MiddleLeft;
            btnEsqueci.Location = new Point(95, 3);
            btnEsqueci.Name = "btnEsqueci";
            btnEsqueci.Size = new Size(270, 43);
            btnEsqueci.TabIndex = 5;
            btnEsqueci.Text = "Esqueci a Senha";
            btnEsqueci.UseVisualStyleBackColor = false;
            btnEsqueci.Click += btnEsqueci_Click;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackgroundImage = (Image)resources.GetObject("tlpPrincipal.BackgroundImage");
            tlpPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.9652252F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.6617489F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.3203373F));
            tlpPrincipal.Controls.Add(tlpLogin, 1, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 21.9790668F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 68.22074F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 9.80019F));
            tlpPrincipal.Size = new Size(1920, 1055);
            tlpPrincipal.TabIndex = 4;
            // 
            // tlpLogin
            // 
            tlpLogin.BackColor = Color.FromArgb(239, 246, 254);
            tlpLogin.ColumnCount = 3;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.063197F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.8736038F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.063197F));
            tlpLogin.Controls.Add(txtSenha, 1, 5);
            tlpLogin.Controls.Add(btnMostrarSenha, 2, 5);
            tlpLogin.Controls.Add(txtLogin, 1, 3);
            tlpLogin.Controls.Add(btnEntrar, 1, 7);
            tlpLogin.Controls.Add(tableLayoutPanel1, 1, 1);
            tlpLogin.Controls.Add(pictureBox1, 0, 5);
            tlpLogin.Controls.Add(pictureBox2, 0, 3);
            tlpLogin.Controls.Add(tableLayoutPanel2, 1, 9);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(1289, 234);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 11;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 4.18359041F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8201437F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 6.04316568F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 5.485898F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9929142F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 5.485898F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9929142F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 7.79013348F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 5.914731F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 7.913669F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2733822F));
            tlpLogin.Size = new Size(544, 713);
            tlpLogin.TabIndex = 1;
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
            btnMostrarSenha.Location = new Point(508, 305);
            btnMostrarSenha.Name = "btnMostrarSenha";
            btnMostrarSenha.Size = new Size(33, 32);
            btnMostrarSenha.TabIndex = 3;
            btnMostrarSenha.UseVisualStyleBackColor = true;
            btnMostrarSenha.Click += btnMostrarSenha_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.5020523F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9992886F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.49866F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(41, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(461, 97);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(185, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(90, 91);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnEsqueci, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(41, 528);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(461, 49);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(239, 209, 209);
            ClientSize = new Size(1920, 1055);
            Controls.Add(tlpPrincipal);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += frmLogin_Load;
            tlpPrincipal.ResumeLayout(false);
            tlpLogin.ResumeLayout(false);
            tlpLogin.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnEntrar;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEsqueci;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpLogin;
        private Button btnMostrarSenha;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
