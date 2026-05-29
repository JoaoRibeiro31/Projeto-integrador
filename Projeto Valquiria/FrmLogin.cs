using System.Security.Cryptography;
using System.Text;

using MySql.Data.MySqlClient; //Pacote do MySQL


namespace Projeto_Valquiria
{
    public partial class pnlConteudo : Form
    {
        MySqlConnection Conexao;
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";



        public pnlConteudo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();

                string sql = @"SELECT COUNT(*) FROM login
                              WHERE usuario=@usuario AND senha=@senha";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@usuario", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Login realizado!");

                    panelConteudo home = new panelConteudo();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }

                conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAtualizarLogin tela = new FrmAtualizarLogin();
            tela.ShowDialog();
        }
    }
}
