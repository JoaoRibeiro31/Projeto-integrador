using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Valquiria
{
    public partial class frmAtualizarEmail : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        DateTime ultimoEnvio;
        private const int TEMPO_MINIMO_ENVIO = 2;

        public frmAtualizarEmail()
        {
            InitializeComponent();
        }

        private void frmAtualizarEmail_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                }
            }
            catch (MySqlException ex)
            {
                ErroHelper.MostrarErro("Erro de Conexão", "Não foi possível conectar ao banco de dados.");
                ErroHelper.LogErro(ex);
                this.Close();
            }

            UIHelper.ArredondarBorda(this, 40);
            UIHelper.ArredondarBorda(btnAtualizar, 40);
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
                    string sqlTempo = "SELECT reset_last_sent FROM cadastro_temp WHERE email=@email";
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
                    string sqlUpdate = @"UPDATE cadastro_temp 
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
                    mail.Subject = "atualização de Email - Projeto Valquíria";
                    mail.Body = $@"Olá,

Recebemos uma solicitação para trocar o email atual no sistema do aplicativo Valquíria Gomes.
Aqui está o seu código de verificação:

Código: {codigo}
Esse código irá expirar em 10 minutos.

Se você não deseja atualizar o seu email, apenas ignore esta mensagem.

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
                    ErroHelper.MostrarSucesso("Código enviado para o e-mail atual!");
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

        // ---------- ENVIAR CÓDIGO PARA O NOVO EMAIL----------
        private void btnEnviarCodigoN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailN.Text))
            {
                txtEmailN.BackColor = Color.Khaki;
                txtEmailN.Enter += (s, ev) => txtEmailN.BackColor = Color.White;
                ErroHelper.MostrarAviso("O campo 'E-mail' precisa ser preenchido.");
                return;
            }

            string email = txtEmailN.Text.Trim();

            try { var endereco = new MailAddress(email); }
            catch
            {
                txtEmailN.BackColor = Color.Khaki;
                txtEmailN.Enter += (s, ev) => txtEmailN.BackColor = Color.White;
                ErroHelper.MostrarErro("Erro de E-mail", "Formato inválido. Digite um endereço válido.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    // Verifica tempo mínimo
                    string sqlTempo = "SELECT reset_last_sent FROM cadastro_tempN WHERE email=@email";
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
                    mail.Subject = "atualização de Email - Projeto Valquíria";
                    mail.Body = $@"Olá,

Recebemos uma solicitação para trocar o email atual no sistema do aplicativo Valquíria Gomes.
Aqui está o seu código de verificação:

Código: {codigo}
Esse código irá expirar em 10 minutos.

Se você não deseja atualizar o seu email, apenas ignore esta mensagem.

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
                    ErroHelper.MostrarSucesso("Código enviado para o e-mail atual!");
                }
                catch (MySqlException ex) { ErroHelper.MostrarErro("Erro MySQL", "Problema ao acessar o banco."); ErroHelper.LogErro(ex); }
                catch (SmtpException ex) { ErroHelper.MostrarErro("Erro SMTP", "Problema ao enviar e-mail."); ErroHelper.LogErro(ex); }
                catch (Exception ex) { ErroHelper.MostrarErro("Erro inesperado", "Ocorreu um problema."); ErroHelper.LogErro(ex); }
            }
        }

        // ---------- TIMER ----------
        private void timerEnvioN_Tick(object sender, EventArgs e)
        {
            TimeSpan restante = (ultimoEnvio.AddMinutes(TEMPO_MINIMO_ENVIO) - DateTime.Now);
            if (restante.TotalSeconds > 0)
                lblTempoRestanteN.Text = $"Aguarde {restante.Minutes:D2}:{restante.Seconds:D2} para novo envio";
            else
            {
                lblTempoRestanteN.Text = "Pronto para enviar";
                btnEnviarCodigoN.Enabled = true;
                timerEnvioN.Stop();
            }
        }

        // ---------- ATUALIZAR LOGIN ----------
        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }








        // ---------- VOLTAR ----------
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
