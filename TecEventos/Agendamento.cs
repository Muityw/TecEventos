using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class Agendamento : Form
    {
        // Instâncias para conexão com o banco de dados e manipulação dos dados de agendamento
        private ConexaoBanco conexaoBanco;
        private GetSetAgendamento agendamento;
        private int chacaraIdSelecionado;

        // Construtor da classe, inicializando os componentes e configurando os objetos
        public Agendamento()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            agendamento = new GetSetAgendamento();
            this.Load += Agendamento_Load; // Associa o evento de carregamento do formulário ao método Agendamento_Load
        }

        // Evento que é chamado quando o formulário é carregado
        private void Agendamento_Load(object sender, EventArgs e)
        {
            LoadChacarasDisponiveis(); // Carrega as chácaras disponíveis ao carregar o formulário
        }

        // Método que carrega as chácaras disponíveis e as exibe em um DataGridView
        private void LoadChacarasDisponiveis()
        {
            string query = @"SELECT entrada_data as Entrada, saida_data as Saída, u.nome as Cliente, 
                             u.telefone as Telefone, c.nome as Chacara, 
                             a.valor_agendamento as 'Valor Agendamento', 
                             a.status as 'Status Agendamento' 
                             FROM agendamento a
                             JOIN usuarios u ON u.id = a.usuario_id
                             JOIN chacara c ON c.id = a.chacara_id;";

            // Cria uma conexão com o banco de dados usando a string de conexão fornecida
            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open(); // Abre a conexão com o banco de dados
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection); // Executa a consulta
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable); // Preenche o DataTable com os resultados da consulta
                    GridViewAgendamentos.DataSource = datatable; // Define o DataSource do DataGridView como o DataTable preenchido

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma chácara disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    GridViewAgendamentos.Refresh(); // Atualiza o DataGridView para refletir os dados mais recentes
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento para o botão 'Home' que fecha o formulário
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento para o botão 'Excluir' que remove a linha selecionada no DataGridView
        private void btnExluir_Click(object sender, EventArgs e)
        {
            if (GridViewAgendamentos.SelectedRows.Count > 0) // Verifica se há uma linha selecionada
            {
                DataGridViewRow linhaSelecionada = GridViewAgendamentos.SelectedRows[0];

                if (linhaSelecionada.Index >= 0)
                {
                    GridViewAgendamentos.Rows.Remove(linhaSelecionada); // Remove a linha selecionada
                }
                else
                {
                    MessageBox.Show("Nenhuma linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de clique na célula do DataGridView para capturar informações da linha clicada
        private void GridViewAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow row = GridViewAgendamentos.Rows[e.RowIndex];
                // Supondo que o ID da chácara está em uma coluna específica (por exemplo, 0)
                chacaraIdSelecionado = Convert.ToInt32(row.Cells[0].Value);
                // Adicionar código para manipular o ID da chácara selecionada conforme necessário
            }
        }

        // Evento para o botão 'Atualizar' que deveria atualizar os dados do agendamento no banco de dados
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // O código de atualização está incompleto. Aqui está uma sugestão de como ele poderia ser estruturado.
            string updateQuery = @"UPDATE agendamento 
                                   SET entrada_data = @entrada_data, 
                                       saida_data = @saida_data, 
                                       usuario_id = @usuario_id, 
                                       chacara_id = @chacara_id, 
                                       valor_agendamento = @valor_agendamento, 
                                       status = @status 
                                   WHERE id = @idAgendamentoSelecionado";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    // Adicionar parâmetros para a consulta
                    cmd.Parameters.AddWithValue("@entrada_data", agendamento.getEntradaData());
                    cmd.Parameters.AddWithValue("@saida_data", agendamento.getSaidaData());
                    cmd.Parameters.AddWithValue("@usuario_id", agendamento.getUsuarioID());
                    cmd.Parameters.AddWithValue("@chacara_id", agendamento.getChacaraID());
                    cmd.Parameters.AddWithValue("@valor_agendamento", agendamento.getValorAgendamento());
                    cmd.Parameters.AddWithValue("@status", "Pendente"); // Exemplo, o status poderia ser capturado dinamicamente
                    cmd.Parameters.AddWithValue("@idAgendamentoSelecionado", chacaraIdSelecionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadChacarasDisponiveis(); // Recarrega a lista de agendamentos após a atualização
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o agendamento!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
