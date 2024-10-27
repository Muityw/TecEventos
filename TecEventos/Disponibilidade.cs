using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TecEventos
    {
        public partial class Disponibilidade : Form
        {
            ConexaoBanco conexaoBanco;
            GetSetAgendarAlugueis dadosAluguel;

            public Disponibilidade()
            {
                InitializeComponent();
                conexaoBanco = new ConexaoBanco();
                dadosAluguel = new GetSetAgendarAlugueis();
                this.Load += AgendarAlugueis_Load;
                monthCalendar1.DateSelected += new DateRangeEventHandler(this.monthCalendar1_DateChanged);
            }

            private void AgendarAlugueis_Load(object sender, EventArgs e)
            {
                LoadChacarasDisponiveis(DateTime.Now); // Carregar as chácaras disponíveis para a data atual
            }

            private void LoadChacarasDisponiveis(DateTime dataSelecionada)
            {
                string query = @"SELECT c.nome as Nome, e.Rua as Endereço, e.numero as Número, e.bairro as Bairro, 
                                    p.descricao as Politicas, r.descricao as Regras  
                             FROM chacara c
                             JOIN enderecos e ON e.id = c.endereco_id
                             JOIN politicas p ON p.id = c.politicas_id
                             JOIN regras r ON r.id = c.regras_id
                             WHERE c.id NOT IN 
                                 (SELECT chacara_id 
                                  FROM agendamento 
                                  WHERE @DataSelecionada BETWEEN entrada_data AND saida_data)";

                using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@DataSelecionada", dataSelecionada);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Nenhuma chácara disponível para a data selecionada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        GridViewChacarasDisponiveis.DataSource = null; // Limpa o GridView
                        GridViewChacarasDisponiveis.DataSource = dataTable; // Vincula o novo DataTable ao GridView
                        GridViewChacarasDisponiveis.Refresh(); // Atualiza o GridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
            {
                DateTime dataSelecionada = e.Start;
                LoadChacarasDisponiveis(dataSelecionada);
            }
        }
    }

