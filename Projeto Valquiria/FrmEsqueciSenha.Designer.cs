namespace Projeto_Valquiria
{
    partial class FrmEsqueciSenha
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEsqueciSenha));
            txtEmail = new TextBox();
            txtNovaSenha = new TextBox();
            lblEmail = new Label();
            lblNovaSenha = new Label();
            lblLogin = new Label();
            btnAtualizar = new Button();
            btnVoltar = new Button();
            txtLogin = new TextBox();
            btnEnviarCodigo = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblEmailVerificacao = new Label();
            lblTempoRestante = new Label();
            timerEnvio = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(204, 114);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu e-mail";
            txtEmail.Size = new Size(274, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(204, 308);
            txtNovaSenha.Margin = new Padding(3, 4, 3, 4);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PlaceholderText = "Digite uma Senha de até 10 digitos";
            txtNovaSenha.Size = new Size(393, 27);
            txtNovaSenha.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(150, 113);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.BackColor = Color.Transparent;
            lblNovaSenha.ForeColor = Color.White;
            lblNovaSenha.Location = new Point(108, 315);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(91, 20);
            lblNovaSenha.TabIndex = 2;
            lblNovaSenha.Text = "Nova Senha:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(150, 270);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(293, 354);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(193, 56);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar Senha";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(504, 45);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(39, 44);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = " ";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(204, 270);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite um novo nome de Login";
            txtLogin.Size = new Size(393, 27);
            txtLogin.TabIndex = 4;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(484, 114);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(113, 29);
            btnEnviarCodigo.TabIndex = 5;
            btnEnviarCodigo.Text = "Enviar Código";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(141, 173);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(204, 170);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Digite o código recebido";
            txtCodigo.Size = new Size(393, 27);
            txtCodigo.TabIndex = 7;
            // 
            // lblEmailVerificacao
            // 
            lblEmailVerificacao.AutoSize = true;
            lblEmailVerificacao.BackColor = Color.Transparent;
            lblEmailVerificacao.ForeColor = Color.Yellow;
            lblEmailVerificacao.Location = new Point(226, 215);
            lblEmailVerificacao.Name = "lblEmailVerificacao";
            lblEmailVerificacao.Size = new Size(327, 20);
            lblEmailVerificacao.TabIndex = 8;
            lblEmailVerificacao.Text = "_____________________________________________________";
            // 
            // lblTempoRestante
            // 
            lblTempoRestante.AutoSize = true;
            lblTempoRestante.BackColor = Color.Transparent;
            lblTempoRestante.ForeColor = Color.Yellow;
            lblTempoRestante.Location = new Point(504, 146);
            lblTempoRestante.Name = "lblTempoRestante";
            lblTempoRestante.Size = new Size(0, 20);
            lblTempoRestante.TabIndex = 9;
            // 
            // timerEnvio
            // 
            timerEnvio.Interval = 1000;
            // 
            // FrmEsqueciSenha
            // 
            AcceptButton = btnAtualizar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 208, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(782, 553);
            Controls.Add(lblTempoRestante);
            Controls.Add(lblEmailVerificacao);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(btnVoltar);
            Controls.Add(txtLogin);
            Controls.Add(btnAtualizar);
            Controls.Add(lblNovaSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtNovaSenha);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEsqueciSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtNovaSenha;
        private Label lblEmail;
        private Label lblNovaSenha;
        private Label lblLogin;
        private Button btnAtualizar;
        private Button btnVoltar;
        private TextBox txtLogin;
        private Button btnEnviarCodigo;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblEmailVerificacao;
        private Label lblTempoRestante;
        private System.Windows.Forms.Timer timerEnvio;
    }
}