using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    internal class GetSetChacara
    {
        private string nome;
        private string rua;
        private string bairro;
        private string numero;
        private string regras;
        private string politicas;
        private string valorDiaria;
        private string descricao;

        public GetSetChacara()
        {
            nome = "";
            rua = "";
            bairro = "";
            numero = "";
            regras = "";
            politicas = "";
            valorDiaria = "";
            descricao = "";
        }
        public void setInfoChacara(string nome, string rua, string bairro, string numero, string regras, string politicas, string valorDiaria, string descricao)
        {
            this.nome = nome;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.regras = regras;
            this.politicas = politicas;
            this.valorDiaria = valorDiaria;
            this.descricao = descricao;
        }
        public string getNome()
        {
            return nome;
        }
        public string getRua()
        {
            return rua;
        }
        public string getBairro()
        {
            return bairro;
        }
        public string getNumero()
        {
            return numero;
        }
        public string getRegras()
        {
            return regras;
        }
        public string getPoliticas()
        {
            return politicas;
        }
        public string getValorDiaria()
        {
            return valorDiaria;
        }
        public string getDescricao()
        {
            return descricao;
        }
    }
}
