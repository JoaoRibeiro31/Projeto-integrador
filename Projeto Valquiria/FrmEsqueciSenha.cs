using MySql.Data.MySqlClient;
using System;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Trata o CPF para ficar só números
            string cpf = Regex.Replace(txtCPF.Text, "[^0-9]", "");
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Validação da senha
            if (senha.Length < 8 || senha.Length > 10)
            {
                MessageBox.Show("A senha deve ter entre 8 e 10 caracteres, apenas letras e números!");
                return;
            }

            // Mensagem de confirmação
            DialogResult confirmacao = MessageBox.Show(
                $"Confirma atualizar o login e senha para o CPF {cpf}?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacao == DialogResult.No)
            {
                return; // usuário cancelou
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    // Verifica se o CPF existe
                    string sqlCheck = "SELECT COUNT(*) FROM login WHERE cpf = @cpf";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@cpf", cpf);
                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("CPF não encontrado no sistema!");
                        return;
                    }

                    // Atualiza login e senha
                    string sqlUpdate = @"UPDATE login 
                                 SET usuario = @usuario, senha = @senha 
                                 WHERE cpf = @cpf";

                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@usuario", usuario);
                    cmdUpdate.Parameters.AddWithValue("@senha", senha);
                    cmdUpdate.Parameters.AddWithValue("@cpf", cpf);

                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Login e senha atualizados com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                finally
                {
                    conn.Close();
                }
                this.Close(); //Fecha a tela após a atualização
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha a tela
        }
    }
}