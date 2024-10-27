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
    public partial class Home : Form
    {
        private AbrirForms abrirForms; //Chamar a classe de ABRIR FORMS
        private int usuarioId;
        public Home(int usuarioId)
        {
            InitializeComponent();
            abrirForms = new AbrirForms(PanelHome); // Passa o painel para a classe AbrirForms
            this.usuarioId = usuarioId;
            

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            using (var confirmExit = new Saida(usuarioId)) // Passa o usuarioId para o formulário Saida
            {
                var result = confirmExit.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    Application.Exit(); // Fecha a aplicação
                }
            }
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new ListaChacaras());
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new AdicionarChacara());
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new AgendarAlugueis());
        }

        private void btnDisponibilidade_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new Disponibilidade());
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new Agendamento());
        }

        private void btnPerfilAdm_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new PerfilAdm());
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new CadastrarClientes());
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new Pagamentos());
        }

        private void btnDatasComemorativas_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new DatasComemorativas());
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new Alterar());
        }

        private void btnPrecificacao_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new Precificacao());
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            abrirForms.AbreForm(new Contrato());
        }
    }
}
