using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TecEventos
{
    public partial class AgendarAlugueis : Form
    {
        // Instâncias para conexão com o banco de dados e manipulação dos dados de aluguel
        private ConexaoBanco conexaoBanco;
        private GetSetAgendarAlugueis dadosAluguel;
        private int chacaraIdSelecionado; // Variável para armazenar o ID da chácara selecionada

        public AgendarAlugueis()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            dadosAluguel = new GetSetAgendarAlugueis();
            this.Load += AgendarAlugueis_Load; // Associar o evento de carregamento ao método correspondente
            GridViewChacarasDisponiveis.ReadOnly = true; // Tornar o DataGridView somente leitura
        }

        // Método chamado quando o formulário é carregado
        private void AgendarAlugueis_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis(); // Carregar chácaras disponíveis ao iniciar o formulário
        }

        // Método para carregar as chácaras disponíveis e exibi-las no DataGridView
        private void LoadChacarasDisponiveis()
        {
            // Consulta SQL para selecionar chácaras que não estão agendadas na data atual
            string query = @"
                SELECT c.id, c.nome as Nome, e.Rua as Endereço, e.numero as Número, e.bairro as Bairro, 
                       p.descricao as Politicas, r.descricao as Regras  
                FROM Chacara c
                JOIN enderecos e ON e.id = c.endereco_id
                JOIN politicas p ON p.id = c.politicas_id
                JOIN regras r ON r.id = c.regras_id
                WHERE c.id NOT IN (
                    SELECT chacara_id FROM Agendamento 
                    WHERE entrada_data <= CURDATE() AND saida_data >= CURDATE()
                )";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    GridViewChacarasDisponiveis.DataSource = dataTable; // Definir o DataSource do DataGridView

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma chácara disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    GridViewChacarasDisponiveis.Refresh(); // Atualizar o DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para limpar todos os campos do formulário
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDiaSaida.Clear();
            txtMesSaida.Clear();
            txtAnoSaida.Clear();
            txtNomeCliente.Clear();
            txtContatoCliente.Clear();
            comboBox1.SelectedIndex = -1;
            txtTotal.Clear();
            txtDiaEntrada.Clear();
            txtMesEntrada.Clear();
            txtAnoEntrada.Clear();
        }

        // Método para finalizar o agendamento
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Verifica se uma chácara foi selecionada
            if (chacaraIdSelecionado == 0)
            {
                MessageBox.Show("Por favor, selecione uma chácara.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validações básicas de entrada
            if (!DateTime.TryParse($"{txtAnoEntrada.Text}-{txtMesEntrada.Text}-{txtDiaEntrada.Text}", out DateTime entradaData) ||
                !DateTime.TryParse($"{txtAnoSaida.Text}-{txtMesSaida.Text}-{txtDiaSaida.Text}", out DateTime saidaData))
            {
                MessageBox.Show("Por favor, insira datas válidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dadosAluguel.setDiaMesAno(int.Parse(txtDiaEntrada.Text), int.Parse(txtMesEntrada.Text), int.Parse(txtAnoEntrada.Text),
                                       int.Parse(txtDiaSaida.Text), int.Parse(txtMesSaida.Text), int.Parse(txtAnoSaida.Text));
            dadosAluguel.setInfoCliente(txtNomeCliente.Text, txtContatoCliente.Text);
            dadosAluguel.setValorTotal(double.Parse(txtTotal.Text));

            string queryUsuarioId = "SELECT id FROM usuarios WHERE nome = @nome";
            string queryAgendamento = @"
                INSERT INTO agendamento (entrada_data, saida_data, usuario_id, chacara_id, valor_agendamento, status) 
                VALUES (@entradaData, @saidaData, @usuarioId, @chacaraId, @valorAgendamento, @status)";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    // Obter o ID do usuário a partir do nome
                    int usuarioId;
                    using (MySqlCommand commandUsuarioId = new MySqlCommand(queryUsuarioId, connection))
                    {
                        commandUsuarioId.Parameters.AddWithValue("@nome", txtNomeCliente.Text);
                        object result = commandUsuarioId.ExecuteScalar();

                        if (result != null)
                        {
                            usuarioId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado com o nome fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Inserir o novo agendamento no banco de dados
                    using (MySqlCommand commandAgendamento = new MySqlCommand(queryAgendamento, connection))
                    {
                        commandAgendamento.Parameters.AddWithValue("@entradaData", entradaData);
                        commandAgendamento.Parameters.AddWithValue("@saidaData", saidaData);
                        commandAgendamento.Parameters.AddWithValue("@usuarioId", usuarioId);
                        commandAgendamento.Parameters.AddWithValue("@chacaraId", chacaraIdSelecionado);
                        commandAgendamento.Parameters.AddWithValue("@valorAgendamento", dadosAluguel.getValorTotal());
                        commandAgendamento.Parameters.AddWithValue("@status", comboBox1.Text);

                        int linhasAfetadas = commandAgendamento.ExecuteNonQuery();
                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimpar_Click(sender, e); // Limpar o formulário após o agendamento bem-sucedido
                        }
                        else
                        {
                            MessageBox.Show("Erro ao realizar o agendamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento para capturar o clique em uma célula do DataGridView
        private void GridViewChacarasDisponiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow row = GridViewChacarasDisponiveis.Rows[e.RowIndex];
                chacaraIdSelecionado = Convert.ToInt32(row.Cells[0].Value); // Captura o ID da chácara selecionada
            }
        }

        // Evento para o botão 'Home' que fecha o formulário
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário
        }
    }
}
