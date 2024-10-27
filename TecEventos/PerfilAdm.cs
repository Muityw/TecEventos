using MySql.Data.MySqlClient;
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
    public partial class PerfilAdm : Form
    {
        ConexaoBanco conexaoBanco;
        public PerfilAdm()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string queryAtualizarCliente = "UPDATE usuarios " +
                "SET email = @email, telefone = @telefone " +
                "WHERE nome = @nome";
            string queryEndereco = "UPDATE enderecos e " +
                "JOIN usuarios u ON u.endereco_id = e.id " +
                "SET e.rua = @rua, e.numero = @numero, e.bairro = @bairro " +
                "WHERE u.nome = @nome;";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand commandAtualizarCliente = new MySqlCommand(queryAtualizarCliente, connection))
                    {
                        commandAtualizarCliente.Parameters.AddWithValue("@nome", NomeCompTxt.Text);
                        commandAtualizarCliente.Parameters.AddWithValue("@email", EmailTxt.Text);
                        commandAtualizarCliente.Parameters.AddWithValue("@telefone", TelefoneTxt.Text);
                        commandAtualizarCliente.ExecuteNonQuery();
                    }
                    using (MySqlCommand commandEndereco = new MySqlCommand(queryEndereco, connection))
                    {
                        commandEndereco.Parameters.AddWithValue("@rua", EnderecoRuaTxt.Text);
                        commandEndereco.Parameters.AddWithValue("@numero", EnderecoNumeroTxt.Text);
                        commandEndereco.Parameters.AddWithValue("@bairro", EnderecoBairroTxt.Text);
                        commandEndereco.Parameters.AddWithValue("@nome", NomeCompTxt.Text);
                        commandEndereco.ExecuteNonQuery();
                    }
                    MessageBox.Show("Atualização realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }   
    }
}
