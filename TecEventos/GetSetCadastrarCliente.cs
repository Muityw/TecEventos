using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    internal class GetSetCadastrarCliente
    {
        private string nome;
        private string email;
        private string rua;
        private string bairro;
        private string numero;
        private string telefone;

        public GetSetCadastrarCliente()
        {
            nome = "";
            email = "";
            rua = "";
            bairro = "";
            numero = "";
            telefone = "";
        }
        public void setInfoCliente(string nome, string email, string rua, string bairro, string numero, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.telefone = telefone;
        }
        public string getNome()
        {
            return nome;
        }
        public string getEmail()
        {
            return email;
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
        public string getTelefone()
        {
            return telefone;
        }
    }
}
