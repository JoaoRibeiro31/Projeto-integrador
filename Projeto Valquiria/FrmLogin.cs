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

        // ---------- LOAD ----------
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Testa a conexão do banco
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

            // Esconde caracteres da senha
            txtSenha.UseSystemPasswordChar = true;

            // Borda arredondada
            UIHelper.ArredondarBorda(btnEntrar, 40);
            UIHelper.ArredondarBorda(tlpLogin, 40);
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
            // 🚫 Verificação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtSenha.Text) && string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Preencha os campos de Login e senha!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
               
            }
            else if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Preencha o campo login!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);        
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
            
                MessageBox.Show("Preencha o campo senha!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

                // Cria conexão com o banco
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    try
                    {
                        conn.Open(); 

                        // SQL com BINARY → comparação case-sensitive (Só vai comparar exatamente o campo de login)
                        string sql = @"SELECT COUNT(*) FROM login
                           WHERE BINARY usuario=@usuario AND senha=@senha";

                        // Cria comando SQL
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@usuario", txtLogin.Text.Trim());
                        cmd.Parameters.AddWithValue("@senha", GerarHash(txtSenha.Text.Trim()));

                        //  Executa a consulta e pega o resultado
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        //  Verifica se encontrou usuário válido
                        if (count > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!",
                                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abre a tela principal
                            FrmHome home = new FrmHome();
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
                        // Tratamento de erro
                        MessageBox.Show("Erro ao realizar login: " + erro.Message,
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }


        // ---------- ESQUECI A SENHA ----------
        private void btnEsqueci_Click(object sender, EventArgs e)
        {
            FrmEsqueciSenha tela = new FrmEsqueciSenha();
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

