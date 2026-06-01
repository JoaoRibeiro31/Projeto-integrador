using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Valquiria
{
    public partial class pnlConteudo : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";

        public pnlConteudo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // 🔒 Esconde caracteres da senha
            txtSenha.PasswordChar = '*';
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
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha login e senha!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT COUNT(*) FROM login
                                   WHERE usuario=@usuario AND senha=@senha";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@usuario", txtLogin.Text.Trim());
                    cmd.Parameters.AddWithValue("@senha", GerarHash(txtSenha.Text.Trim()));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!",
                                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        panelConteudo home = new panelConteudo();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao realizar login: " + erro.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ---------- ESQUECI A SENHA ----------
        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            FrmAtualizarLogin tela = new FrmAtualizarLogin();
            tela.ShowDialog();
        }


        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            // opcional: validação dinâmica
        }
    }
}

