using System;
using System.Windows.Forms;

namespace TecEventos
{
    // Classe responsável por abrir formulários dentro de um painel específico
    public class AbrirForms
    {
        // Variável que mantém a referência ao formulário atualmente aberto
        private Form formAtivo = null;
        // Painel onde os formulários serão exibidos
        private Panel painel;

        // Construtor da classe, que recebe o painel onde os formulários serão exibidos
        public AbrirForms(Panel painel)
        {
            this.painel = painel;
        }

        // Método que abre um novo formulário dentro do painel especificado
        public void AbreForm(Form novoForm)
        {
            // Se já houver um formulário ativo, ele é fechado
            if (formAtivo != null) formAtivo.Close();

            // O formulário passado como parâmetro é definido como o novo formulário ativo
            formAtivo = novoForm;

            // O novo formulário não será uma janela independente (não terá sua própria barra de título)
            novoForm.TopLevel = false;
            // Remove as bordas do formulário para que ele se ajuste ao painel
            novoForm.FormBorderStyle = FormBorderStyle.None;
            // Faz com que o formulário ocupe todo o espaço do painel
            novoForm.Dock = DockStyle.Fill;

            // Adiciona o novo formulário aos controles do painel
            painel.Controls.Add(novoForm);
            // Atribui o novo formulário como a tag do painel, para facilitar referências futuras
            painel.Tag = novoForm;

            // Traz o formulário para a frente, garantindo que ele seja visível
            novoForm.BringToFront();
            // Exibe o formulário
            novoForm.Show();
        }
    }
}
