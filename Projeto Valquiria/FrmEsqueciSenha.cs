using MySql.Data.MySqlClient;
using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Drawing2D;

namespace Projeto_Valquiria
{
    public partial class FrmEsqueciSenha : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        DateTime ultimoEnvio;
        private const int TEMPO_MINIMO_ENVIO = 2; // minutos

        public FrmEsqueciSenha()
        {
            InitializeComponent();
        }

        // ---------- LOAD ----------
        private void FrmEsqueciSenha_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open(); // tenta abrir a conexão
                }
            }
            catch (MySqlException ex)
            {
                ErroHelper.MostrarErro("Erro de Conexão", "Não foi possível conectar ao banco de dados.");
                ErroHelper.LogErro(ex);
                this.Close();
            }

            // 🔒 Esconde caracteres da senha
            txtNovaSenha.UseSystemPasswordChar = true;

            // Borda arredondada
            int borda = 40; 
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, borda, borda), 180, 90);
            path.AddArc(new Rectangle(this.Width - borda, 0, borda, borda), 270, 90);
            path.AddArc(new Rectangle(this.Width - borda, this.Height - borda, borda, borda), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - borda, borda, borda), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        // ---------- GERAR HASH ----------
        private string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        // ---------- ENVIAR CÓDIGO ----------
        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Khaki;
                txtEmail.Enter += (s, ev) => txtEmail.BackColor = Color.White;
                ErroHelper.MostrarAviso("O campo 'E-mail' precisa ser preenchido.");
                return;
            }

            string email = txtEmail.Text.Trim();

            try { var endereco = new MailAddress(email); }
            catch
            {
                txtEmail.BackColor = Color.Khaki;
                txtEmail.Enter += (s, ev) => txtEmail.BackColor = Color.White;
                ErroHelper.MostrarErro("Erro de E-mail", "Formato inválido. Digite um endereço válido.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    // Verifica se o e-mail existe
                    string sqlCheck = "SELECT COUNT(*) FROM login WHERE email=@email";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@email", email);
                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        txtEmail.BackColor = Color.Khaki;
                        txtEmail.Enter += (s, ev) => txtEmail.BackColor = Color.White;
                        ErroHelper.MostrarAviso("E-mail não encontrado no sistema.");
                        return;
                    }

                    // Verifica tempo mínimo
                    string sqlTempo = "SELECT reset_last_sent FROM login WHERE email=@email";
                    MySqlCommand cmdTempo = new MySqlCommand(sqlTempo, conn);
                    cmdTempo.Parameters.AddWithValue("@email", email);
                    object lastSentObj = cmdTempo.ExecuteScalar();

                    if (lastSentObj != DBNull.Value)
                    {
                        DateTime lastSent = Convert.ToDateTime(lastSentObj);
                        TimeSpan diff = DateTime.Now - lastSent;

                        if (diff.TotalMinutes < TEMPO_MINIMO_ENVIO)
                        {
                            int restante = (int)(TEMPO_MINIMO_ENVIO * 60 - diff.TotalSeconds);
                            lblTempoRestante.Text = $"Aguarde {restante / 60:D2}:{restante % 60:D2} para novo envio";
                            ErroHelper.MostrarAviso("Você precisa esperar antes de enviar outro código.");
                            ultimoEnvio = lastSent;
                            btnEnviarCodigo.Enabled = false;
                            timerEnvio.Start();
                            return;
                        }
                    }

                    // Gera código
                    string codigo = new Random().Next(100000, 999999).ToString();
                    DateTime validade = DateTime.Now.AddMinutes(10);

                    // Atualiza no banco
                    string sqlUpdate = @"UPDATE login 
                                         SET reset_code=@codigo, reset_expiration=@validade, reset_last_sent=@agora 
                                         WHERE email=@email";
                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@codigo", codigo);
                    cmdUpdate.Parameters.AddWithValue("@validade", validade);
                    cmdUpdate.Parameters.AddWithValue("@agora", DateTime.Now);
                    cmdUpdate.Parameters.AddWithValue("@email", email);
                    cmdUpdate.ExecuteNonQuery();

                    // Configura e-mail
                    string emailUser = ConfigurationManager.AppSettings["EmailUser"];
                    string emailPass = ConfigurationManager.AppSettings["EmailPassword"];

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(emailUser);
                    mail.To.Add(email);
                    mail.Subject = "Redefinição de senha - Projeto Valquíria";
                    mail.Body = $@"Olá,

Recebemos uma solicitação para redefinir sua senha no sistema do aplicativo Valquíria Gomes.
Aqui está o seu código de verificação:

Código: {codigo}
Esse código irá expirar em 10 minutos.

Se você não deseja redefinir sua senha, apenas ignore esta mensagem.

Atenciosamente,
Equipe Projeto Valquíria";


                    SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new System.Net.NetworkCredential(emailUser, emailPass),
                        EnableSsl = true,
                        Timeout = 20000
                    };

                    ultimoEnvio = DateTime.Now;
                    btnEnviarCodigo.Enabled = false;
                    timerEnvio.Start();

                    smtp.Send(mail);
                    ErroHelper.MostrarSucesso("Código enviado para o e-mail cadastrado!");
                }
                catch (MySqlException ex) { ErroHelper.MostrarErro("Erro MySQL", "Problema ao acessar o banco."); ErroHelper.LogErro(ex); }
                catch (SmtpException ex) { ErroHelper.MostrarErro("Erro SMTP", "Problema ao enviar e-mail."); ErroHelper.LogErro(ex); }
                catch (Exception ex) { ErroHelper.MostrarErro("Erro inesperado", "Ocorreu um problema."); ErroHelper.LogErro(ex); }
            }
        }

        // ---------- TIMER ----------
        private void timerEnvio_Tick(object sender, EventArgs e)
        {
            TimeSpan restante = (ultimoEnvio.AddMinutes(TEMPO_MINIMO_ENVIO) - DateTime.Now);
            if (restante.TotalSeconds > 0)
                lblTempoRestante.Text = $"Aguarde {restante.Minutes:D2}:{restante.Seconds:D2} para novo envio";
            else
            {
                lblTempoRestante.Text = "Pronto para enviar";
                btnEnviarCodigo.Enabled = true;
                timerEnvio.Stop();
            }
        }
        // ---------- ATUALIZAR LOGIN ----------
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            List<TextBox> camposFaltando = new List<TextBox>();
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) camposFaltando.Add(txtEmail);
            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) camposFaltando.Add(txtCodigo);
            if (string.IsNullOrWhiteSpace(txtLogin.Text)) camposFaltando.Add(txtLogin);
            if (string.IsNullOrWhiteSpace(txtNovaSenha.Text)) camposFaltando.Add(txtNovaSenha);

            if (camposFaltando.Count > 0)
            {
                foreach (var campo in camposFaltando)
                {
                    campo.BackColor = Color.Khaki;
                    campo.Enter += (s, ev) => campo.BackColor = Color.White;
                }
                ErroHelper.MostrarAviso("Preencha todos os campos obrigatórios.");
                return;
            }

            string email = txtEmail.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string usuario = txtLogin.Text.Trim();
            string senha = txtNovaSenha.Text.Trim();

            if (senha.Length < 8 || senha.Length > 10)
            {
                txtNovaSenha.BackColor = Color.Khaki;
                txtNovaSenha.Enter += (s, ev) => txtNovaSenha.BackColor = Color.White;
                ErroHelper.MostrarAviso("A senha deve ter entre 8 e 10 caracteres.");
                return;
            }

            string senhaHash = GerarHash(senha);

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sqlCheck = @"SELECT COUNT(*) FROM login 
                                        WHERE email=@email AND reset_code=@codigo 
                                        AND reset_expiration > NOW()";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@email", email);
                    cmdCheck.Parameters.AddWithValue("@codigo", codigo);
                    int valido = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (valido == 0)
                    {
                        ErroHelper.MostrarAviso("O código informado é inválido ou já expirou.");
                        return;
                    }

                    string sqlUpdate = @"UPDATE login 
                                         SET usuario=@usuario, senha=@senha, 
                                             reset_code=NULL, reset_expiration=NULL 
                                         WHERE email=@email AND reset_code=@codigo";
                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@usuario", usuario);
                    cmdUpdate.Parameters.AddWithValue("@senha", senhaHash);
                    cmdUpdate.Parameters.AddWithValue("@email", email);
                    cmdUpdate.Parameters.AddWithValue("@codigo", codigo);
                    cmdUpdate.ExecuteNonQuery();

                    ErroHelper.MostrarSucesso("Login e senha atualizados com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    ErroHelper.MostrarErro("Erro", "Ocorreu um problema ao atualizar os dados.");
                    ErroHelper.LogErro(ex);
                }
            }
        }

        // ---------- VOLTAR ----------
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ---------- MOSTRAR SENHA ----------
        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.UseSystemPasswordChar)
            {
                txtNovaSenha.UseSystemPasswordChar = false;
                btnMostrarSenha.Image = Properties.Resources.olhoaberto;
            }
            else
            {
                txtNovaSenha.UseSystemPasswordChar = true;
                btnMostrarSenha.Image = Properties.Resources.olhofechado;
            }
        }
    }
}
