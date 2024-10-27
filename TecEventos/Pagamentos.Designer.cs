namespace TecEventos
{
    partial class Pagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamentos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVisuPag = new System.Windows.Forms.Button();
            this.BtnCriarPag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1360, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnVisuPag);
            this.panel2.Controls.Add(this.BtnCriarPag);
            this.panel2.Location = new System.Drawing.Point(152, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 522);
            this.panel2.TabIndex = 2;
            // 
            // btnVisuPag
            // 
            this.btnVisuPag.BackColor = System.Drawing.Color.SkyBlue;
            this.btnVisuPag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisuPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisuPag.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisuPag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVisuPag.Location = new System.Drawing.Point(377, 321);
            this.btnVisuPag.Name = "btnVisuPag";
            this.btnVisuPag.Size = new System.Drawing.Size(262, 79);
            this.btnVisuPag.TabIndex = 73;
            this.btnVisuPag.Text = "Visualizar pagamentos";
            this.btnVisuPag.UseVisualStyleBackColor = false;
            this.btnVisuPag.Click += new System.EventHandler(this.btnVisuPag_Click_1);
            // 
            // BtnCriarPag
            // 
            this.BtnCriarPag.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCriarPag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCriarPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCriarPag.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCriarPag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCriarPag.Location = new System.Drawing.Point(377, 138);
            this.BtnCriarPag.Name = "BtnCriarPag";
            this.BtnCriarPag.Size = new System.Drawing.Size(262, 79);
            this.BtnCriarPag.TabIndex = 72;
            this.BtnCriarPag.Text = "Criar novo pagamento";
            this.BtnCriarPag.UseVisualStyleBackColor = false;
            this.BtnCriarPag.Click += new System.EventHandler(this.BtnCriarPag_Click_1);
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCriarPag;
        private System.Windows.Forms.Button btnVisuPag;
    }
}