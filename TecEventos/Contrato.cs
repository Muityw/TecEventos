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
    public partial class Contrato : Form
    {
        private AbrirForms abrirForms; //Chamar a classe de ABRIR FORMS
        public Contrato()
        {
            InitializeComponent();
            abrirForms = new AbrirForms(panel2);
        }

        private void BtnCriarPag_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new ContratoCriar());
        }

        private void btnVisuPag_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new ContratoVisu());
        }
    }
}
