
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
            this.btnVoltarOcorrencias.Size = new System.Drawing.Size(152, 49);
            this.btnVoltarOcorrencias.TabIndex = 1;
            this.btnVoltarOcorrencias.Text = "Voltar";
            this.btnVoltarOcorrencias.UseVisualStyleBackColor = false;
            this.btnVoltarOcorrencias.Click += new System.EventHandler(this.btnVoltarOcorrencias_Click);
            // 
            // Ocorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1014, 586);
            this.Controls.Add(this.btnVoltarOcorrencias);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Ocorrencias";
            this.Text = "Ocorrencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltarOcorrencias;
    }
}