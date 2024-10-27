namespace TecEventos
{
    partial class ListaChacaras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaChacaras));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeChacara = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChacarasCadastradas = new System.Windows.Forms.Label();
            this.GridViewChacarasCadastradas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChacarasCadastradas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1386, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNomeChacara);
            this.panel1.Controls.Add(this.btnProcurar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblChacarasCadastradas);
            this.panel1.Controls.Add(this.GridViewChacarasCadastradas);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(156, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 563);
            this.panel1.TabIndex = 78;
            // 
            // txtNomeChacara
            // 
            this.txtNomeChacara.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeChacara.Location = new System.Drawing.Point(34, 95);
            this.txtNomeChacara.Name = "txtNomeChacara";
            this.txtNomeChacara.Size = new System.Drawing.Size(132, 27);
            this.txtNomeChacara.TabIndex = 159;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnProcurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcurar.Location = new System.Drawing.Point(34, 175);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(132, 51);
            this.btnProcurar.TabIndex = 158;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 156;
            this.label1.Text = "Pesquisa por nome:";
            // 
            // lblChacarasCadastradas
            // 
            this.lblChacarasCadastradas.AutoSize = true;
            this.lblChacarasCadastradas.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChacarasCadastradas.Location = new System.Drawing.Point(279, 27);
            this.lblChacarasCadastradas.Name = "lblChacarasCadastradas";
            this.lblChacarasCadastradas.Size = new System.Drawing.Size(179, 23);
            this.lblChacarasCadastradas.TabIndex = 129;
            this.lblChacarasCadastradas.Text = "Chácaras Cadastradas";
            // 
            // GridViewChacarasCadastradas
            // 
            this.GridViewChacarasCadastradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.GridViewChacarasCadastradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewChacarasCadastradas.Location = new System.Drawing.Point(283, 68);
            this.GridViewChacarasCadastradas.Name = "GridViewChacarasCadastradas";
            this.GridViewChacarasCadastradas.RowHeadersWidth = 51;
            this.GridViewChacarasCadastradas.Size = new System.Drawing.Size(758, 440);
            this.GridViewChacarasCadastradas.TabIndex = 125;
            this.GridViewChacarasCadastradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewChacarasCadastradas_CellContentClick);
            // 
            // ListaChacaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaChacaras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaChacaras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChacarasCadastradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChacarasCadastradas;
        private System.Windows.Forms.DataGridView GridViewChacarasCadastradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtNomeChacara;
    }
}