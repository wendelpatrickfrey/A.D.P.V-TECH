
namespace BGM_FORMS.View
{
    partial class CadastroFuncionarioScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionarioScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btncadastrarfuncionario = new BGM_FORMS.BotaoPersonalizado.BotaoBGM();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.botaobgm1 = new BGM_FORMS.BotaoPersonalizado.BotaoBGM();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 612);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 95);
            this.panel1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(501, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "CADASTRO";
            // 
            // btncadastrarfuncionario
            // 
            this.btncadastrarfuncionario.BackColor = System.Drawing.Color.MidnightBlue;
            this.btncadastrarfuncionario.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btncadastrarfuncionario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncadastrarfuncionario.BorderRadius = 20;
            this.btncadastrarfuncionario.BorderSize = 0;
            this.btncadastrarfuncionario.FlatAppearance.BorderSize = 0;
            this.btncadastrarfuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncadastrarfuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrarfuncionario.ForeColor = System.Drawing.Color.White;
            this.btncadastrarfuncionario.Location = new System.Drawing.Point(987, 584);
            this.btncadastrarfuncionario.Name = "btncadastrarfuncionario";
            this.btncadastrarfuncionario.Size = new System.Drawing.Size(221, 69);
            this.btncadastrarfuncionario.TabIndex = 32;
            this.btncadastrarfuncionario.Text = "Cadastrar";
            this.btncadastrarfuncionario.TextColor = System.Drawing.Color.White;
            this.btncadastrarfuncionario.UseVisualStyleBackColor = false;
            this.btncadastrarfuncionario.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnome.Location = new System.Drawing.Point(43, 120);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(93, 34);
            this.lblnome.TabIndex = 26;
            this.lblnome.Text = "Nome";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(43, 181);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(329, 31);
            this.txtNome.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(43, 324);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 31);
            this.txtEmail.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(423, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 34);
            this.label2.TabIndex = 38;
            this.label2.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSexo.Location = new System.Drawing.Point(423, 181);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(329, 31);
            this.txtSexo.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(438, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "CPF-CNPJ";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPFCNPJ.Location = new System.Drawing.Point(423, 324);
            this.txtCPFCNPJ.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(329, 31);
            this.txtCPFCNPJ.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(812, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 34);
            this.label5.TabIndex = 42;
            this.label5.Text = "Função";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFuncao.Location = new System.Drawing.Point(812, 181);
            this.txtFuncao.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(329, 31);
            this.txtFuncao.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(812, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 34);
            this.label6.TabIndex = 44;
            this.label6.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCelular.Location = new System.Drawing.Point(812, 324);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(329, 31);
            this.txtCelular.TabIndex = 43;
            // 
            // botaobgm1
            // 
            this.botaobgm1.BackColor = System.Drawing.Color.MidnightBlue;
            this.botaobgm1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.botaobgm1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botaobgm1.BorderRadius = 20;
            this.botaobgm1.BorderSize = 0;
            this.botaobgm1.FlatAppearance.BorderSize = 0;
            this.botaobgm1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.botaobgm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaobgm1.ForeColor = System.Drawing.Color.White;
            this.botaobgm1.Location = new System.Drawing.Point(749, 584);
            this.botaobgm1.Name = "botaobgm1";
            this.botaobgm1.Size = new System.Drawing.Size(221, 69);
            this.botaobgm1.TabIndex = 45;
            this.botaobgm1.Text = "Cadastrar Login";
            this.botaobgm1.TextColor = System.Drawing.Color.White;
            this.botaobgm1.UseVisualStyleBackColor = false;
            this.botaobgm1.Click += new System.EventHandler(this.botaobgm1_Click);
            // 
            // CadastroFuncionarioScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 665);
            this.Controls.Add(this.botaobgm1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCPFCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncadastrarfuncionario);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CadastroFuncionarioScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFuncionarioScreen";
            this.Load += new System.EventHandler(this.CadastroFuncionarioScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private BotaoPersonalizado.BotaoBGM btncadastrarfuncionario;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPFCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCelular;
        private BotaoPersonalizado.BotaoBGM botaobgm1;
    }
}