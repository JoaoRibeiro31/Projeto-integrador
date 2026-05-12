using System.Security.Cryptography;
using System.Text;

using MySql.Data.MySqlClient; //Pacote do MySQL


namespace Projeto_Valquiria
{
    public partial class pnlConteudo : Form
    {
        MySqlConnection Conexao; //Conexão (NÃO MEXA)

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

            string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";  //Conexão do Frm com o Banco local

            MySqlConnection conn = new MySqlConnection(conexao);

            try //Thy catch para garantir que não vai dar merda
            {
                conn.Open(); //Abrindo o Banco

                string sql =
                "SELECT COUNT(*) FROM login " +
                "WHERE usuario=@usuario AND senha=@senha"; //Converdando com o Banco

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@usuario", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);    //Comparando as informações do banco com as do Fmd, se tiver certo, volta um valor >0

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

                conn.Close(); //Fechando o Banco
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

    }
}
