using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TecEventos
{
    public partial class CadastrarClientes : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetCadastrarCliente cliente;
        public CadastrarClientes()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            cliente = new GetSetCadastrarCliente();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            NomeCompTxt.Text = "";
            EmailTxt.Text = "";
            EnderecoRuaTxt.Text = "";
            TelefoneTxt.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cliente.setInfoCliente(NomeCompTxt.Text, EmailTxt.Text, EnderecoRuaTxt.Text, EnderecoBairroTxt.Text, EnderecoNumeroTxt.Text, TelefoneTxt.Text);

            string queryInserir = "INSERT INTO usuarios (nome, email, telefone, endereco_id) " +
                                  "VALUES (@nome, @email, @telefone, @endereco_id)";
            string queryEnderecoID = "SELECT id FROM enderecos WHERE numero = @numero AND bairro = @bairro";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    string endereco_id = null;
                    using (MySqlCommand commandEndereco = new MySqlCommand(queryEnderecoID, connection))
                    {
                        commandEndereco.Parameters.AddWithValue("@bairro", EnderecoBairroTxt.Text);
                        commandEndereco.Parameters.AddWithValue("@numero", EnderecoNumeroTxt.Text);

                        using (MySqlDataReader reader = commandEndereco.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                endereco_id = reader["id"].ToString();
                            }
                        }
                    }

                    if (endereco_id == null)
                    {
                        MessageBox.Show("Endereco não encontrado.");
                        return;
                    }

                    using (MySqlCommand commandInserir = new MySqlCommand(queryInserir, connection))
                    {
                        commandInserir.Parameters.AddWithValue("@nome", cliente.getNome());
                        commandInserir.Parameters.AddWithValue("@email", cliente.getEmail());
                        commandInserir.Parameters.AddWithValue("@telefone", cliente.getTelefone());
                        commandInserir.Parameters.AddWithValue("@endereco_id", endereco_id);

                        commandInserir.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuário cadastrado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }
    }
}
