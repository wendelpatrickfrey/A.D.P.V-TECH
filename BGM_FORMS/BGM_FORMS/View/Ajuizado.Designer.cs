
namespace BGM_FORMS.View
{
    partial class Ajuizado
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
            this.btnfecharOcorrencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfecharOcorrencia
            // 
            this.btnfecharOcorrencia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnfecharOcorrencia.Location = new System.Drawing.Point(707, 12);
            this.btnfecharOcorrencia.Name = "btnfecharOcorrencia";
            this.btnfecharOcorrencia.Size = new System.Drawing.Size(81, 45);
            this.btnfecharOcorrencia.TabIndex = 1;
            this.btnfecharOcorrencia.Text = "X";
            this.btnfecharOcorrencia.UseVisualStyleBackColor = true;
            this.btnfecharOcorrencia.Click += new System.EventHandler(this.btnfecharOcorrencia_Click);
            // 
            // Ajuizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfecharOcorrencia);
            this.Name = "Ajuizado";
            this.Text = "Ajuizado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfecharOcorrencia;
    }
}