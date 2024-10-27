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
    public partial class Precificacao : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetPrecificacao precificacao;
        private int chacaraIdSelecionado;
        private void Precificacao_Load(object sender, EventArgs e)
        {
            LoadPrecificaDisponiveis();
        }
        public Precificacao()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            precificacao = new GetSetPrecificacao();
            this.Load += Precificacao_Load;
        }
        private void LoadPrecificaDisponiveis()
        {
            string query = "SELECT id as ID, valor as Valor, dia_semana as 'Dia da Semana' FROM valores_diarias";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridView1.DataSource = datatable;

                    dataGridView1.ReadOnly = true; 
                    dataGridView1.AllowUserToAddRows = false; 
                    dataGridView1.AllowUserToDeleteRows = false; 
                    dataGridView1.MultiSelect = false; 
                    dataGridView1.Enabled = false; 

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma chácara disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnCadastrarChacara_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO valores_diarias(valor, dia_semana) VALUES " +
                "(@valor, @dia_semana)";
            precificacao.setValores(comboBox1.Text, double.Parse(TxtValorPre.Text));

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@valor", precificacao.getValor());
                    command.Parameters.AddWithValue("@dia_semana", precificacao.getDiaSemana());
                    command.ExecuteNonQuery(); 

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPrecificaDisponiveis();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir os dados! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Supondo que o ID da chácara está na primeira coluna (ajuste o índice da coluna conforme necessário)
                chacaraIdSelecionado = Convert.ToInt32(row.Cells[0].Value);
            }
        }
    }
}
