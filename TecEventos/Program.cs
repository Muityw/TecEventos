using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecEventos
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa o formulário Splash
            Splash splash = new Splash();
            Application.Run(splash); // Exibe o formulário Splash

           // Após o Splash, abre o formulário Login
            if (splash != null) // Verifica se o Splash foi fechado corretamente
            {
                Application.Run(new Login());
            }
        }
    }
}
