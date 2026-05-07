using System.Security.Cryptography;
using System.Text;

using MySql.Data.MySqlClient; //Pacote do MySQL


namespace Projeto_Valquiria
{
    public partial class Login : Form
    {
        MySqlConnection Conexao; //Conexão (NÃO MEXA)

        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";

            MySqlConnection conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();

                string sql =
                "SELECT COUNT(*) FROM login " +
                "WHERE usuario=@usuario AND senha=@senha";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@usuario", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Login realizado!");

                    Home home = new Home();
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

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
