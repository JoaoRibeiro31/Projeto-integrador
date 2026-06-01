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
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(164, 92);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "123.456.789-09";
            txtCPF.Size = new Size(115, 23);
            txtCPF.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(164, 150);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite uma Senha de até 10 digitos";
            txtSenha.Size = new Size(287, 23);
            txtSenha.TabIndex = 2;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(117, 92);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF:";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(85, 150);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(73, 15);
            lblNovaSenha.TabIndex = 2;
            lblNovaSenha.Text = "Nova Senha:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(108, 121);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(219, 209);
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
            btnFechar.Location = new Point(512, 35);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(37, 25);
            btnFechar.TabIndex = 0;
            btnFechar.Text = " ";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(164, 121);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite um novo nome de Login";
            txtUsuario.Size = new Size(287, 23);
            txtUsuario.TabIndex = 4;
            // 
            // FrmAtualizarLogin
            // 
            AcceptButton = btnAtualizar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(578, 333);
            Controls.Add(btnFechar);
            Controls.Add(txtUsuario);
            Controls.Add(btnAtualizar);
            Controls.Add(lblNovaSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblCpf);
            Controls.Add(txtCPF);
            Controls.Add(txtSenha);
            Name = "FrmAtualizarLogin";
            Text = "FrmEsqueciSenha";
            ResumeLayout(false);
            PerformLayout();
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
    }
}