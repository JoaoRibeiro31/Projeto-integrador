using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class frmLogin : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // 🔒 Esconde caracteres da senha
            txtSenha.UseSystemPasswordChar = true;
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

        // ---------- LOGIN ----------
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // 🚫 1. Verificação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha login e senha!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método se não tiver login ou senha
            }

            // 2. Cria conexão com o banco
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open(); // Abre a conexão

                    // 3. SQL com BINARY → comparação case-sensitive
                    string sql = @"SELECT COUNT(*) FROM login
                           WHERE BINARY usuario=@usuario AND senha=@senha";

                    // 4. Cria comando SQL
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    // 5. Adiciona parâmetros
                    // Trim() remove espaços no começo e fim
                    cmd.Parameters.AddWithValue("@usuario", txtLogin.Text.Trim());
                    cmd.Parameters.AddWithValue("@senha", GerarHash(txtSenha.Text.Trim()));

                    // 6. Executa a consulta e pega o resultado
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // 7. Verifica se encontrou usuário válido
                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abre a tela principal
                        frmHome home = new frmHome();
                        home.Show();
                        this.Hide(); // Esconde a tela de login
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    // 8. Tratamento de erro
                    MessageBox.Show("Erro ao realizar login: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // ---------- ESQUECI A SENHA ----------
        private void btnEsqueci_Click(object sender, EventArgs e)
        {
            FrmAtualizarLogin tela = new FrmAtualizarLogin();
            tela.ShowDialog();
        }

        // ---------- MOSTRAR SENHA ----------
        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                btnMostrarSenha.Image = Properties.Resources.olhoaberto;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                btnMostrarSenha.Image = Properties.Resources.olhofechado; 
            }
        }
    }
}

