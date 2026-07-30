namespace Projeto_Valquiria
{
    partial class frmCadastrarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarLogin));
            picCoracao = new PictureBox();
            btnMostrarSenha = new Button();
            picSenha = new PictureBox();
            picLogin = new PictureBox();
            picCodigo = new PictureBox();
            picEmail = new PictureBox();
            lblRodape = new Label();
            lblTitulo = new Label();
            lblTempoRestante = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnEnviarCodigo = new Button();
            btnVoltar = new Button();
            txtLogin = new TextBox();
            btnCadastrar = new Button();
            lblNovaSenha = new Label();
            lblLogin = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtNovaSenha = new TextBox();
            timerEnvio = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCoracao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            SuspendLayout();
            // 
            // picCoracao
            // 
            picCoracao.BackColor = Color.Transparent;
            picCoracao.Image = (Image)resources.GetObject("picCoracao.Image");
            picCoracao.Location = new Point(217, 81);
            picCoracao.Name = "picCoracao";
            picCoracao.Size = new Size(341, 29);
            picCoracao.SizeMode = PictureBoxSizeMode.Zoom;
            picCoracao.TabIndex = 37;
            picCoracao.TabStop = false;
            // 
            // btnMostrarSenha
            // 
            btnMostrarSenha.Cursor = Cursors.Hand;
            btnMostrarSenha.FlatAppearance.BorderSize = 0;
            btnMostrarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnMostrarSenha.FlatStyle = FlatStyle.Flat;
            btnMostrarSenha.ForeColor = Color.Transparent;
            btnMostrarSenha.Image = Properties.Resources.olhofechado;
            btnMostrarSenha.Location = new Point(667, 341);
            btnMostrarSenha.Name = "btnMostrarSenha";
            btnMostrarSenha.Size = new Size(32, 32);
            btnMostrarSenha.TabIndex = 29;
            btnMostrarSenha.UseVisualStyleBackColor = true;
            btnMostrarSenha.Click += btnMostrarSenha_Click;
            // 
            // picSenha
            // 
            picSenha.Anchor = AnchorStyles.None;
            picSenha.BackColor = Color.Transparent;
            picSenha.Image = (Image)resources.GetObject("picSenha.Image");
            picSenha.Location = new Point(56, 335);
            picSenha.Name = "picSenha";
            picSenha.Size = new Size(45, 45);
            picSenha.TabIndex = 36;
            picSenha.TabStop = false;
            // 
            // picLogin
            // 
            picLogin.Anchor = AnchorStyles.None;
            picLogin.BackColor = Color.Transparent;
            picLogin.Image = (Image)resources.GetObject("picLogin.Image");
            picLogin.Location = new Point(56, 265);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(45, 45);
            picLogin.TabIndex = 35;
            picLogin.TabStop = false;
            // 
            // picCodigo
            // 
            picCodigo.Anchor = AnchorStyles.None;
            picCodigo.BackColor = Color.Transparent;
            picCodigo.Image = (Image)resources.GetObject("picCodigo.Image");
            picCodigo.Location = new Point(56, 195);
            picCodigo.Name = "picCodigo";
            picCodigo.Size = new Size(45, 45);
            picCodigo.TabIndex = 34;
            picCodigo.TabStop = false;
            // 
            // picEmail
            // 
            picEmail.Anchor = AnchorStyles.None;
            picEmail.BackColor = Color.Transparent;
            picEmail.Image = (Image)resources.GetObject("picEmail.Image");
            picEmail.Location = new Point(56, 125);
            picEmail.Name = "picEmail";
            picEmail.Size = new Size(45, 45);
            picEmail.TabIndex = 33;
            picEmail.TabStop = false;
            // 
            // lblRodape
            // 
            lblRodape.BackColor = Color.Transparent;
            lblRodape.ForeColor = Color.FromArgb(27, 77, 136);
            lblRodape.Image = (Image)resources.GetObject("lblRodape.Image");
            lblRodape.ImageAlign = ContentAlignment.MiddleLeft;
            lblRodape.Location = new Point(247, 500);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(283, 20);
            lblRodape.TabIndex = 21;
            lblRodape.Text = "Sua segurança é importante para nós.\r\n";
            lblRodape.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 30F);
            lblTitulo.ForeColor = Color.FromArgb(27, 77, 136);
            lblTitulo.Location = new Point(198, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(379, 67);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Primeiro Acesso";
            // 
            // lblTempoRestante
            // 
            lblTempoRestante.AutoSize = true;
            lblTempoRestante.BackColor = Color.Transparent;
            lblTempoRestante.ForeColor = Color.Goldenrod;
            lblTempoRestante.Location = new Point(542, 175);
            lblTempoRestante.Name = "lblTempoRestante";
            lblTempoRestante.Size = new Size(0, 20);
            lblTempoRestante.TabIndex = 32;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(204, 204);
            txtCodigo.MaxLength = 10;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Digite o código recebido";
            txtCodigo.Size = new Size(457, 27);
            txtCodigo.TabIndex = 26;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.ForeColor = Color.FromArgb(27, 77, 136);
            lblCodigo.Location = new Point(98, 207);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 23;
            lblCodigo.Text = "Código:";
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.BackColor = Color.FromArgb(230, 116, 165);
            btnEnviarCodigo.FlatAppearance.BorderSize = 0;
            btnEnviarCodigo.FlatStyle = FlatStyle.Popup;
            btnEnviarCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnviarCodigo.ForeColor = Color.White;
            btnEnviarCodigo.Location = new Point(542, 133);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(119, 29);
            btnEnviarCodigo.TabIndex = 25;
            btnEnviarCodigo.Text = "Enviar Código";
            btnEnviarCodigo.UseVisualStyleBackColor = false;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(230, 242, 254);
            btnVoltar.BackgroundImage = (Image)resources.GetObject("btnVoltar.BackgroundImage");
            btnVoltar.BackgroundImageLayout = ImageLayout.Zoom;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.ForeColor = Color.Transparent;
            btnVoltar.Location = new Point(697, 25);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(52, 53);
            btnVoltar.TabIndex = 31;
            btnVoltar.Text = " ";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(204, 274);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.MaxLength = 20;
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite um novo nome de Login";
            txtLogin.Size = new Size(457, 27);
            txtLogin.TabIndex = 27;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(124, 175, 238);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 14F);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(292, 405);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(193, 56);
            btnCadastrar.TabIndex = 30;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.BackColor = Color.Transparent;
            lblNovaSenha.ForeColor = Color.FromArgb(27, 77, 136);
            lblNovaSenha.Location = new Point(98, 347);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(91, 20);
            lblNovaSenha.TabIndex = 20;
            lblNovaSenha.Text = "Nova Senha:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.ForeColor = Color.FromArgb(27, 77, 136);
            lblLogin.Location = new Point(98, 277);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(49, 20);
            lblLogin.TabIndex = 19;
            lblLogin.Text = "Login:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.ForeColor = Color.FromArgb(27, 77, 136);
            lblEmail.Location = new Point(98, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(204, 134);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 250;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu e-mail";
            txtEmail.Size = new Size(332, 27);
            txtEmail.TabIndex = 24;
            txtEmail.WordWrap = false;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(204, 344);
            txtNovaSenha.Margin = new Padding(3, 4, 3, 4);
            txtNovaSenha.MaxLength = 10;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PlaceholderText = "Digite uma Senha de até 10 digitos";
            txtNovaSenha.Size = new Size(457, 27);
            txtNovaSenha.TabIndex = 28;
            // 
            // timerEnvio
            // 
            timerEnvio.Interval = 1000;
            timerEnvio.Tick += timerEnvio_Tick;
            // 
            // frmCadastrarLogin
            // 
            AcceptButton = btnCadastrar;
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
            Controls.Add(btnCadastrar);
            Controls.Add(lblNovaSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtNovaSenha);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(960, 720);
            MinimumSize = new Size(640, 480);
            Name = "frmCadastrarLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmCadastrarLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picCoracao).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCoracao;
        private Button btnMostrarSenha;
        private PictureBox picSenha;
        private PictureBox picLogin;
        private PictureBox picCodigo;
        private PictureBox picEmail;
        private Label lblRodape;
        private Label lblTitulo;
        private Label lblTempoRestante;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button btnEnviarCodigo;
        private Button btnVoltar;
        private TextBox txtLogin;
        private Button btnCadastrar;
        private Label lblNovaSenha;
        private Label lblLogin;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtNovaSenha;
        private System.Windows.Forms.Timer timerEnvio;
    }
}