using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Valquiria
{
    public partial class FrmAtualizarLogin : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";

        public FrmAtualizarLogin()
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

        // ---------- ATUALIZAR LOGIN ----------
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // 🚫 Verificação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtCPF.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de atualizar!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔒 CPF - só números
            string cpf = Regex.Replace(txtCPF.Text, "[^0-9]", "");
            if (cpf.Length != 11)
            {
                MessageBox.Show("Digite um CPF válido com 11 dígitos!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔒 Usuário
            string usuario = txtUsuario.Text.Trim();
            if (usuario.Length < 2 || usuario.Length > 50)
            {
                MessageBox.Show("O usuário deve ter entre 2 e 50 caracteres!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔒 Senha (mínimo 8, máximo 10)
            string senha = txtSenha.Text.Trim();
            if (senha.Length < 8 || senha.Length > 10)
            {
                MessageBox.Show("A senha deve ter entre 8 e 10 caracteres!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔑 Gera hash da senha
            string senhaHash = GerarHash(senha);

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    // Verifica se CPF existe
                    string sqlCheck = "SELECT COUNT(*) FROM login WHERE cpf = @cpf";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@cpf", cpf);
                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("CPF não encontrado no sistema!",
                                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Atualiza usuário e senha (em hash)
                    string sqlUpdate = @"UPDATE login 
                                         SET usuario = @usuario, senha = @senha 
                                         WHERE cpf = @cpf";

                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@usuario", usuario);
                    cmdUpdate.Parameters.AddWithValue("@senha", senhaHash);
                    cmdUpdate.Parameters.AddWithValue("@cpf", cpf);

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a tela
        }

        private void FrmAtualizarLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
