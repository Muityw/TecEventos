using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    // Classe que gerencia as informações de um agendamento
    internal class GetSetAgendamento
    {
        // Campos privados que armazenam as informações do agendamento
        private string entrada_data;
        private string saida_data;
        private int usuario_id;
        private int chacara_id;
        private double valor_agendamento;

        // Enumeração interna para representar o status do agendamento
        private enum status
        {
            Confirmada,
            Pendente,
            Cancelada,
        }

        // Construtor da classe, inicializando os campos com valores padrão
        public GetSetAgendamento()
        {
            entrada_data = "";
            saida_data = "";
            usuario_id = 0;
            chacara_id = 0;
            valor_agendamento = 0.0;
        }

        // Método para definir as informações do agendamento
        public void setInfoAgendamento(string entrada_data, string saida_data, int usuario_id, int chacara_id, double valor_agendamento)
        {
            // Atribui os valores passados como parâmetros aos campos privados
            this.entrada_data = entrada_data;
            this.saida_data = saida_data;
            this.usuario_id = usuario_id;
            this.chacara_id = chacara_id;
            this.valor_agendamento = valor_agendamento;
        }

        // Métodos para obter as informações do agendamento

        // Retorna a data de entrada do agendamento
        public string getEntradaData()
        {
            return entrada_data;
        }

        // Retorna a data de saída do agendamento
        public string getSaidaData()
        {
            return saida_data;
        }

        // Retorna o ID do usuário associado ao agendamento
        public int getUsuarioID()
        {
            return usuario_id;
        }

        // Retorna o ID da chácara associada ao agendamento
        public int getChacaraID()
        {
            return chacara_id;
        }

        // Retorna o valor do agendamento
        public double getValorAgendamento()
        {
            return valor_agendamento;
        }
    }
}
