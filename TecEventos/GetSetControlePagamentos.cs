using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TecEventos
{
    internal class GetSetControlePagamentos
    {
        private string usuarioId;
        private int chacaraID;
        private double valorAluguel;
        private double valorPago;
        private int dia;
        private int mes;
        private int ano;
        private string metodoPagamento;
        private string statusPagamento;
        public GetSetControlePagamentos()
        {
            usuarioId = "";
            chacaraID = 0;
            valorAluguel = 0.0;
            valorPago = 0.0;
            dia = 0;
            mes = 0;
            ano = 0;
            metodoPagamento = "";
            statusPagamento = "";
        }
        public void setInfoPagamento(string usuariId, int chacaraID, double valorAluguel, double valorPago, int dia, int mes, int ano, string metodoPagamento, string statusPagamento)
        {
            this.usuarioId = usuariId;
            this.chacaraID = chacaraID;
            this.valorAluguel = valorAluguel;
            this.valorPago = valorPago;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
            this.metodoPagamento = metodoPagamento;
            this.statusPagamento = statusPagamento;
        }
        public string getNomeCliente()
        {
            return usuarioId;
        }
        public int getChacaraID()
        {
            return chacaraID;
        }
        public double getValorAluguel()
        {
            return valorAluguel;
        }
        public double getValorPago()
        {
            return valorPago;
        }
        public int getDia()
        {
            return dia;
        }
        public int getMes()
        {
            return mes;
        }
        public int getAno()
        {
            return ano;
        }
        public string getMetodoPagamento()
        {
            return metodoPagamento;
        }
        public string getStatusPagamento()
        {
            return statusPagamento;
        }

    }

}
