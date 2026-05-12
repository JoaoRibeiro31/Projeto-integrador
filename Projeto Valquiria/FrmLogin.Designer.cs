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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSize = true;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Location = new Point(1302, 644);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(201, 47);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(802, 440);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(684, 29);
            txtLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(802, 529);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(684, 27);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbnLogin
            // 
            lbnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbnLogin.AutoSize = true;
            lbnLogin.Location = new Point(737, 440);
            lbnLogin.Name = "lbnLogin";
            lbnLogin.Size = new Size(49, 20);
            lbnLogin.TabIndex = 2;
            lbnLogin.Text = "Login:";
            // 
            // lbnSenha
            // 
            lbnSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbnSenha.AutoSize = true;
            lbnSenha.Location = new Point(737, 533);
            lbnSenha.Name = "lbnSenha";
            lbnSenha.Size = new Size(52, 20);
            lbnSenha.TabIndex = 2;
            lbnSenha.Text = "Senha:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(52, 174, 250);
            panel1.Controls.Add(picLogo);
            panel1.Location = new Point(-6, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 1329);
            panel1.TabIndex = 3;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Top;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(648, 1325);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlConteudo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 209, 209);
            ClientSize = new Size(1627, 1055);
            Controls.Add(panel1);
            Controls.Add(lbnSenha);
            Controls.Add(lbnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(btnEntrar);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
