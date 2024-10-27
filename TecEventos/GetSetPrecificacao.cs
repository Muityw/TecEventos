using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    internal class GetSetPrecificacao
    {
        private string diaSemana;
        private double valor;
        public GetSetPrecificacao()
        {
            diaSemana = "";
            valor = 0.0;
        }
        public void setValores(string diaSemana, double valor)
        {
            this.diaSemana = diaSemana;
            this.valor = valor;
        }
        public string getDiaSemana()
        {
            return diaSemana;
        }
        public double getValor()
        {
            return valor;
        }
    }
}
