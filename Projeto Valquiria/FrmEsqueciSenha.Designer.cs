namespace Projeto_Valquiria
{
    partial class frmEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEsqueciSenha));
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
            lblTempoRestante = new Label();
            timerEnvio = new System.Windows.Forms.Timer(components);
            lblTitulo = new Label();
            lblRodape = new Label();
            picEmail = new PictureBox();
            picCodigo = new PictureBox();
            picLogin = new PictureBox();
            picSenha = new PictureBox();
            btnMostrarSenha = new Button();
            picCoracao = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCoracao).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(207, 134);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 250;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu e-mail";
            txtEmail.Size = new Size(332, 27);
            txtEmail.TabIndex = 1;
            txtEmail.WordWrap = false;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(207, 344);
            txtNovaSenha.Margin = new Padding(3, 4, 3, 4);
            txtNovaSenha.MaxLength = 10;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PlaceholderText = "Digite uma Senha de até 10 digitos";
            txtNovaSenha.Size = new Size(457, 27);
            txtNovaSenha.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.ForeColor = Color.FromArgb(27, 77, 136);
            lblEmail.Location = new Point(101, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.BackColor = Color.Transparent;
            lblNovaSenha.ForeColor = Color.FromArgb(27, 77, 136);
            lblNovaSenha.Location = new Point(101, 347);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(91, 20);
            lblNovaSenha.TabIndex = 0;
            lblNovaSenha.Text = "Nova Senha:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.ForeColor = Color.FromArgb(27, 77, 136);
            lblLogin.Location = new Point(101, 277);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(124, 175, 238);
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 14F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(295, 405);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(193, 56);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar Senha";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(230, 242, 254);
            btnVoltar.BackgroundImage = (Image)resources.GetObject("btnVoltar.BackgroundImage");
            btnVoltar.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.ForeColor = Color.Transparent;
            btnVoltar.Location = new Point(700, 25);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(52, 53);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = " ";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(207, 274);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.MaxLength = 20;
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite um novo nome de Login";
            txtLogin.Size = new Size(457, 27);
            txtLogin.TabIndex = 4;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.BackColor = Color.FromArgb(230, 116, 165);
            btnEnviarCodigo.FlatAppearance.BorderSize = 0;
            btnEnviarCodigo.FlatStyle = FlatStyle.Popup;
            btnEnviarCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnviarCodigo.ForeColor = Color.White;
            btnEnviarCodigo.Location = new Point(545, 133);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(119, 29);
            btnEnviarCodigo.TabIndex = 2;
            btnEnviarCodigo.Text = "Enviar Código";
            btnEnviarCodigo.UseVisualStyleBackColor = false;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.ForeColor = Color.FromArgb(27, 77, 136);
            lblCodigo.Location = new Point(140, 220);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(207, 204);
            txtCodigo.MaxLength = 10;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Digite o código recebido";
            txtCodigo.Size = new Size(457, 27);
            txtCodigo.TabIndex = 3;
            // 
            // lblTempoRestante
            // 
            lblTempoRestante.AutoSize = true;
            lblTempoRestante.BackColor = Color.Transparent;
            lblTempoRestante.ForeColor = Color.Goldenrod;
            lblTempoRestante.Location = new Point(545, 175);
            lblTempoRestante.Name = "lblTempoRestante";
            lblTempoRestante.Size = new Size(0, 20);
            lblTempoRestante.TabIndex = 9;
            // 
            // timerEnvio
            // 
            timerEnvio.Interval = 1000;
            timerEnvio.Tick += timerEnvio_Tick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 30F);
            lblTitulo.ForeColor = Color.FromArgb(27, 77, 136);
            lblTitulo.Location = new Point(220, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(341, 67);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Esqueci Senha";
            // 
            // lblRodape
            // 
            lblRodape.BackColor = Color.Transparent;
            lblRodape.ForeColor = Color.FromArgb(27, 77, 136);
            lblRodape.Image = (Image)resources.GetObject("lblRodape.Image");
            lblRodape.ImageAlign = ContentAlignment.MiddleLeft;
            lblRodape.Location = new Point(250, 500);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(283, 20);
            lblRodape.TabIndex = 0;
            lblRodape.Text = "Sua segurança é importante para nós.\r\n";
            lblRodape.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picEmail
            // 
            picEmail.Anchor = AnchorStyles.None;
            picEmail.BackColor = Color.Transparent;
            picEmail.Image = (Image)resources.GetObject("picEmail.Image");
            picEmail.Location = new Point(50, 125);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(45, 45);
            picEmail.TabIndex = 12;
            picEmail.TabStop = false;
            // 
            // picCodigo
            // 
            picCodigo.Anchor = AnchorStyles.None;
            picCodigo.BackColor = Color.Transparent;
            picCodigo.Image = (Image)resources.GetObject("picCodigo.Image");
            picCodigo.Location = new Point(50, 195);
            picCodigo.Name = "picCodigo";
            picCodigo.Size = new Size(45, 45);
            picCodigo.TabIndex = 13;
            picCodigo.TabStop = false;
            // 
            // picLogin
            // 
            picLogin.Anchor = AnchorStyles.None;
            picLogin.BackColor = Color.Transparent;
            picLogin.Image = (Image)resources.GetObject("picLogin.Image");
            picLogin.Location = new Point(50, 265);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(45, 45);
            picLogin.TabIndex = 14;
            picLogin.TabStop = false;
            // 
            // picSenha
            // 
            picSenha.Anchor = AnchorStyles.None;
            picSenha.BackColor = Color.Transparent;
            picSenha.Image = (Image)resources.GetObject("picSenha.Image");
            picSenha.Location = new Point(50, 335);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(45, 45);
            picSenha.TabIndex = 15;
            picSenha.TabStop = false;
            // 
            // btnMostrarSenha
            // 
            btnMostrarSenha.Cursor = Cursors.Hand;
            btnMostrarSenha.FlatAppearance.BorderSize = 0;
            btnMostrarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnMostrarSenha.FlatStyle = FlatStyle.Flat;
            btnMostrarSenha.ForeColor = Color.Transparent;
            btnMostrarSenha.Image = Properties.Resources.olhofechado;
            btnMostrarSenha.Location = new Point(670, 341);
            btnMostrarSenha.Name = "btnMostrarSenha";
            btnMostrarSenha.Size = new Size(32, 32);
            btnMostrarSenha.TabIndex = 6;
            btnMostrarSenha.TabStop = false;
            btnMostrarSenha.UseVisualStyleBackColor = true;
            btnMostrarSenha.Click += btnMostrarSenha_Click;
            // 
            // picCoracao
            // 
            picCoracao.BackColor = Color.Transparent;
            picCoracao.Image = (Image)resources.GetObject("picCoracao.Image");
            picCoracao.Location = new Point(220, 81);
            picCoracao.Name = "picCoracao";
            picCoracao.Size = new Size(341, 29);
            picCoracao.SizeMode = PictureBoxSizeMode.Zoom;
            picCoracao.TabIndex = 17;
            picCoracao.TabStop = false;
            // 
            // frmEsqueciSenha
            // 
            AcceptButton = btnAtualizar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 254);
            BackgroundImageLayout = ImageLayout.Center;
            CancelButton = btnVoltar;
            ClientSize = new Size(782, 553);
            Controls.Add(picCoracao);
            Controls.Add(btnMostrarSenha);
            Controls.Add(picSenha);
            Controls.Add(picLogin);
            Controls.Add(picCodigo);
            Controls.Add(picEmail);
            Controls.Add(lblRodape);
            Controls.Add(lblTitulo);
            Controls.Add(lblTempoRestante);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(960, 720);
            MinimumSize = new Size(640, 480);
            Name = "frmEsqueciSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmEsqueciSenha_Load;
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCoracao).EndInit();
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
        private Label lblTempoRestante;
        private System.Windows.Forms.Timer timerEnvio;
        private Label lblTitulo;
        private Label lblRodape;
        private PictureBox picEmail;
        private PictureBox picCodigo;
        private PictureBox picLogin;
        private PictureBox picSenha;
        private Button btnMostrarSenha;
        private PictureBox picCoracao;
    }
}