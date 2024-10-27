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
    public partial class ContratoVisu : Form
    {
        ConexaoBanco conexaoBanco;

        private void ContratoVisu_Load(object sender, EventArgs e)
        {
            LoadContratos();
        }
        public ContratoVisu()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            this.Load += ContratoVisu_Load;
        }

        private void LoadContratos()
        {
            string query = "SELECT c.id as ID, c.data_contrato as Data, c.valor_total as Valor, c.status as Status, c.cliente_id as Cliente, c.funcionario_id as Funcionário FROM contratos c;";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridView1.DataSource = datatable;

                    if (datatable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum contrato disponível!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    DeleteContrato(id);
                }
            }
        
            private void DeleteContrato(int id)
            {
                using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM contratos WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        LoadContratos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar contrato: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
            }
 
    }
}
