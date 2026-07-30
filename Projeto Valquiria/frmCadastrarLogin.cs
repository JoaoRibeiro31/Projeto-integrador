using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

namespace Projeto_Valquiria
{
    public partial class frmCadastrarLogin : Form
    {
        public frmCadastrarLogin()
        {
            InitializeComponent();
        }

        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        DateTime ultimoEnvio;
        private const int TEMPO_MINIMO_ENVIO = 2; // minutos


        // ---------- LOAD ----------
        private void frmCadastrarLogin_Load(object sender, EventArgs e)
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
            UIHelper.ArredondarBorda(this, 40);
            UIHelper.ArredondarBorda(btnCadastrar, 40);
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

                    // Gera código
                    string codigo = new Random().Next(100000, 999999).ToString();
                    DateTime validade = DateTime.Now.AddMinutes(10);

                    // Salva apenas código e validade (sem cadastrar email definitivo)
                    string sqlInsert = @"INSERT INTO cadastro_temp (email, reset_code, reset_expiration, reset_last_sent)
                                 VALUES (@email, @codigo, @validade, @agora)";
                    MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn);
                    cmdInsert.Parameters.AddWithValue("@email", email);
                    cmdInsert.Parameters.AddWithValue("@codigo", codigo);   
                    cmdInsert.Parameters.AddWithValue("@validade", validade);
                    cmdInsert.Parameters.AddWithValue("@agora", DateTime.Now);
                    cmdInsert.ExecuteNonQuery();

                    // Configura e-mail
                    string emailUser = ConfigurationManager.AppSettings["EmailUser"];
                    string emailPass = ConfigurationManager.AppSettings["EmailPassword"];

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(emailUser);
                    mail.To.Add(email);
                    mail.Subject = "Confirmação de cadastro - Projeto Valquíria";
                    mail.Body = $@"Olá,

Recebemos uma solicitação de cadastro no sistema Valquíria Gomes.
Aqui está o seu código de verificação:

Código: {codigo}
Esse código expira em 10 minutos.

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
                    ErroHelper.MostrarSucesso("Código enviado para o e-mail informado!");
                }
                catch (Exception ex)
                {
                    ErroHelper.MostrarErro("Erro", "Ocorreu um problema ao enviar o código.");
                    ErroHelper.LogErro(ex);
                }
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

        // ---------- CADASTRAR LOGIN ----------
        private void btnCadastrar_Click(object sender, EventArgs e)
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

                    // Verifica se o código é válido na tabela temporária
                    string sqlCheck = @"SELECT COUNT(*) FROM cadastro_temp 
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

                    // Insere usuário definitivo na tabela login
                    string sqlInsertLogin = @"INSERT INTO login (usuario, senha, email) 
                                      VALUES (@usuario, @senha, @email)";
                    MySqlCommand cmdInsertLogin = new MySqlCommand(sqlInsertLogin, conn);
                    cmdInsertLogin.Parameters.AddWithValue("@usuario", usuario);
                    cmdInsertLogin.Parameters.AddWithValue("@senha", senhaHash);
                    cmdInsertLogin.Parameters.AddWithValue("@email", email);
                    cmdInsertLogin.ExecuteNonQuery();

                    // Remove registro temporário
                    string sqlDeleteTemp = @"DELETE FROM cadastro_temp WHERE email=@email";
                    MySqlCommand cmdDeleteTemp = new MySqlCommand(sqlDeleteTemp, conn);
                    cmdDeleteTemp.Parameters.AddWithValue("@email", email);
                    cmdDeleteTemp.ExecuteNonQuery();

                    ErroHelper.MostrarSucesso("Cadastro realizado com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    ErroHelper.MostrarErro("Erro", "Ocorreu um problema ao cadastrar.");
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
