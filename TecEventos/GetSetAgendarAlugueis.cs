using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    // Classe que gerencia as informações relacionadas ao agendamento de aluguéis
    internal class GetSetAgendarAlugueis
    {
        // Campos privados que armazenam as informações de datas, cliente e valor total do aluguel
        private int diaEntrada;
        private int mesEntrada;
        private int anoEntrada;
        private int diaSaida;
        private int mesSaida;
        private int anoSaida;
        private string nomeCliente;
        private string contatoCliente;
        private double valorTotal;

        // Construtor da classe, inicializando os campos com valores padrão
        public GetSetAgendarAlugueis()
        {
            diaEntrada = 0;
            mesEntrada = 0;
            anoEntrada = 0;
            diaSaida = 0;
            mesSaida = 0;
            anoSaida = 0;
            nomeCliente = "";
            contatoCliente = "";
            valorTotal = 0.0;
        }

        // Método para definir as informações das datas de entrada e saída
        public void setDiaMesAno(int diaEntrada, int mesEntrada, int anoEntrada, int diaSaida, int mesSaida, int anoSaida)
        {
            // Atribui os valores passados como parâmetros aos campos privados
            this.diaEntrada = diaEntrada;
            this.mesEntrada = mesEntrada;
            this.anoEntrada = anoEntrada;
            this.diaSaida = diaSaida;
            this.mesSaida = mesSaida;
            this.anoSaida = anoSaida;
        }

        // Método para definir as informações do cliente
        public void setInfoCliente(string nomeCliente, string contatoCliente)
        {
            // Atribui os valores passados como parâmetros aos campos privados
            this.nomeCliente = nomeCliente;
            this.contatoCliente = contatoCliente;
        }

        // Método para definir o valor total do aluguel
        public void setValorTotal(double valorTotal)
        {
            // Atribui o valor passado como parâmetro ao campo privado
            this.valorTotal = valorTotal;
        }

        // Métodos para obter as informações armazenadas

        public int getDiaEntrada()
        {
            return diaEntrada;
        }

        public int getMesEntrada()
        {
            return mesEntrada;
        }

        public int getAnoEntrada()
        {
            return anoEntrada;
        }

        public int getDiaSaida()
        {
            return diaSaida;
        }

        public int getMesSaida()
        {
            return mesSaida;
        }

        public int getAnoSaida()
        {
            return anoSaida;
        }

        public string getNomeCliente()
        {
            return nomeCliente;
        }

        public string getContatoCliente()
        {
            return contatoCliente;
        }

        public double getValorTotal()
        {
            return valorTotal;
        }
    }
}
