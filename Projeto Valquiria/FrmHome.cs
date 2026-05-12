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
    public partial class panelConteudo : Form
    {
        public panelConteudo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPedidos tela = new FrmPedidos();
            tela.ShowDialog();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmProdutos tela = new FrmProdutos();
            tela.ShowDialog();
            this.Hide();
        }
    }
}
