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
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.AutoSize = true;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Location = new Point(789, 452);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(346, 35);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(789, 355);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(346, 25);
            txtLogin.TabIndex = 0;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.Location = new Point(789, 407);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(346, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(869, 520);
            button1.Name = "button1";
            button1.Size = new Size(176, 35);
            button1.TabIndex = 4;
            button1.Text = "Esqueci a Senha";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtLogin);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 782);
            panel1.TabIndex = 5;
            // 
            // pnlConteudo
            // 
            AcceptButton = btnEntrar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(239, 209, 209);
            ClientSize = new Size(1171, 782);
            Controls.Add(panel1);
            Name = "pnlConteudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEntrar;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button button1;
        private Panel panel1;
    }
}
