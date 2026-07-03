using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Valquiria
{
    internal class UIHelper
    {
        // Arredondar Bordas
        public static void ArredondarBorda(Control controle, int raio)
        {
            GraphicsPath caminho = new GraphicsPath();
            caminho.StartFigure();
            caminho.AddArc(new Rectangle(0, 0, raio, raio), 180, 90);
            caminho.AddArc(new Rectangle(controle.Width - raio, 0, raio, raio), 270, 90);
            caminho.AddArc(new Rectangle(controle.Width - raio, controle.Height - raio, raio, raio), 0, 90);
            caminho.AddArc(new Rectangle(0, controle.Height - raio, raio, raio), 90, 90);
            caminho.CloseFigure();

            controle.Region = new Region(caminho);
        }
    }
}
