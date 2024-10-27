namespace TecEventos
{
    partial class DatasComemorativas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatasComemorativas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtPromocao = new System.Windows.Forms.TextBox();
            this.lblPromocao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtNomeDataComemorativo = new System.Windows.Forms.TextBox();
            this.lblNomeData = new System.Windows.Forms.Label();
            this.txtMesComemorativo = new System.Windows.Forms.TextBox();
            this.lblMesComemorativo = new System.Windows.Forms.Label();
            this.txtAnoComemorativo = new System.Windows.Forms.TextBox();
            this.lblAnoComemorativo = new System.Windows.Forms.Label();
            this.lblDatasComemorativas = new System.Windows.Forms.Label();
            this.txtDiaComemorativo = new System.Windows.Forms.TextBox();
            this.lblDiaComemorativo = new System.Windows.Forms.Label();
            this.GridViewDatasComemorativas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDatasComemorativas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.txtPromocao);
            this.panel1.Controls.Add(this.lblPromocao);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.txtNomeDataComemorativo);
            this.panel1.Controls.Add(this.lblNomeData);
            this.panel1.Controls.Add(this.txtMesComemorativo);
            this.panel1.Controls.Add(this.lblMesComemorativo);
            this.panel1.Controls.Add(this.txtAnoComemorativo);
            this.panel1.Controls.Add(this.lblAnoComemorativo);
            this.panel1.Controls.Add(this.lblDatasComemorativas);
            this.panel1.Controls.Add(this.txtDiaComemorativo);
            this.panel1.Controls.Add(this.lblDiaComemorativo);
            this.panel1.Controls.Add(this.GridViewDatasComemorativas);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(121, 125);
            this.panel1.MaximumSize = new System.Drawing.Size(1188, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 528);
            this.panel1.TabIndex = 76;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.Azure;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Location = new System.Drawing.Point(898, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(86, 25);
            this.btnHome.TabIndex = 153;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtPromocao
            // 
            this.txtPromocao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromocao.Location = new System.Drawing.Point(24, 288);
            this.txtPromocao.Name = "txtPromocao";
            this.txtPromocao.Size = new System.Drawing.Size(287, 27);
            this.txtPromocao.TabIndex = 152;
            // 
            // lblPromocao
            // 
            this.lblPromocao.AutoSize = true;
            this.lblPromocao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocao.Location = new System.Drawing.Point(19, 267);
            this.lblPromocao.Name = "lblPromocao";
            this.lblPromocao.Size = new System.Drawing.Size(63, 19);
            this.lblPromocao.TabIndex = 151;
            this.lblPromocao.Text = "ID Preço";
            this.lblPromocao.Click += new System.EventHandler(this.lblPromocao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(188, 389);
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
            this.btnFinalizar.Location = new System.Drawing.Point(24, 389);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(123, 39);
            this.btnFinalizar.TabIndex = 149;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtNomeDataComemorativo
            // 
            this.txtNomeDataComemorativo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDataComemorativo.Location = new System.Drawing.Point(24, 147);
            this.txtNomeDataComemorativo.Name = "txtNomeDataComemorativo";
            this.txtNomeDataComemorativo.Size = new System.Drawing.Size(287, 27);
            this.txtNomeDataComemorativo.TabIndex = 142;
            // 
            // lblNomeData
            // 
            this.lblNomeData.AutoSize = true;
            this.lblNomeData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeData.Location = new System.Drawing.Point(20, 123);
            this.lblNomeData.Name = "lblNomeData";
            this.lblNomeData.Size = new System.Drawing.Size(196, 19);
            this.lblNomeData.TabIndex = 141;
            this.lblNomeData.Text = "Nome da data comemorativa";
            // 
            // txtMesComemorativo
            // 
            this.txtMesComemorativo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesComemorativo.Location = new System.Drawing.Point(90, 219);
            this.txtMesComemorativo.Name = "txtMesComemorativo";
            this.txtMesComemorativo.Size = new System.Drawing.Size(39, 27);
            this.txtMesComemorativo.TabIndex = 133;
            // 
            // lblMesComemorativo
            // 
            this.lblMesComemorativo.AutoSize = true;
            this.lblMesComemorativo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesComemorativo.Location = new System.Drawing.Point(85, 198);
            this.lblMesComemorativo.Name = "lblMesComemorativo";
            this.lblMesComemorativo.Size = new System.Drawing.Size(37, 19);
            this.lblMesComemorativo.TabIndex = 132;
            this.lblMesComemorativo.Text = "Mês";
            // 
            // txtAnoComemorativo
            // 
            this.txtAnoComemorativo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoComemorativo.Location = new System.Drawing.Point(150, 219);
            this.txtAnoComemorativo.Name = "txtAnoComemorativo";
            this.txtAnoComemorativo.Size = new System.Drawing.Size(66, 27);
            this.txtAnoComemorativo.TabIndex = 131;
            // 
            // lblAnoComemorativo
            // 
            this.lblAnoComemorativo.AutoSize = true;
            this.lblAnoComemorativo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoComemorativo.Location = new System.Drawing.Point(145, 198);
            this.lblAnoComemorativo.Name = "lblAnoComemorativo";
            this.lblAnoComemorativo.Size = new System.Drawing.Size(34, 19);
            this.lblAnoComemorativo.TabIndex = 130;
            this.lblAnoComemorativo.Text = "Ano";
            // 
            // lblDatasComemorativas
            // 
            this.lblDatasComemorativas.AutoSize = true;
            this.lblDatasComemorativas.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatasComemorativas.Location = new System.Drawing.Point(444, 32);
            this.lblDatasComemorativas.Name = "lblDatasComemorativas";
            this.lblDatasComemorativas.Size = new System.Drawing.Size(178, 23);
            this.lblDatasComemorativas.TabIndex = 129;
            this.lblDatasComemorativas.Text = "Datas comemorativas";
            // 
            // txtDiaComemorativo
            // 
            this.txtDiaComemorativo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaComemorativo.Location = new System.Drawing.Point(28, 219);
            this.txtDiaComemorativo.Name = "txtDiaComemorativo";
            this.txtDiaComemorativo.Size = new System.Drawing.Size(39, 27);
            this.txtDiaComemorativo.TabIndex = 127;
            // 
            // lblDiaComemorativo
            // 
            this.lblDiaComemorativo.AutoSize = true;
            this.lblDiaComemorativo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaComemorativo.Location = new System.Drawing.Point(23, 198);
            this.lblDiaComemorativo.Name = "lblDiaComemorativo";
            this.lblDiaComemorativo.Size = new System.Drawing.Size(31, 19);
            this.lblDiaComemorativo.TabIndex = 126;
            this.lblDiaComemorativo.Text = "Dia";
            // 
            // GridViewDatasComemorativas
            // 
            this.GridViewDatasComemorativas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.GridViewDatasComemorativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDatasComemorativas.Location = new System.Drawing.Point(448, 67);
            this.GridViewDatasComemorativas.Name = "GridViewDatasComemorativas";
            this.GridViewDatasComemorativas.RowHeadersWidth = 51;
            this.GridViewDatasComemorativas.Size = new System.Drawing.Size(376, 361);
            this.GridViewDatasComemorativas.TabIndex = 125;
            // 
            // DatasComemorativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatasComemorativas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatasComemorativas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDatasComemorativas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtNomeDataComemorativo;
        private System.Windows.Forms.Label lblNomeData;
        private System.Windows.Forms.TextBox txtMesComemorativo;
        private System.Windows.Forms.Label lblMesComemorativo;
        private System.Windows.Forms.TextBox txtAnoComemorativo;
        private System.Windows.Forms.Label lblAnoComemorativo;
        private System.Windows.Forms.Label lblDatasComemorativas;
        private System.Windows.Forms.TextBox txtDiaComemorativo;
        private System.Windows.Forms.Label lblDiaComemorativo;
        private System.Windows.Forms.DataGridView GridViewDatasComemorativas;
        private System.Windows.Forms.TextBox txtPromocao;
        private System.Windows.Forms.Label lblPromocao;
        private System.Windows.Forms.Button btnHome;
    }
}