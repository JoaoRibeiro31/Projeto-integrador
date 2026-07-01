using System;
using System.IO;
using System.Windows.Forms;

namespace Projeto_Valquiria
{
    public static class ErroHelper
    {
        // Mostra mensagem amigável de erro
        public static void MostrarErro(string titulo, string mensagem)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Mostra mensagem de aviso
        public static void MostrarAviso(string mensagem)
        {
            MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Mostra mensagem de sucesso
        public static void MostrarSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Registra detalhes técnicos em log (arquivo .txt)
        public static void LogErro(Exception ex)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "erros.log");
            string conteudo = $"[{DateTime.Now}] {ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}\n";
            File.AppendAllText(caminho, conteudo);
        }
    }
}
