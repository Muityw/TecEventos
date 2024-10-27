using K4os.Compression.LZ4.Internal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecEventos
{
    public partial class ControlePagamentos : Form
    {
        ConexaoBanco conexaoBanco;
        GetSetControlePagamentos pagamento;
        private void ControlePagamentos_Load(object sender, EventArgs e)
        {
        }

        public ControlePagamentos()
        {
            InitializeComponent();
            conexaoBanco = new ConexaoBanco();
            pagamento = new GetSetControlePagamentos();
            this.Load += ControlePagamentos_Load;
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            /*fecha a tela*/
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeClienteTxt.Text) ||
                string.IsNullOrWhiteSpace(NomeChacTxt.Text) ||
                !int.TryParse(ValorPagoTxt.Text, out int dia) ||
                !int.TryParse(TxtDia.Text, out int mes) ||
                !int.TryParse(TxtMes.Text, out int ano) ||
                string.IsNullOrWhiteSpace(MetodoPag.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(StatusPag.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string usuarioId = NomeClienteTxt.Text;
            string chacaraId = NomeChacTxt.Text;
            double valorPago = double.Parse(ValorPagoTxt.Text);
            dia = int.Parse(TxtDia.Text);
            mes = int.Parse(TxtMes.Text);
            ano = int.Parse(TxtAno.Text);
            DateTime dataPagamento = new DateTime(ano, mes, dia);
            string metodoPagamento = MetodoPag.SelectedItem.ToString();
            string statusPagamento = StatusPag.SelectedItem.ToString();

            string querySelect = "SELECT id FROM agendamento WHERE usuario_id = @usuario_id AND chacara_id = @chacara_id and valor_agendamento";

            using (MySqlConnection connection = new MySqlConnection(conexaoBanco.getConnectionString()))
            {
                try
                {
                    connection.Open();

                    MySqlCommand commandSelect = new MySqlCommand(querySelect, connection);
                    commandSelect.Parameters.AddWithValue("@usuario_id", usuarioId);
                    commandSelect.Parameters.AddWithValue("@chacara_id", chacaraId);

                    object result = commandSelect.ExecuteScalar();

                    if (result != null)
                    {
                        int agendamentoId = Convert.ToInt32(result);

                        // Inserindo na tabela controle_pagamentos
                        string queryInsert = "INSERT INTO controle_pagamentos (usuario_id, chacara_id, agendamento_id, valor_pago, data_pagamento, metodo_pagamento, status_pagamento) " +
                                             "VALUES (@usuario_id, @chacara_id, @agendamento_id, @valor_pago, @data_pagamento, @metodo_pagamento, @status_pagamento)";

                        MySqlCommand commandInsert = new MySqlCommand(queryInsert, connection);
                        commandInsert.Parameters.AddWithValue("@usuario_id", usuarioId);
                        commandInsert.Parameters.AddWithValue("@chacara_id", chacaraId);
                        commandInsert.Parameters.AddWithValue("@agendamento_id", agendamentoId);
                        commandInsert.Parameters.AddWithValue("@valor_pago", valorPago);
                        commandInsert.Parameters.AddWithValue("@data_pagamento", dataPagamento);
                        commandInsert.Parameters.AddWithValue("@metodo_pagamento", metodoPagamento);
                        commandInsert.Parameters.AddWithValue("@status_pagamento", statusPagamento);

                        int linhasAfetadas = commandInsert.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Pagamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum agendamento encontrado para este usuário e chácara.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
