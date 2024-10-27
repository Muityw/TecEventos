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
    public partial class Pagamentos : Form
    {
        private AbrirForms abrirForms; //Chamar a classe de ABRIR FORMS
        public Pagamentos()
        {
            InitializeComponent();
            abrirForms = new AbrirForms(panel2);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void BtnCriarPag_Click_1(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new ControlePagamentos());
        }

        private void btnVisuPag_Click_1(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new VisualizacaoPag());
        }
    }
}
