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
            panel1 = new Panel();
            txtUsuario = new TextBox();
            btnFechar = new Button();
            btnAtualizar = new Button();
            lblLogin = new Label();
            lblNovaSenha = new Label();
            lblCpf = new Label();
            txtSenha = new TextBox();
            txtCPF = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(lblNovaSenha);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtCPF);
            panel1.Location = new Point(48, 53);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 327);
            panel1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(123, 91);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite um novo nome de Login";
            txtUsuario.Size = new Size(327, 27);
            txtUsuario.TabIndex = 4;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(483, 33);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(62, 33);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(181, 227);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(193, 56);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar Senha";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(61, 95);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login:";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Location = new Point(33, 147);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(91, 20);
            lblNovaSenha.TabIndex = 2;
            lblNovaSenha.Text = "Nova Senha:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(71, 40);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 20);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(123, 143);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite uma Senha de até 10 digitos";
            txtSenha.Size = new Size(327, 27);
            txtSenha.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(123, 36);
            txtCPF.Margin = new Padding(3, 4, 3, 4);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "123.456.789-09";
            txtCPF.Size = new Size(131, 27);
            txtCPF.TabIndex = 1;
            // 
            // FrmAtualizarLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 444);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAtualizarLogin";
            Text = "FrmEsqueciSenha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSenha;
        private TextBox txtCPF;
        private Label lblNovaSenha;
        private Label lblCpf;
        private Button btnFechar;
        private Button btnAtualizar;
        private TextBox txtUsuario;
        private Label lblLogin;
    }
}