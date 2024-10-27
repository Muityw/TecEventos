using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class Alterar : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetAgendarAlugueis dadosAluguel;
        private int chacaraIdSelecionado;

        public Alterar()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            dadosAluguel = new GetSetAgendarAlugueis();
            this.Load += AgendarAlugueis_Load;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged; // Adiciona o evento de seleção
        }

        private void AgendarAlugueis_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis();
        }

        private void LoadChacarasDisponiveis()
        {
            string query = @"SELECT c.Id as ID, c.nome as Nome, v.valor as Valor, e.rua as Rua, e.numero as Numero, e.bairro as Bairro, 
                                    r.descricao as Regras, p.descricao as Politicas  
                             FROM chacara c
                             JOIN enderecos e ON e.id = c.endereco_id
                             JOIN regras r ON r.id = c.regras_id
                             JOIN politicas p ON p.id = c.politicas_id
                             JOIN chacaras_valores_diarias cvd ON c.id = cvd.chacara_id
                             JOIN valores_diarias v ON v.id = cvd.valor_diaria_id";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma chácara disponível!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
                chacaraIdSelecionado = Convert.ToInt32(linhaSelecionada.Cells["Id"].Value);
                LoadChacaraDetails(chacaraIdSelecionado);
            }
        }

        private void LoadChacaraDetails(int chacaraId)
        {
            string query = @"SELECT c.nome as Nome, v.valor as Valor, e.rua as Rua, e.numero as Numero, e.bairro as Bairro, 
                                    r.descricao as Regras, p.descricao as Politicas  
                             FROM chacara c
                             JOIN enderecos e ON e.id = c.endereco_id
                             JOIN regras r ON r.id = c.regras_id
                             JOIN politicas p ON p.id = c.politicas_id
                             JOIN chacaras_valores_diarias cvd ON c.id = cvd.chacara_id
                             JOIN valores_diarias v ON v.id = cvd.valor_diaria_id
                             WHERE c.id = @ChacaraId";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ChacaraId", chacaraId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        txtNomeChacara.Text = row["Nome"].ToString();
                        txtValor.Text = row["Valor"].ToString();
                        txtRua.Text = row["Rua"].ToString();
                        txtBairro.Text = row["Bairro"].ToString();
                        txtNumChacara.Text = row["Numero"].ToString();
                        txtRegras.Text = row["Regras"].ToString();
                        txtDescricao.Text = row["Politicas"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Detalhes da chácara não encontrados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (chacaraIdSelecionado > 0)
            {
                string query = @"UPDATE chacara c
                                 JOIN enderecos e ON e.id = c.endereco_id
                                 JOIN regras r ON r.id = c.regras_id
                                 JOIN politicas p ON p.id = c.politicas_id
                                 JOIN chacaras_valores_diarias cvd ON c.id = cvd.chacara_id
                                 JOIN valores_diarias v ON v.id = cvd.valor_diaria_id
                                 SET c.nome = @Nome,
                                     e.rua = @Rua,
                                     e.numero = @Numero,
                                     e.bairro = @Bairro,
                                     v.valor = @Valor,
                                     r.descricao = @Regras,
                                     p.descricao = @Politicas
                                 WHERE c.id = @ChacaraId";

                using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Nome", txtNomeChacara.Text);
                        cmd.Parameters.AddWithValue("@Rua", txtRua.Text);
                        cmd.Parameters.AddWithValue("@Numero", txtNumChacara.Text);
                        cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@Valor", txtValor.Text);
                        cmd.Parameters.AddWithValue("@Regras", txtRegras.Text);
                        cmd.Parameters.AddWithValue("@Politicas", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@ChacaraId", chacaraIdSelecionado);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Chácara atualizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadChacarasDisponiveis(); // Atualiza o DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma alteração foi feita.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar a chácara: " + ex.Message, "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma chácara para alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (chacaraIdSelecionado > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta chácara?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    string query = "update chacara set endereco_id = null and regras_id = null and politicas_id = null where id =@ChacaraId;DELETE FROM chacara WHERE id = @ChacaraId";

                    using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
                    {
                        try
                        {
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@ChacaraId", chacaraIdSelecionado);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Chácara excluída com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadChacarasDisponiveis(); // Atualiza o DataGridView
                                btnLimpar_Click(null, null); // Limpa os campos de texto
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir a chácara.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir a chácara: " + ex.Message, "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma chácara para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
