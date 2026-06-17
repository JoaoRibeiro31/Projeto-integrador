using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail; // Para envio de e-mail

namespace Projeto_Valquiria
{
    public partial class FrmEsqueciSenha : Form
    {
        // 🔗 String de conexão com o banco
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";

        // Variáveis globais para controle de tempo
        DateTime ultimoEnvio;
        private const int TEMPO_MINIMO_ENVIO = 2; // minutos

        public FrmEsqueciSenha()
        {
            InitializeComponent();
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
                MessageBox.Show("Digite o e-mail cadastrado!", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txtEmail.Text.Trim();

            // Valida formato do e-mail antes de enviar
            try
            {
                var endereco = new MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Formato de e-mail inválido!", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string codigo = new Random().Next(100000, 999999).ToString(); // Código de 6 dígitos
            DateTime validade = DateTime.Now.AddMinutes(10); // Expira em 10 minutos

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    // Verifica se o e-mail existe no banco
                    string sqlCheck = "SELECT COUNT(*) FROM login WHERE email=@email";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@email", email);
                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("E-mail não encontrado no sistema!",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica se já existe um código recente
                    string sqlCheckTime = @"SELECT reset_last_sent FROM login WHERE email=@email";
                    MySqlCommand cmdCheckTime = new MySqlCommand(sqlCheckTime, conn);
                    cmdCheckTime.Parameters.AddWithValue("@email", email);
                    object lastSentObj = cmdCheckTime.ExecuteScalar();

                    if (lastSentObj != DBNull.Value)
                    {
                        DateTime lastSent = Convert.ToDateTime(lastSentObj);
                        if (DateTime.Now < lastSent.AddMinutes(TEMPO_MINIMO_ENVIO))
                        {
                            MessageBox.Show($"Você deve aguardar {TEMPO_MINIMO_ENVIO} minutos antes de solicitar um novo código.",
                                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Atualiza o código e validade no banco
                    string sqlUpdate = @"UPDATE login 
                                         SET reset_code=@codigo, 
                                             reset_expiration=@validade, 
                                             reset_last_sent=@agora 
                                         WHERE email=@email";
                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@codigo", codigo);
                    cmdUpdate.Parameters.AddWithValue("@validade", validade);
                    cmdUpdate.Parameters.AddWithValue("@agora", DateTime.Now);
                    cmdUpdate.Parameters.AddWithValue("@email", email);
                    cmdUpdate.ExecuteNonQuery();

                    // Envia o código por e-mail com mensagem profissional
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("sistemaprojetoval@gmail.com"); // Conta do programa
                    mail.To.Add(email); // Destinatário
                    mail.Subject = "Redefinição de senha - Projeto Valquíria";
                    mail.Body =
$@"Olá,

Recebemos uma solicitação para redefinir sua senha no sistema do aplicativo Valquíria Gomes.
Aqui está o seu código de verificação:

Código: {codigo}
Validade: até {validade:HH:mm} de hoje

Se você não solicitou essa alteração, por favor ignore este e-mail.

Atenciosamente,
Equipe Projeto Valquíria";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential(
                        "sistemaprojetoval@gmail.com",   // Conta criada para o programa
                        "zjnegtnljplmsiya"               // 👉 Senha de aplicativo
                    );
                    smtp.EnableSsl = true;

                    smtp.Send(mail);

                    MessageBox.Show("Código enviado para o e-mail cadastrado!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa o campo de e-mail após envio
                    txtEmail.Clear();

                    // Marca o horário do envio e inicia o Timer
                    ultimoEnvio = DateTime.Now;
                    btnEnviarCodigo.Enabled = false; // desabilita botão
                    timerEnvio.Start();              // inicia contador
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao enviar código: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ---------- EVENTO DO TIMER ----------
        private void timerEnvio_Tick(object sender, EventArgs e)
        {
            TimeSpan restante = (ultimoEnvio.AddMinutes(TEMPO_MINIMO_ENVIO) - DateTime.Now);

            if (restante.TotalSeconds > 0)
            {
                lblTempoRestante.Text = $"Aguarde {restante.Minutes:D2}:{restante.Seconds:D2} para novo envio";
            }
            else
            {
                lblTempoRestante.Text = "Pronto para enviar";
                btnEnviarCodigo.Enabled = true; // reabilita botão
                timerEnvio.Stop();              // para contador
            }
        }

        // ---------- ATUALIZAR LOGIN E SENHA ----------
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtNovaSenha.Text))
            {
                MessageBox.Show("Preencha código, login e nova senha!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txtEmail.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string usuario = txtLogin.Text.Trim();
            string senha = txtNovaSenha.Text.Trim();

            if (senha.Length < 8 || senha.Length > 10)
            {
                MessageBox.Show("A senha deve ter entre 8 e 10 caracteres!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Código inválido ou expirado!",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sqlUpdate = @"UPDATE login 
                                         SET usuario=@usuario, senha=@senha, 
                                             reset_code=NULL, reset_expiration=NULL 
                                         WHERE email=@email";
                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@usuario", usuario);
                    cmdUpdate.Parameters.AddWithValue("@senha", senhaHash);
                    cmdUpdate.Parameters.AddWithValue("@email", email);
                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Login e senha atualizados com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ---------- VOLTAR ----------
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
