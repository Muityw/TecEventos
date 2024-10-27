namespace TecEventos
{
    partial class Disponibilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disponibilidade));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDatasdiponiveiseIndiponiveis = new System.Windows.Forms.Label();
            this.lblChacarasDisponiveis = new System.Windows.Forms.Label();
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
            this.pictureBox1.Size = new System.Drawing.Size(1040, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.lblDatasdiponiveiseIndiponiveis);
            this.panel1.Controls.Add(this.lblChacarasDisponiveis);
            this.panel1.Controls.Add(this.GridViewChacarasDisponiveis);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.MaximumSize = new System.Drawing.Size(1188, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 557);
            this.panel1.TabIndex = 79;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(744, 203);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 134;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblDatasdiponiveiseIndiponiveis
            // 
            this.lblDatasdiponiveiseIndiponiveis.AutoSize = true;
            this.lblDatasdiponiveiseIndiponiveis.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatasdiponiveiseIndiponiveis.Location = new System.Drawing.Point(740, 171);
            this.lblDatasdiponiveiseIndiponiveis.Name = "lblDatasdiponiveiseIndiponiveis";
            this.lblDatasdiponiveiseIndiponiveis.Size = new System.Drawing.Size(54, 23);
            this.lblDatasdiponiveiseIndiponiveis.TabIndex = 131;
            this.lblDatasdiponiveiseIndiponiveis.Text = "Datas";
            // 
            // lblChacarasDisponiveis
            // 
            this.lblChacarasDisponiveis.AutoSize = true;
            this.lblChacarasDisponiveis.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChacarasDisponiveis.Location = new System.Drawing.Point(20, 20);
            this.lblChacarasDisponiveis.Name = "lblChacarasDisponiveis";
            this.lblChacarasDisponiveis.Size = new System.Drawing.Size(172, 23);
            this.lblChacarasDisponiveis.TabIndex = 129;
            this.lblChacarasDisponiveis.Text = "Chácaras Disponíveis";
            // 
            // GridViewChacarasDisponiveis
            // 
            this.GridViewChacarasDisponiveis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(177)))), ((int)(((byte)(206)))));
            this.GridViewChacarasDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewChacarasDisponiveis.Location = new System.Drawing.Point(24, 56);
            this.GridViewChacarasDisponiveis.Name = "GridViewChacarasDisponiveis";
            this.GridViewChacarasDisponiveis.RowHeadersWidth = 51;
            this.GridViewChacarasDisponiveis.Size = new System.Drawing.Size(646, 487);
            this.GridViewChacarasDisponiveis.TabIndex = 125;
            // 
            // Disponibilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Disponibilidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disponibilidade";
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
        private System.Windows.Forms.Label lblDatasdiponiveiseIndiponiveis;
        private System.Windows.Forms.Label lblChacarasDisponiveis;
        private System.Windows.Forms.DataGridView GridViewChacarasDisponiveis;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}