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
            // Verifica se o campo de e-mail está vazio
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.Khaki; // destaque amarelo escuro
                txtEmail.Enter += (s, ev) => txtEmail.BackColor = Color.White; // remove ao selecionar

                MessageBox.Show("O campo 'E-mail' precisa ser preenchido.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txtEmail.BackColor = Color.Khaki; // destaca campo inválido
                txtEmail.Enter += (s, ev) => txtEmail.BackColor = Color.White;

                MessageBox.Show("Formato de e-mail inválido. Digite um endereço válido.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        txtEmail.BackColor = Color.Khaki; // destaca campo inexistente
                        txtEmail.Enter += (s, ev) => txtEmail.BackColor = Color.White;

                        MessageBox.Show("E-mail não encontrado no sistema.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Gera código somente após confirmar que o e-mail existe
                    string codigo = new Random().Next(100000, 999999).ToString(); // Código de 6 dígitos
                    DateTime validade = DateTime.Now.AddMinutes(10); // Expira em 10 minutos

                    // Atualiza o código e validade no banco
                    string sqlUpdate = @"UPDATE login 
                                 SET reset_code       = @codigo, 
                                     reset_expiration = @validade, 
                                     reset_last_sent  = @agora 
                                 WHERE email = @email";

                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@codigo", codigo);
                    cmdUpdate.Parameters.AddWithValue("@validade", validade);
                    cmdUpdate.Parameters.AddWithValue("@agora", DateTime.Now);
                    cmdUpdate.Parameters.AddWithValue("@email", email);
                    cmdUpdate.ExecuteNonQuery();

                    // Envia o código por e-mail
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("sistemaprojetoval@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Redefinição de senha - Projeto Valquíria";
                    mail.Body =
        $@"Olá,

Recebemos uma solicitação para redefinir sua senha no sistema do aplicativo Valquíria Gomes.
Aqui está o seu código de verificação:

Código: {codigo}
Esse código irá expirar em 10 minutos.

Se você não deseja redefinir sua senha, apenas ignore esta mensagem.

Atenciosamente,
Equipe Projeto Valquíria";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential(
                        "sistemaprojetoval@gmail.com",
                        "zjnegtnljplmsiya" // senha de aplicativo
                    );
                    smtp.EnableSsl = true;

                    smtp.Send(mail);

                    MessageBox.Show("Código enviado para o e-mail cadastrado!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Marca o horário do envio e inicia o Timer
                    ultimoEnvio = DateTime.Now;
                    btnEnviarCodigo.Enabled = false;
                    timerEnvio.Start();
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
            // Lista para armazenar os campos que não foram preenchidos
            List<TextBox> camposFaltando = new List<TextBox>();

            // Verifica cada campo e adiciona à lista se estiver vazio
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                camposFaltando.Add(txtEmail);

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                camposFaltando.Add(txtCodigo);

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
                camposFaltando.Add(txtLogin);

            if (string.IsNullOrWhiteSpace(txtNovaSenha.Text))
                camposFaltando.Add(txtNovaSenha);

            // Se houver campos faltando, aplica destaque visual e mostra mensagem clara
            if (camposFaltando.Count > 0)
            {
                foreach (var campo in camposFaltando)
                {
                    campo.BackColor = Color.Khaki; // amarelo mais escuro para chamar atenção
                    campo.Enter += (s, ev) => campo.BackColor = Color.White; // remove destaque ao selecionar
                }

                // Monta mensagem listando todos os campos faltando
                string mensagem = "Os seguintes campos precisam ser preenchidos:\n- "
                                  + string.Join("\n- ", camposFaltando.Select(c => c.Name.Replace("txt", "")));
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // interrompe execução até que os campos sejam preenchidos
            }

            // Captura valores dos campos já validados
            string email = txtEmail.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string usuario = txtLogin.Text.Trim();
            string senha = txtNovaSenha.Text.Trim();

            // Validação da senha: tamanho mínimo e máximo
            if (senha.Length < 8 || senha.Length > 10)
            {
                txtNovaSenha.BackColor = Color.Khaki; // destaca campo inválido
                txtNovaSenha.Enter += (s, ev) => txtNovaSenha.BackColor = Color.White;

                MessageBox.Show("A senha deve ter entre 8 e 10 caracteres.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gera hash da senha para salvar no banco de forma segura
            string senhaHash = GerarHash(senha);

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    // Verifica se o código informado é válido para o e-mail e ainda não expirou
                    string sqlCheck = @"SELECT COUNT(*) FROM login 
                                WHERE email=@email 
                                AND reset_code=@codigo 
                                AND reset_expiration > NOW()";

                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@email", email);
                    cmdCheck.Parameters.AddWithValue("@codigo", codigo);
                    int valido = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (valido == 0)
                    {
                        MessageBox.Show("O código informado é inválido ou já expirou.",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Atualiza login e senha no banco, limpando código e validade
                    string sqlUpdate = @"UPDATE login 
                                 SET usuario=@usuario, 
                                     senha=@senha, 
                                     reset_code=NULL, 
                                     reset_expiration=NULL 
                                 WHERE email=@email AND reset_code=@codigo";

                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@usuario", usuario);
                    cmdUpdate.Parameters.AddWithValue("@senha", senhaHash);
                    cmdUpdate.Parameters.AddWithValue("@email", email);
                    cmdUpdate.Parameters.AddWithValue("@codigo", codigo);
                    cmdUpdate.ExecuteNonQuery();

                    // Confirmação para o usuário
                    MessageBox.Show("Login e senha atualizados com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // fecha a janela após sucesso
                }
                catch (Exception erro)
                {
                    // Tratamento de erro genérico com mensagem clara
                    MessageBox.Show("Ocorreu um erro ao atualizar os dados: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        // ---------- VOLTAR ----------
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {

        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {

        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {

        }
    }
}
