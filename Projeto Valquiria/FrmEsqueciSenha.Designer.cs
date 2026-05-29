namespace Projeto_Valquiria
{
    partial class FrmAtualizarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtualizarLogin));
            txtCPF = new TextBox();
            txtSenha = new TextBox();
            lblCpf = new Label();
            lblNovaSenha = new Label();
            lblLogin = new Label();
            btnAtualizar = new Button();
            btnFechar = new Button();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(108, 27);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "123.456.789-09";
            txtCPF.Size = new Size(115, 23);
            txtCPF.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(108, 107);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite uma Senha de até 10 digitos";
            txtSenha.Size = new Size(287, 23);
            txtSenha.TabIndex = 2;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(62, 30);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF:";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(29, 110);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(73, 15);
            lblNovaSenha.TabIndex = 2;
            lblNovaSenha.Text = "Nova Senha:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(53, 71);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(158, 170);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(169, 42);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar Senha";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.Location = new Point(440, 25);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(37, 25);
            btnFechar.TabIndex = 0;
            btnFechar.Text = " ";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(108, 68);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite um novo nome de Login";
            txtUsuario.Size = new Size(287, 23);
            txtUsuario.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(lblNovaSenha);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtCPF);
            panel1.Location = new Point(42, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 245);
            panel1.TabIndex = 0;
            // 
            // FrmAtualizarLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(578, 333);
            Controls.Add(panel1);
            Name = "FrmAtualizarLogin";
            Text = "FrmEsqueciSenha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCPF;
        private TextBox txtSenha;
        private Label lblCpf;
        private Label lblNovaSenha;
        private Label lblLogin;
        private Button btnAtualizar;
        private Button btnFechar;
        private TextBox txtUsuario;
        private Panel panel1;
    }
}