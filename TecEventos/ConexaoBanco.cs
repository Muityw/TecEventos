using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecEventos
{
    // Classe que gerencia a conexão com o banco de dados
    internal class ConexaoBanco
    {
        // String de conexão privada que contém as informações necessárias para se conectar ao banco de dados
        private string connectionString;

        // Construtor da classe, onde a string de conexão é definida
        public ConexaoBanco()
        {
            // Definição da string de conexão com os detalhes do servidor, banco de dados, usuário e senha
            connectionString = "server=localhost;database=teceventos;uid=root;pwd=debs";
        }

        // Método público que retorna a string de conexão
        public string getConnectionString()
        {
            return connectionString;
        }
    }
}
