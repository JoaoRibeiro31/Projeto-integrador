using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Valquiria
{
    public partial class frmAtualizarEmail : Form
    {
        string conexao = "Server=localhost;Database=bd_pjval;Uid=root;Pwd=;";
        DateTime ultimoEnvio;
        private const int TEMPO_MINIMO_ENVIO = 2;

        public frmAtualizarEmail()
        {
            InitializeComponent();
        }

        private void frmAtualizarEmail_Load(object sender, EventArgs e)
        {
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

            UIHelper.ArredondarBorda(this,40);
            UIHelper.ArredondarBorda(btnAtualizar,40);
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarCodigoN_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }








        // ---------- VOLTAR ----------
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
