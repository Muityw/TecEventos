using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class AdicionarChacara : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetChacara chacara;
        public AdicionarChacara()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            chacara = new GetSetChacara();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeChacara.Text = "";
            txtValor.Text = "";
            txtRua.Text = "";
            txtNumChacara.Text = "";
            txtBairro.Text = "";
            txtRegras.Text = "";
            txtDescricao.Text = "";
        }

        private void btnCadastrarChacara_Click(object sender, EventArgs e)
        {
            // Define as queries de inserção
            string queryValorDiaria = "INSERT INTO valores_diarias(valor) VALUES (@valor)";
            string queryEndereco = "INSERT INTO enderecos(rua, numero, bairro) VALUES (@rua, @numero, @bairro); SELECT LAST_INSERT_ID()";
            string queryRegras = "INSERT INTO regras(descricao) VALUES (@descricao); SELECT LAST_INSERT_ID()";
            string queryPoliticas = "INSERT INTO politicas(descricao) VALUES (@descricao); SELECT LAST_INSERT_ID()";
            string queryChacara = "INSERT INTO chacara(nome, endereco_id, regras_id, politicas_id) VALUES (@nome, @endereco_id, @regras_id, @politicas_id)";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    // Inserir valor da diária
                    int valorDiariaId;
                    using (MySqlCommand commandValorDiaria = new MySqlCommand(queryValorDiaria, connection))
                    {
                        commandValorDiaria.Parameters.AddWithValue("@valor", txtValor.Text);
                        commandValorDiaria.ExecuteNonQuery();
                        valorDiariaId = (int)commandValorDiaria.LastInsertedId; // Obtém o ID do último valor inserido
                    }

                    // Inserir endereço
                    int enderecoID;
                    using (MySqlCommand commandEndereco = new MySqlCommand(queryEndereco, connection))
                    {
                        commandEndereco.Parameters.AddWithValue("@rua", txtRua.Text);
                        commandEndereco.Parameters.AddWithValue("@numero", txtNumChacara.Text);
                        commandEndereco.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        enderecoID = Convert.ToInt32(commandEndereco.ExecuteScalar()); // Obtém o ID do endereço inserido
                    }

                    // Inserir regras
                    int regrasID;
                    using (MySqlCommand commandRegras = new MySqlCommand(queryRegras, connection))
                    {
                        commandRegras.Parameters.AddWithValue("@descricao", txtRegras.Text);
                        regrasID = Convert.ToInt32(commandRegras.ExecuteScalar()); // Obtém o ID das regras inseridas
                    }

                    // Inserir políticas
                    int politicasID;
                    using (MySqlCommand commandPoliticas = new MySqlCommand(queryPoliticas, connection))
                    {
                        commandPoliticas.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        politicasID = Convert.ToInt32(commandPoliticas.ExecuteScalar()); // Obtém o ID das políticas inseridas
                    }

                    using (MySqlCommand commandChacara = new MySqlCommand(queryChacara, connection))
                    {
                        commandChacara.Parameters.AddWithValue("@nome", txtNomeChacara.Text);
                        commandChacara.Parameters.AddWithValue("@endereco_id", enderecoID);
                        commandChacara.Parameters.AddWithValue("@regras_id", regrasID);
                        commandChacara.Parameters.AddWithValue("@politicas_id", politicasID);
                        commandChacara.ExecuteNonQuery(); // Insere a chácara com os IDs obtidos
                    }

                    MessageBox.Show("Chácara cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar a chácara: " + ex.Message, "Conexão com o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
