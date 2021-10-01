
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
            this.btnVoltarOcorrencias = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.DGVocorrencias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVocorrencias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarOcorrencias
            // 
            this.btnVoltarOcorrencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltarOcorrencias.BackColor = System.Drawing.Color.Tomato;
            this.btnVoltarOcorrencias.FlatAppearance.BorderSize = 0;
            this.btnVoltarOcorrencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarOcorrencias.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarOcorrencias.ForeColor = System.Drawing.Color.White;
            this.btnVoltarOcorrencias.Location = new System.Drawing.Point(12, 525);
            this.btnVoltarOcorrencias.Name = "btnVoltarOcorrencias";
            this.btnVoltarOcorrencias.Size = new System.Drawing.Size(126, 49);
            this.btnVoltarOcorrencias.TabIndex = 1;
            this.btnVoltarOcorrencias.Text = "Voltar";
            this.btnVoltarOcorrencias.UseVisualStyleBackColor = false;
            this.btnVoltarOcorrencias.Click += new System.EventHandler(this.btnVoltarOcorrencias_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.Green;
            this.btnadicionar.FlatAppearance.BorderSize = 0;
            this.btnadicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadicionar.ForeColor = System.Drawing.Color.White;
            this.btnadicionar.Location = new System.Drawing.Point(100, 31);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(181, 60);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "ADICIONAR";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btneditar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(431, 31);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(181, 60);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btnremover
            // 
            this.btnremover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnremover.BackColor = System.Drawing.Color.Red;
            this.btnremover.FlatAppearance.BorderSize = 0;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Location = new System.Drawing.Point(765, 31);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(181, 60);
            this.btnremover.TabIndex = 4;
            this.btnremover.Text = "REMOVER";
            this.btnremover.UseVisualStyleBackColor = false;
            // 
            // DGVocorrencias
            // 
            this.DGVocorrencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVocorrencias.BackgroundColor = System.Drawing.Color.White;
            this.DGVocorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVocorrencias.GridColor = System.Drawing.Color.RoyalBlue;
            this.DGVocorrencias.Location = new System.Drawing.Point(54, 124);
            this.DGVocorrencias.Name = "DGVocorrencias";
            this.DGVocorrencias.RowTemplate.Height = 25;
            this.DGVocorrencias.Size = new System.Drawing.Size(929, 382);
            this.DGVocorrencias.TabIndex = 5;
            // 
            // Ocorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 586);
            this.Controls.Add(this.DGVocorrencias);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btnVoltarOcorrencias);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Ocorrencias";
            this.Text = "Ocorrencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ocorrencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVocorrencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltarOcorrencias;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.DataGridView DGVocorrencias;
    }
}