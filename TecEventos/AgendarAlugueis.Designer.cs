namespace TecEventos
{
    partial class AgendarAlugueis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarAlugueis));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtContatoCliente = new System.Windows.Forms.TextBox();
            this.lblContatoCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtMesSaida = new System.Windows.Forms.TextBox();
            this.lblMesSaida = new System.Windows.Forms.Label();
            this.txtAnoSaida = new System.Windows.Forms.TextBox();
            this.lblAnoSaida = new System.Windows.Forms.Label();
            this.txtDiaSaida = new System.Windows.Forms.TextBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lblDiaSaida = new System.Windows.Forms.Label();
            this.txtMesEntrada = new System.Windows.Forms.TextBox();
            this.lblMesEntrada = new System.Windows.Forms.Label();
            this.txtAnoEntrada = new System.Windows.Forms.TextBox();
            this.lblAnoEntrada = new System.Windows.Forms.Label();
            this.lblChacarasDisponiveis = new System.Windows.Forms.Label();
            this.txtDiaEntrada = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblDiaEntrada = new System.Windows.Forms.Label();
            this.GridViewChacarasDisponiveis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChacarasDisponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1386, 709);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txtContatoCliente);
            this.panel1.Controls.Add(this.lblContatoCliente);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Controls.Add(this.txtMesSaida);
            this.panel1.Controls.Add(this.lblMesSaida);
            this.panel1.Controls.Add(this.txtAnoSaida);
            this.panel1.Controls.Add(this.lblAnoSaida);
            this.panel1.Controls.Add(this.txtDiaSaida);
            this.panel1.Controls.Add(this.lblSaida);
            this.panel1.Controls.Add(this.lblDiaSaida);
            this.panel1.Controls.Add(this.txtMesEntrada);
            this.panel1.Controls.Add(this.lblMesEntrada);
            this.panel1.Controls.Add(this.txtAnoEntrada);
            this.panel1.Controls.Add(this.lblAnoEntrada);
            this.panel1.Controls.Add(this.lblChacarasDisponiveis);
            this.panel1.Controls.Add(this.txtDiaEntrada);
            this.panel1.Controls.Add(this.lblEntrada);
            this.panel1.Controls.Add(this.lblDiaEntrada);
            this.panel1.Controls.Add(this.GridViewChacarasDisponiveis);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(164, 106);
            this.panel1.MaximumSize = new System.Drawing.Size(1188, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 560);
            this.panel1.TabIndex = 77;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(261, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 39);
            this.btnLimpar.TabIndex = 150;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalizar.Location = new System.Drawing.Point(96, 409);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(123, 39);
            this.btnFinalizar.TabIndex = 149;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Confirmada",
            "Pendente",
            "Cancelada"});
            this.comboBox1.Location = new System.Drawing.Point(262, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 148;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(258, 324);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 147;
            this.lblStatus.Text = "Status";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(29, 346);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(188, 27);
            this.txtTotal.TabIndex = 146;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(24, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 19);
            this.lblTotal.TabIndex = 145;
            this.lblTotal.Text = "Valor total";
            // 
            // txtContatoCliente
            // 
            this.txtContatoCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoCliente.Location = new System.Drawing.Point(262, 282);
            this.txtContatoCliente.Name = "txtContatoCliente";
            this.txtContatoCliente.Size = new System.Drawing.Size(188, 27);
            this.txtContatoCliente.TabIndex = 144;
            // 
            // lblContatoCliente
            // 
            this.lblContatoCliente.AutoSize = true;
            this.lblContatoCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContatoCliente.Location = new System.Drawing.Point(257, 261);
            this.lblContatoCliente.Name = "lblContatoCliente";
            this.lblContatoCliente.Size = new System.Drawing.Size(60, 19);
            this.lblContatoCliente.TabIndex = 143;
            this.lblContatoCliente.Text = "Contato";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(30, 282);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(188, 27);
            this.txtNomeCliente.TabIndex = 142;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(25, 261);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(97, 19);
            this.lblNomeCliente.TabIndex = 141;
            this.lblNomeCliente.Text = "Nome Cliente";
            // 
            // txtMesSaida
            // 
            this.txtMesSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesSaida.Location = new System.Drawing.Point(312, 202);
            this.txtMesSaida.Name = "txtMesSaida";
            this.txtMesSaida.Size = new System.Drawing.Size(39, 27);
            this.txtMesSaida.TabIndex = 140;
            // 
            // lblMesSaida
            // 
            this.lblMesSaida.AutoSize = true;
            this.lblMesSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesSaida.Location = new System.Drawing.Point(307, 181);
            this.lblMesSaida.Name = "lblMesSaida";
            this.lblMesSaida.Size = new System.Drawing.Size(37, 19);
            this.lblMesSaida.TabIndex = 139;
            this.lblMesSaida.Text = "Mês";
            // 
            // txtAnoSaida
            // 
            this.txtAnoSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoSaida.Location = new System.Drawing.Point(372, 202);
            this.txtAnoSaida.Name = "txtAnoSaida";
            this.txtAnoSaida.Size = new System.Drawing.Size(66, 27);
            this.txtAnoSaida.TabIndex = 138;
            // 
            // lblAnoSaida
            // 
            this.lblAnoSaida.AutoSize = true;
            this.lblAnoSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoSaida.Location = new System.Drawing.Point(367, 181);
            this.lblAnoSaida.Name = "lblAnoSaida";
            this.lblAnoSaida.Size = new System.Drawing.Size(34, 19);
            this.lblAnoSaida.TabIndex = 137;
            this.lblAnoSaida.Text = "Ano";
            // 
            // txtDiaSaida
            // 
            this.txtDiaSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaSaida.Location = new System.Drawing.Point(250, 202);
            this.txtDiaSaida.Name = "txtDiaSaida";
            this.txtDiaSaida.Size = new System.Drawing.Size(39, 27);
            this.txtDiaSaida.TabIndex = 135;
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(246, 138);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(51, 23);
            this.lblSaida.TabIndex = 136;
            this.lblSaida.Text = "Saída";
            // 
            // lblDiaSaida
            // 
            this.lblDiaSaida.AutoSize = true;
            this.lblDiaSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSaida.Location = new System.Drawing.Point(245, 181);
            this.lblDiaSaida.Name = "lblDiaSaida";
            this.lblDiaSaida.Size = new System.Drawing.Size(31, 19);
            this.lblDiaSaida.TabIndex = 134;
            this.lblDiaSaida.Text = "Dia";
            // 
            // txtMesEntrada
            // 
            this.txtMesEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesEntrada.Location = new System.Drawing.Point(93, 202);
            this.txtMesEntrada.Name = "txtMesEntrada";
            this.txtMesEntrada.Size = new System.Drawing.Size(39, 27);
            this.txtMesEntrada.TabIndex = 133;
            // 
            // lblMesEntrada
            // 
            this.lblMesEntrada.AutoSize = true;
            this.lblMesEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesEntrada.Location = new System.Drawing.Point(88, 181);
            this.lblMesEntrada.Name = "lblMesEntrada";
            this.lblMesEntrada.Size = new System.Drawing.Size(37, 19);
            this.lblMesEntrada.TabIndex = 132;
            this.lblMesEntrada.Text = "Mês";
            // 
            // txtAnoEntrada
            // 
            this.txtAnoEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoEntrada.Location = new System.Drawing.Point(153, 202);
            this.txtAnoEntrada.Name = "txtAnoEntrada";
            this.txtAnoEntrada.Size = new System.Drawing.Size(66, 27);
            this.txtAnoEntrada.TabIndex = 131;
            // 
            // lblAnoEntrada
            // 
            this.lblAnoEntrada.AutoSize = true;
            this.lblAnoEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoEntrada.Location = new System.Drawing.Point(148, 181);
            this.lblAnoEntrada.Name = "lblAnoEntrada";
            this.lblAnoEntrada.Size = new System.Drawing.Size(34, 19);
            this.lblAnoEntrada.TabIndex = 130;
            this.lblAnoEntrada.Text = "Ano";
            // 
            // lblChacarasDisponiveis
            // 
            this.lblChacarasDisponiveis.AutoSize = true;
            this.lblChacarasDisponiveis.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChacarasDisponiveis.Location = new System.Drawing.Point(484, 49);
            this.lblChacarasDisponiveis.Name = "lblChacarasDisponiveis";
            this.lblChacarasDisponiveis.Size = new System.Drawing.Size(170, 23);
            this.lblChacarasDisponiveis.TabIndex = 129;
            this.lblChacarasDisponiveis.Text = "Chácaras disponíveis";
            // 
            // txtDiaEntrada
            // 
            this.txtDiaEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaEntrada.Location = new System.Drawing.Point(31, 202);
            this.txtDiaEntrada.Name = "txtDiaEntrada";
            this.txtDiaEntrada.Size = new System.Drawing.Size(39, 27);
            this.txtDiaEntrada.TabIndex = 127;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(27, 138);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(70, 23);
            this.lblEntrada.TabIndex = 128;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblDiaEntrada
            // 
            this.lblDiaEntrada.AutoSize = true;
            this.lblDiaEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaEntrada.Location = new System.Drawing.Point(26, 181);
            this.lblDiaEntrada.Name = "lblDiaEntrada";
            this.lblDiaEntrada.Size = new System.Drawing.Size(31, 19);
            this.lblDiaEntrada.TabIndex = 126;
            this.lblDiaEntrada.Text = "Dia";
            // 
            // GridViewChacarasDisponiveis
            // 
            this.GridViewChacarasDisponiveis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.GridViewChacarasDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewChacarasDisponiveis.Location = new System.Drawing.Point(488, 113);
            this.GridViewChacarasDisponiveis.Name = "GridViewChacarasDisponiveis";
            this.GridViewChacarasDisponiveis.RowHeadersWidth = 51;
            this.GridViewChacarasDisponiveis.Size = new System.Drawing.Size(541, 389);
            this.GridViewChacarasDisponiveis.TabIndex = 125;
            this.GridViewChacarasDisponiveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewChacarasDisponiveis_CellContentClick);
            // 
            // AgendarAlugueis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendarAlugueis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChacarasDisponiveis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtContatoCliente;
        private System.Windows.Forms.Label lblContatoCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtMesSaida;
        private System.Windows.Forms.Label lblMesSaida;
        private System.Windows.Forms.TextBox txtAnoSaida;
        private System.Windows.Forms.Label lblAnoSaida;
        private System.Windows.Forms.TextBox txtDiaSaida;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblDiaSaida;
        private System.Windows.Forms.TextBox txtMesEntrada;
        private System.Windows.Forms.Label lblMesEntrada;
        private System.Windows.Forms.TextBox txtAnoEntrada;
        private System.Windows.Forms.Label lblAnoEntrada;
        private System.Windows.Forms.Label lblChacarasDisponiveis;
        private System.Windows.Forms.TextBox txtDiaEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblDiaEntrada;
        private System.Windows.Forms.DataGridView GridViewChacarasDisponiveis;
    }
}