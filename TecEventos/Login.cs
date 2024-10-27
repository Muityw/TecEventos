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
    public partial class Login : Form
    {
        ConexaoBanco conexaoBanco;
        public Login()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void TextBox2(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private int usuarioId;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT u.id FROM usuarios u JOIN adm a ON u.id = a.usuario_id WHERE u.email = @username AND a.senha = @password";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", textBox1.Text);
                    command.Parameters.AddWithValue("@password", textBox2.Text);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        usuarioId = Convert.ToInt32(result); // Armazena o ID do usuário logado
                        RegistrarLogin(usuarioId);

                        Home homeForm = new Home(usuarioId); // Passa o ID do usuário logado para o formulário Home
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegistrarLogin(int usuarioId)
        {
            string query = "INSERT INTO LoginRegistro (usuario_id, login_datetime) VALUES (@usuarioId, @loginDatetime)";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@loginDatetime", DateTime.Now);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar login: " + ex.Message, "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
                private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para recuperar a senha, entre em contato com o administrador.", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

   
}