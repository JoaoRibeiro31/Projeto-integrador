namespace Projeto_Valquiria
{
    partial class frmAtualizarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizarEmail));
            picCoracao = new PictureBox();
            picCodigoN = new PictureBox();
            picEmailN = new PictureBox();
            picCodigo = new PictureBox();
            picEmail = new PictureBox();
            lblRodape = new Label();
            lblTitulo = new Label();
            lblTempoRestante = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnEnviarCodigo = new Button();
            btnVoltar = new Button();
            txtEmailN = new TextBox();
            btnAtualizar = new Button();
            lblCodigoN = new Label();
            lblEmailN = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtCodigoN = new TextBox();
            btnEnviarCodigoN = new Button();
            lblTempoRestanteN = new Label();
            timerEnvio = new System.Windows.Forms.Timer(components);
            timerEnvioN = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCoracao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCodigoN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmailN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).BeginInit();
            SuspendLayout();
            // 
            // picCoracao
            // 
            picCoracao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picCoracao.BackColor = Color.Transparent;
            picCoracao.Image = (Image)resources.GetObject("picCoracao.Image");
            picCoracao.Location = new Point(215, 85);
            picCoracao.Name = "picCoracao";
            picCoracao.Size = new Size(341, 29);
            picCoracao.SizeMode = PictureBoxSizeMode.Zoom;
            picCoracao.TabIndex = 57;
            picCoracao.TabStop = false;
            // 
            // picCodigoN
            // 
            picCodigoN.Anchor = AnchorStyles.None;
            picCodigoN.BackColor = Color.Transparent;
            picCodigoN.Image = (Image)resources.GetObject("picCodigoN.Image");
            picCodigoN.Location = new Point(56, 340);
            picCodigoN.Name = "picCodigoN";
            picCodigoN.Size = new Size(45, 45);
            picCodigoN.TabIndex = 56;
            picCodigoN.TabStop = false;
            // 
            // picEmailN
            // 
            picEmailN.Anchor = AnchorStyles.None;
            picEmailN.BackColor = Color.Transparent;
            picEmailN.Image = (Image)resources.GetObject("picEmailN.Image");
            picEmailN.Location = new Point(56, 270);
            picEmailN.Name = "picEmailN";
            picEmailN.Size = new Size(45, 45);
            picEmailN.TabIndex = 55;
            picEmailN.TabStop = false;
            // 
            // picCodigo
            // 
            picCodigo.Anchor = AnchorStyles.None;
            picCodigo.BackColor = Color.Transparent;
            picCodigo.Image = (Image)resources.GetObject("picCodigo.Image");
            picCodigo.Location = new Point(56, 195);
            picCodigo.Name = "picCodigo";
            picCodigo.Size = new Size(45, 45);
            picCodigo.TabIndex = 54;
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
            picEmail.TabIndex = 53;
            picEmail.TabStop = false;
            // 
            // lblRodape
            // 
            lblRodape.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRodape.BackColor = Color.Transparent;
            lblRodape.ForeColor = Color.FromArgb(27, 77, 136);
            lblRodape.Image = (Image)resources.GetObject("lblRodape.Image");
            lblRodape.ImageAlign = ContentAlignment.MiddleLeft;
            lblRodape.Location = new Point(245, 504);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(283, 20);
            lblRodape.TabIndex = 41;
            lblRodape.Text = "Sua segurança é importante para nós.\r\n";
            lblRodape.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 30F);
            lblTitulo.ForeColor = Color.FromArgb(27, 77, 136);
            lblTitulo.Location = new Point(275, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 67);
            lblTitulo.TabIndex = 42;
            lblTitulo.Text = "Atualizar";
            // 
            // lblTempoRestante
            // 
            lblTempoRestante.AutoSize = true;
            lblTempoRestante.BackColor = Color.Transparent;
            lblTempoRestante.ForeColor = Color.Goldenrod;
            lblTempoRestante.Location = new Point(540, 179);
            lblTempoRestante.Name = "lblTempoRestante";
            lblTempoRestante.Size = new Size(0, 20);
            lblTempoRestante.TabIndex = 52;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(202, 204);
            txtCodigo.MaxLength = 6;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Digite o código recebido";
            txtCodigo.Size = new Size(457, 27);
            txtCodigo.TabIndex = 46;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.ForeColor = Color.FromArgb(27, 77, 136);
            lblCodigo.Location = new Point(110, 207);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 43;
            lblCodigo.Text = "Código:";
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.BackColor = Color.FromArgb(230, 116, 165);
            btnEnviarCodigo.FlatAppearance.BorderSize = 0;
            btnEnviarCodigo.FlatStyle = FlatStyle.Popup;
            btnEnviarCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnviarCodigo.ForeColor = Color.White;
            btnEnviarCodigo.Location = new Point(540, 133);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(119, 29);
            btnEnviarCodigo.TabIndex = 45;
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
            btnVoltar.Location = new Point(695, 29);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(52, 53);
            btnVoltar.TabIndex = 51;
            btnVoltar.Text = " ";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtEmailN
            // 
            txtEmailN.Location = new Point(202, 279);
            txtEmailN.Margin = new Padding(3, 4, 3, 4);
            txtEmailN.MaxLength = 250;
            txtEmailN.Name = "txtEmailN";
            txtEmailN.PlaceholderText = "Digite um novo email de login";
            txtEmailN.Size = new Size(332, 27);
            txtEmailN.TabIndex = 47;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAtualizar.BackColor = Color.FromArgb(124, 175, 238);
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 14F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(290, 409);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(193, 56);
            btnAtualizar.TabIndex = 50;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lblCodigoN
            // 
            lblCodigoN.AutoSize = true;
            lblCodigoN.BackColor = Color.Transparent;
            lblCodigoN.ForeColor = Color.FromArgb(27, 77, 136);
            lblCodigoN.Location = new Point(110, 352);
            lblCodigoN.Name = "lblCodigoN";
            lblCodigoN.Size = new Size(61, 20);
            lblCodigoN.TabIndex = 40;
            lblCodigoN.Text = "Código:";
            // 
            // lblEmailN
            // 
            lblEmailN.AutoSize = true;
            lblEmailN.BackColor = Color.Transparent;
            lblEmailN.ForeColor = Color.FromArgb(27, 77, 136);
            lblEmailN.Location = new Point(110, 282);
            lblEmailN.Name = "lblEmailN";
            lblEmailN.Size = new Size(89, 20);
            lblEmailN.TabIndex = 39;
            lblEmailN.Text = "Novo Email:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.ForeColor = Color.FromArgb(27, 77, 136);
            lblEmail.Location = new Point(110, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(86, 20);
            lblEmail.TabIndex = 38;
            lblEmail.Text = "Email atual:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 134);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 250;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu e-mail";
            txtEmail.Size = new Size(332, 27);
            txtEmail.TabIndex = 44;
            txtEmail.WordWrap = false;
            // 
            // txtCodigoN
            // 
            txtCodigoN.Location = new Point(202, 349);
            txtCodigoN.MaxLength = 6;
            txtCodigoN.Name = "txtCodigoN";
            txtCodigoN.PlaceholderText = "Digite o código recebido";
            txtCodigoN.Size = new Size(457, 27);
            txtCodigoN.TabIndex = 58;
            // 
            // btnEnviarCodigoN
            // 
            btnEnviarCodigoN.BackColor = Color.FromArgb(230, 116, 165);
            btnEnviarCodigoN.FlatAppearance.BorderSize = 0;
            btnEnviarCodigoN.FlatStyle = FlatStyle.Popup;
            btnEnviarCodigoN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnviarCodigoN.ForeColor = Color.White;
            btnEnviarCodigoN.Location = new Point(540, 278);
            btnEnviarCodigoN.Name = "btnEnviarCodigoN";
            btnEnviarCodigoN.Size = new Size(119, 29);
            btnEnviarCodigoN.TabIndex = 59;
            btnEnviarCodigoN.Text = "Enviar Código";
            btnEnviarCodigoN.UseVisualStyleBackColor = false;
            btnEnviarCodigoN.Click += btnEnviarCodigoN_Click;
            // 
            // lblTempoRestanteN
            // 
            lblTempoRestanteN.AutoSize = true;
            lblTempoRestanteN.BackColor = Color.Transparent;
            lblTempoRestanteN.ForeColor = Color.Goldenrod;
            lblTempoRestanteN.Location = new Point(540, 394);
            lblTempoRestanteN.Name = "lblTempoRestanteN";
            lblTempoRestanteN.Size = new Size(0, 20);
            lblTempoRestanteN.TabIndex = 60;
            // 
            // timerEnvio
            // 
            timerEnvio.Interval = 1000;
            timerEnvio.Tick += timerEnvio_Tick;
            // 
            // timerEnvioN
            // 
            timerEnvioN.Tick += timerEnvioN_Tick;
            // 
            // frmAtualizarEmail
            // 
            AcceptButton = btnAtualizar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 254);
            BackgroundImageLayout = ImageLayout.Center;
            CancelButton = btnVoltar;
            ClientSize = new Size(782, 553);
            Controls.Add(lblTempoRestanteN);
            Controls.Add(btnEnviarCodigoN);
            Controls.Add(txtCodigoN);
            Controls.Add(picCoracao);
            Controls.Add(picCodigoN);
            Controls.Add(picEmailN);
            Controls.Add(picCodigo);
            Controls.Add(picEmail);
            Controls.Add(lblRodape);
            Controls.Add(lblTitulo);
            Controls.Add(lblTempoRestante);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(btnVoltar);
            Controls.Add(txtEmailN);
            Controls.Add(btnAtualizar);
            Controls.Add(lblCodigoN);
            Controls.Add(lblEmailN);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(960, 720);
            MinimumSize = new Size(640, 480);
            Name = "frmAtualizarEmail";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAtualizarEmail_Load;
            ((System.ComponentModel.ISupportInitialize)picCoracao).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCodigoN).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmailN).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCoracao;
        private PictureBox picCodigoN;
        private PictureBox picEmailN;
        private PictureBox picCodigo;
        private PictureBox picEmail;
        private Label lblRodape;
        private Label lblTitulo;
        private Label lblTempoRestante;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button btnEnviarCodigo;
        private Button btnVoltar;
        private TextBox txtEmailN;
        private Button btnAtualizar;
        private Label lblCodigoN;
        private Label lblEmailN;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtCodigoN;
        private Button btnEnviarCodigoN;
        private Label lblTempoRestanteN;
        private System.Windows.Forms.Timer timerEnvio;
        private System.Windows.Forms.Timer timerEnvioN;
    }
}