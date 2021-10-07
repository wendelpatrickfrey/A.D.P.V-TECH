
namespace BGM_FORMS.View
{
    partial class EditaOcorencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditaOcorencia));
            this.label13 = new System.Windows.Forms.Label();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.txtCNH = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cbjuridico = new System.Windows.Forms.CheckBox();
            this.cbfisico = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAnalista = new System.Windows.Forms.ComboBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtTerceiro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtnumeroocorrencia = new System.Windows.Forms.TextBox();
            this.btnadicionar = new BGM_FORMS.BotaoPersonalizado.BotaoBGM();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(922, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 37);
            this.label13.TabIndex = 94;
            this.label13.Text = "Renavam";
            // 
            // txtRenavam
            // 
            this.txtRenavam.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRenavam.Location = new System.Drawing.Point(922, 416);
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(267, 34);
            this.txtRenavam.TabIndex = 93;
            // 
            // txtCNH
            // 
            this.txtCNH.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCNH.Location = new System.Drawing.Point(450, 320);
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(267, 34);
            this.txtCNH.TabIndex = 92;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(450, 280);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 37);
            this.label26.TabIndex = 91;
            this.label26.Text = "CNH";
            // 
            // cbjuridico
            // 
            this.cbjuridico.AutoSize = true;
            this.cbjuridico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbjuridico.Location = new System.Drawing.Point(777, 113);
            this.cbjuridico.Name = "cbjuridico";
            this.cbjuridico.Size = new System.Drawing.Size(99, 32);
            this.cbjuridico.TabIndex = 90;
            this.cbjuridico.Text = "Jurídico";
            this.cbjuridico.UseVisualStyleBackColor = true;
            this.cbjuridico.CheckedChanged += new System.EventHandler(this.cbjuridico_CheckedChanged);
            // 
            // cbfisico
            // 
            this.cbfisico.AutoSize = true;
            this.cbfisico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbfisico.Location = new System.Drawing.Point(691, 113);
            this.cbfisico.Name = "cbfisico";
            this.cbfisico.Size = new System.Drawing.Size(80, 32);
            this.cbfisico.TabIndex = 89;
            this.cbfisico.Text = "Físico";
            this.cbfisico.UseVisualStyleBackColor = true;
            this.cbfisico.CheckedChanged += new System.EventHandler(this.cbfisico_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(101, 371);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 37);
            this.label23.TabIndex = 88;
            this.label23.Text = "*";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCNPJ.Location = new System.Drawing.Point(450, 232);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(267, 34);
            this.txtCNPJ.TabIndex = 87;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(922, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 37);
            this.label16.TabIndex = 85;
            this.label16.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(922, 320);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(267, 34);
            this.txtNumero.TabIndex = 84;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(922, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 37);
            this.label17.TabIndex = 83;
            this.label17.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.Location = new System.Drawing.Point(922, 232);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(267, 34);
            this.txtComplemento.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(292, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 37);
            this.label12.TabIndex = 81;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(92, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 37);
            this.label11.TabIndex = 80;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(130, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 37);
            this.label10.TabIndex = 79;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 37);
            this.label9.TabIndex = 78;
            this.label9.Text = "CPF/CNPJ";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.Location = new System.Drawing.Point(450, 232);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(267, 34);
            this.txtCPF.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(922, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 37);
            this.label8.TabIndex = 74;
            this.label8.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 37);
            this.label7.TabIndex = 73;
            this.label7.Text = "Analista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 37);
            this.label6.TabIndex = 72;
            this.label6.Text = "Nome do Terceiro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 37);
            this.label5.TabIndex = 71;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 37);
            this.label4.TabIndex = 70;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 37);
            this.label3.TabIndex = 69;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 37);
            this.label2.TabIndex = 68;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 37);
            this.label1.TabIndex = 67;
            this.label1.Text = "Número da ocorrência";
            // 
            // cbAnalista
            // 
            this.cbAnalista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnalista.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAnalista.FormattingEnabled = true;
            this.cbAnalista.Location = new System.Drawing.Point(30, 326);
            this.cbAnalista.Name = "cbAnalista";
            this.cbAnalista.Size = new System.Drawing.Size(267, 36);
            this.cbAnalista.TabIndex = 66;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCEP.Location = new System.Drawing.Point(922, 155);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(267, 34);
            this.txtCEP.TabIndex = 65;
            // 
            // txtTerceiro
            // 
            this.txtTerceiro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTerceiro.Location = new System.Drawing.Point(450, 151);
            this.txtTerceiro.Name = "txtTerceiro";
            this.txtTerceiro.Size = new System.Drawing.Size(267, 34);
            this.txtTerceiro.TabIndex = 64;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(450, 498);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 34);
            this.txtEmail.TabIndex = 63;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(450, 405);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(267, 34);
            this.txtTelefone.TabIndex = 62;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(30, 411);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(267, 34);
            this.txtValor.TabIndex = 61;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.Location = new System.Drawing.Point(30, 238);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(267, 34);
            this.txtData.TabIndex = 60;
            // 
            // txtnumeroocorrencia
            // 
            this.txtnumeroocorrencia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnumeroocorrencia.Location = new System.Drawing.Point(30, 157);
            this.txtnumeroocorrencia.Name = "txtnumeroocorrencia";
            this.txtnumeroocorrencia.Size = new System.Drawing.Size(267, 34);
            this.txtnumeroocorrencia.TabIndex = 59;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnadicionar.BackColor = System.Drawing.Color.Peru;
            this.btnadicionar.BackgroundColor = System.Drawing.Color.Peru;
            this.btnadicionar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnadicionar.BorderRadius = 20;
            this.btnadicionar.BorderSize = 0;
            this.btnadicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadicionar.FlatAppearance.BorderSize = 0;
            this.btnadicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnadicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadicionar.ForeColor = System.Drawing.Color.White;
            this.btnadicionar.Location = new System.Drawing.Point(985, 594);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(223, 59);
            this.btnadicionar.TabIndex = 95;
            this.btnadicionar.Text = "CONFIRMAR";
            this.btnadicionar.TextColor = System.Drawing.Color.White;
            this.btnadicionar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 95);
            this.panel1.TabIndex = 96;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(378, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(460, 49);
            this.label14.TabIndex = 0;
            this.label14.Text = "EDITAR OCORRÊNCIA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 612);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditaOcorencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRenavam);
            this.Controls.Add(this.txtCNH);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.cbjuridico);
            this.Controls.Add(this.cbfisico);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAnalista);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtTerceiro);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtnumeroocorrencia);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditaOcorencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditaOcorencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.TextBox txtCNH;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cbjuridico;
        private System.Windows.Forms.CheckBox cbfisico;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnalista;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtTerceiro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtnumeroocorrencia;
        private BotaoPersonalizado.BotaoBGM btnadicionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}