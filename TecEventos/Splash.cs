using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cada vez que o evento Tick é disparado, a largura (Width) do panel2 é aumentada em 3 pixels. Isso faz com que o painel se expanda horizontalmente.
            panel2.Width += 3; 

            // Quando a barra de progresso completar (igualar a largura do painel principal)
            if (panel2.Width >= panel1.Width)
            {
                timer1.Stop(); // Para o timer

                // Exibe o formulário de Login
                Login loginForm = new Login();
                loginForm.Show();

                // Fecha o formulário Splash
                this.Hide(); // Esconde o Splash antes de fechá-lo
                this.Close(); // Fecha o Splash (use Close se ele não for mais necessário


            }
        }
    }
}
