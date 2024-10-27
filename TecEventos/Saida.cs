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
    public partial class Saida : Form
    {
        private int usuarioId; 
        
        public Saida(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            

        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            RegistrarLogout(usuarioId); // Registra o horário de logout
            this.DialogResult = DialogResult.Yes; // Retorna "Yes" para fechar a aplicação
            Application.Exit();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Retorna "Cancel" para cancelar a ação
            this.Close();
        }
        private void RegistrarLogout(int usuarioId)
        {
            string query = "INSERT INTO LogoutRegistro (usuario_id, logout_datetime) VALUES (@usuarioId, @logoutDatetime)";

            using (MySqlConnection connection = new MySqlConnection(new ConexaoBanco().getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@logoutDatetime", DateTime.Now);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar logout: " + ex.Message, "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
