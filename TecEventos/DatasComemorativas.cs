using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class DatasComemorativas : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetDatasComemorativas data;

        private void DatasComemorativas_Load(object sender, EventArgs e)
        {
            LoadDatasComemorativas();
        }

        public DatasComemorativas()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            data = new GetSetDatasComemorativas();
            this.Load += DatasComemorativas_Load;
        }

        private void LoadDatasComemorativas()
        {
            string query = "SELECT dc.data_comemorativa as Data, dc.descricao as Descrição, vd.valor as Valor " +
                           "FROM datas_comemorativas dc " +
                           "JOIN valores_diarias vd ON vd.id = dc.valor_promocional_id;";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    GridViewDatasComemorativas.DataSource = datatable;

                    GridViewDatasComemorativas.ReadOnly = true;
                    GridViewDatasComemorativas.AllowUserToAddRows = false;
                    GridViewDatasComemorativas.AllowUserToDeleteRows = false;
                    GridViewDatasComemorativas.MultiSelect = false;
                    GridViewDatasComemorativas.Enabled = false;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma data comemorativa disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    GridViewDatasComemorativas.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Validar entradas antes de salvar
            if (string.IsNullOrWhiteSpace(txtNomeDataComemorativo.Text) ||
                string.IsNullOrWhiteSpace(txtPromocao.Text) ||
                !int.TryParse(txtDiaComemorativo.Text, out int dia) ||
                !int.TryParse(txtMesComemorativo.Text, out int mes) ||
                !int.TryParse(txtAnoComemorativo.Text, out int ano)) 
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assumindo que 'data' é uma instância de uma classe que você criou
            data.setDiaMesAno(dia, mes, ano);
            data.setInfoDataComemorativa(txtNomeDataComemorativo.Text, txtNomeDataComemorativo.Text, txtPromocao.Text, txtPromocao.Text);

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    // Começar uma transação para garantir que ambas as inserções sejam bem-sucedidas
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            int valorPromocional = int.Parse(txtPromocao.Text);

                            // Inserir na tabela valores_diarias
                            string insertValoresDiariasQuery = "INSERT INTO valores_diarias (valor, dia_semana) VALUES (@valor,@dia_semana)";
                            using (MySqlCommand commandValoresDiarias = new MySqlCommand(insertValoresDiariasQuery, connection, transaction))
                            {
                                commandValoresDiarias.Parameters.AddWithValue("@valor", valorPromocional);
                                commandValoresDiarias.Parameters.AddWithValue("@dia_semana", "Feriado");
                                commandValoresDiarias.ExecuteNonQuery();
                            }

                            // Inserir na tabela datas_comemorativas
                            string insertDatasComemorativasQuery = @"INSERT INTO datas_comemorativas (descricao, valor_promocional_id, data_comemorativa) 
                                                             VALUES (@descricao, @valor_promocional_id, @data_comemorativa)";
                            using (MySqlCommand commandDatasComemorativas = new MySqlCommand(insertDatasComemorativasQuery, connection, transaction))
                            {
                                commandDatasComemorativas.Parameters.AddWithValue("@descricao", data.getDescricao());
                                commandDatasComemorativas.Parameters.AddWithValue("@valor_promocional_id", txtPromocao.Text); // Verifica se a promo é um valor promocional id
                                commandDatasComemorativas.Parameters.AddWithValue("@data_comemorativa", new DateTime(data.getAno(), data.getMes(), data.getDia()).ToString("yyyy-MM-dd"));

                                int linhasAfetadas = commandDatasComemorativas.ExecuteNonQuery();

                                if (linhasAfetadas > 0)
                                {
                                    MessageBox.Show("Data comemorativa cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Nenhuma data comemorativa cadastrada. Verifique os dados e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            // Confirmar a transação
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Reverter a transação em caso de erro
                            transaction.Rollback();
                            MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValorPromocionalExists(int valorPromocionalId, MySqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM valores_diarias WHERE id = @valorPromocionalId";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@valorPromocionalId", valorPromocionalId);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeDataComemorativo.Text = "";
            txtPromocao.Text = "";
            txtDiaComemorativo.Text = "";
            txtMesComemorativo.Text = "";
            txtAnoComemorativo.Text = "";
        }

        private void lblPromocao_Click(object sender, EventArgs e)
        {

        }
    }
}
