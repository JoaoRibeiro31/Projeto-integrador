namespace Projeto_Valquiria
{
    partial class pnlConteudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlConteudo));
            btnEntrar = new Button();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lbnLogin = new Label();
            lbnSenha = new Label();
            panel1 = new Panel();
            picLogo = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSize = true;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Location = new Point(1139, 483);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(176, 35);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(702, 330);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(599, 25);
            txtLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(702, 397);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(599, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbnLogin
            // 
            lbnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbnLogin.AutoSize = true;
            lbnLogin.Location = new Point(645, 330);
            lbnLogin.Name = "lbnLogin";
            lbnLogin.Size = new Size(40, 15);
            lbnLogin.TabIndex = 2;
            lbnLogin.Text = "Login:";
            // 
            // lbnSenha
            // 
            lbnSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbnSenha.AutoSize = true;
            lbnSenha.Location = new Point(645, 400);
            lbnSenha.Name = "lbnSenha";
            lbnSenha.Size = new Size(42, 15);
            lbnSenha.TabIndex = 2;
            lbnSenha.Text = "Senha:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(52, 174, 250);
            panel1.Controls.Add(picLogo);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 997);
            panel1.TabIndex = 3;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Top;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(567, 994);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(702, 483);
            button1.Name = "button1";
            button1.Size = new Size(176, 35);
            button1.TabIndex = 4;
            button1.Text = "Esqueci a Senha";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlConteudo
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 209, 209);
            ClientSize = new Size(1424, 791);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(lbnSenha);
            Controls.Add(lbnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(btnEntrar);
            Name = "pnlConteudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEntrar;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lbnLogin;
        private Label lbnSenha;
        private Panel panel1;
        private PictureBox picLogo;
        private Button button1;
    }
}
