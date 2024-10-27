using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    internal class GetSetDatasComemorativas
    {
        private string nomeDataComemorativas;
        private int dia;
        private int mes;
        private int ano;
        private string descricao;
        private string pacote;
        private string promocoes;

        public GetSetDatasComemorativas()
        {
            nomeDataComemorativas = "";
            dia = 0;
            mes = 0;
            ano = 0;
            descricao = "";
            pacote = "";
            promocoes = "";
        }
        public void setDiaMesAno(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public void setInfoDataComemorativa(string nomeDataComemorativa, string descricao, string pacote, string promocoes)
        {
            this.nomeDataComemorativas = nomeDataComemorativa;
            this.descricao = descricao;
            this.pacote = pacote;
            this.promocoes = promocoes;
        }
        public string getNomeDataComemorativa()
        {
            return nomeDataComemorativas;
        }
        public string getDescricao()
        {
            return descricao;
        }
        public string getPacote()
        {
            return pacote;
        }
        public string getPromocoes()
        {
            return promocoes;
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

    }
}
