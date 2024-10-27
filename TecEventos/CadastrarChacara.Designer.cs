namespace TecEventos
{
    partial class AdicionarChacara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarChacara));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeChacara = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNomeChacara = new System.Windows.Forms.Label();
            this.txtRegras = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblRegras = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbldDescricao = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNumChacara = new System.Windows.Forms.Label();
            this.btnCadastrarChacara = new System.Windows.Forms.Button();
            this.txtNumChacara = new System.Windows.Forms.TextBox();
            this.lblInfoAdicional = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, -32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Anuncie Sua Chácara";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNomeChacara);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.lblNomeChacara);
            this.panel1.Controls.Add(this.txtRegras);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.lblRegras);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lbldDescricao);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.txtRua);
            this.panel1.Controls.Add(this.lblNumChacara);
            this.panel1.Controls.Add(this.btnCadastrarChacara);
            this.panel1.Controls.Add(this.txtNumChacara);
            this.panel1.Controls.Add(this.lblInfoAdicional);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(322, 160);
            this.panel1.MaximumSize = new System.Drawing.Size(1093, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 561);
            this.panel1.TabIndex = 74;
            // 
            // txtNomeChacara
            // 
            this.txtNomeChacara.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeChacara.Location = new System.Drawing.Point(68, 106);
            this.txtNomeChacara.Name = "txtNomeChacara";
            this.txtNomeChacara.Size = new System.Drawing.Size(286, 27);
            this.txtNomeChacara.TabIndex = 37;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(311, 490);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 39);
            this.btnLimpar.TabIndex = 70;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(66, 43);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(112, 23);
            this.lblInfo.TabIndex = 71;
            this.lblInfo.Text = "Informações ";
            // 
            // lblNomeChacara
            // 
            this.lblNomeChacara.AutoSize = true;
            this.lblNomeChacara.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeChacara.Location = new System.Drawing.Point(62, 85);
            this.lblNomeChacara.Name = "lblNomeChacara";
            this.lblNomeChacara.Size = new System.Drawing.Size(122, 19);
            this.lblNomeChacara.TabIndex = 36;
            this.lblNomeChacara.Text = "Nome da chácara";
            // 
            // txtRegras
            // 
            this.txtRegras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegras.Location = new System.Drawing.Point(71, 412);
            this.txtRegras.Name = "txtRegras";
            this.txtRegras.Size = new System.Drawing.Size(201, 27);
            this.txtRegras.TabIndex = 68;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(68, 163);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(101, 27);
            this.txtValor.TabIndex = 39;
            // 
            // lblRegras
            // 
            this.lblRegras.AutoSize = true;
            this.lblRegras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegras.Location = new System.Drawing.Point(72, 386);
            this.lblRegras.Name = "lblRegras";
            this.lblRegras.Size = new System.Drawing.Size(54, 19);
            this.lblRegras.TabIndex = 67;
            this.lblRegras.Text = "Regras";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(63, 143);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(103, 19);
            this.lblValor.TabIndex = 38;
            this.lblValor.Text = "Valor da diária";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(302, 412);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(243, 27);
            this.txtDescricao.TabIndex = 66;
            // 
            // lbldDescricao
            // 
            this.lbldDescricao.AutoSize = true;
            this.lbldDescricao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldDescricao.Location = new System.Drawing.Point(308, 386);
            this.lbldDescricao.Name = "lbldDescricao";
            this.lbldDescricao.Size = new System.Drawing.Size(64, 19);
            this.lbldDescricao.TabIndex = 65;
            this.lbldDescricao.Text = "Políticas";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(435, 277);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(109, 27);
            this.txtBairro.TabIndex = 61;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(68, 202);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(82, 23);
            this.lblEndereco.TabIndex = 40;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(71, 277);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(206, 27);
            this.txtRua.TabIndex = 41;
            // 
            // lblNumChacara
            // 
            this.lblNumChacara.AutoSize = true;
            this.lblNumChacara.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumChacara.Location = new System.Drawing.Point(308, 254);
            this.lblNumChacara.Name = "lblNumChacara";
            this.lblNumChacara.Size = new System.Drawing.Size(22, 19);
            this.lblNumChacara.TabIndex = 44;
            this.lblNumChacara.Text = "n°";
            // 
            // btnCadastrarChacara
            // 
            this.btnCadastrarChacara.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCadastrarChacara.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarChacara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarChacara.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarChacara.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarChacara.Location = new System.Drawing.Point(134, 490);
            this.btnCadastrarChacara.Name = "btnCadastrarChacara";
            this.btnCadastrarChacara.Size = new System.Drawing.Size(123, 39);
            this.btnCadastrarChacara.TabIndex = 57;
            this.btnCadastrarChacara.Text = "Cadastrar";
            this.btnCadastrarChacara.UseVisualStyleBackColor = false;
            this.btnCadastrarChacara.Click += new System.EventHandler(this.btnCadastrarChacara_Click);
            // 
            // txtNumChacara
            // 
            this.txtNumChacara.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumChacara.Location = new System.Drawing.Point(302, 277);
            this.txtNumChacara.Name = "txtNumChacara";
            this.txtNumChacara.Size = new System.Drawing.Size(109, 27);
            this.txtNumChacara.TabIndex = 45;
            // 
            // lblInfoAdicional
            // 
            this.lblInfoAdicional.AutoSize = true;
            this.lblInfoAdicional.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAdicional.Location = new System.Drawing.Point(68, 331);
            this.lblInfoAdicional.Name = "lblInfoAdicional";
            this.lblInfoAdicional.Size = new System.Drawing.Size(188, 23);
            this.lblInfoAdicional.TabIndex = 46;
            this.lblInfoAdicional.Text = "Informações adicionais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Rua";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(441, 254);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 19);
            this.lblBairro.TabIndex = 60;
            this.lblBairro.Text = "Bairro";
            // 
            // AdicionarChacara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarChacara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeChacara;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNomeChacara;
        private System.Windows.Forms.TextBox txtRegras;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblRegras;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbldDescricao;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNumChacara;
        private System.Windows.Forms.Button btnCadastrarChacara;
        private System.Windows.Forms.TextBox txtNumChacara;
        private System.Windows.Forms.Label lblInfoAdicional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBairro;
    }
}