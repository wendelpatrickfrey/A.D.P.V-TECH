
namespace BGM_FORMS.View
{
    partial class Ocorrencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ocorrencias));
            this.DGVocorrencias = new System.Windows.Forms.DataGridView();
            this.NumeroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadicionar = new BGM_FORMS.BotaoPersonalizado.BotaoBGM();
            this.btneditar = new BGM_FORMS.BotaoPersonalizado.BotaoBGM();
            this.btnremover = new BGM_FORMS.BotaoPersonalizado.BotaoBGM();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVocorrencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVocorrencias
            // 
            this.DGVocorrencias.AllowUserToAddRows = false;
            this.DGVocorrencias.AllowUserToDeleteRows = false;
            this.DGVocorrencias.AllowUserToOrderColumns = true;
            this.DGVocorrencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVocorrencias.BackgroundColor = System.Drawing.Color.White;
            this.DGVocorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVocorrencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCol,
            this.DataCol,
            this.ValorCol});
            this.DGVocorrencias.GridColor = System.Drawing.Color.RoyalBlue;
            this.DGVocorrencias.Location = new System.Drawing.Point(142, 78);
            this.DGVocorrencias.Name = "DGVocorrencias";
            this.DGVocorrencias.ReadOnly = true;
            this.DGVocorrencias.RowTemplate.Height = 25;
            this.DGVocorrencias.Size = new System.Drawing.Size(946, 452);
            this.DGVocorrencias.TabIndex = 5;
            // 
            // NumeroCol
            // 
            this.NumeroCol.HeaderText = "Numero";
            this.NumeroCol.Name = "NumeroCol";
            this.NumeroCol.ReadOnly = true;
            this.NumeroCol.Width = 200;
            // 
            // DataCol
            // 
            this.DataCol.HeaderText = "Data";
            this.DataCol.Name = "DataCol";
            this.DataCol.ReadOnly = true;
            this.DataCol.Width = 150;
            // 
            // ValorCol
            // 
            this.ValorCol.HeaderText = "Valor";
            this.ValorCol.Name = "ValorCol";
            this.ValorCol.ReadOnly = true;
            this.ValorCol.Width = 150;
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
            this.btnadicionar.Location = new System.Drawing.Point(37, 635);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(223, 59);
            this.btnadicionar.TabIndex = 17;
            this.btnadicionar.Text = "ADICIONAR";
            this.btnadicionar.TextColor = System.Drawing.Color.White;
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btneditar.BackColor = System.Drawing.Color.Peru;
            this.btneditar.BackgroundColor = System.Drawing.Color.Peru;
            this.btneditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btneditar.BorderRadius = 20;
            this.btneditar.BorderSize = 0;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(503, 635);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(223, 59);
            this.btneditar.TabIndex = 18;
            this.btneditar.Text = "EDITAR";
            this.btneditar.TextColor = System.Drawing.Color.White;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click_1);
            // 
            // btnremover
            // 
            this.btnremover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnremover.BackColor = System.Drawing.Color.Peru;
            this.btnremover.BackgroundColor = System.Drawing.Color.Peru;
            this.btnremover.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnremover.BorderRadius = 20;
            this.btnremover.BorderSize = 0;
            this.btnremover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremover.FlatAppearance.BorderSize = 0;
            this.btnremover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Location = new System.Drawing.Point(963, 635);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(223, 59);
            this.btnremover.TabIndex = 19;
            this.btnremover.Text = "REMOVER";
            this.btnremover.TextColor = System.Drawing.Color.White;
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1181, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Ocorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1236, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.DGVocorrencias);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Ocorrencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocorrencias";
            this.Load += new System.EventHandler(this.Ocorrencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVocorrencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVocorrencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCol;
        private BotaoPersonalizado.BotaoBGM btnadicionar;
        private BotaoPersonalizado.BotaoBGM btneditar;
        private BotaoPersonalizado.BotaoBGM btnremover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}