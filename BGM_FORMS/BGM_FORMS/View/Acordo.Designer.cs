
namespace BGM_FORMS.View
{
    partial class Acordo
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
            this.btnfecharOcorrencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfecharOcorrencia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnfecharOcorrencia.Location = new System.Drawing.Point(898, 16);
            this.btnfecharOcorrencia.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnfecharOcorrencia.Name = "btnfecharOcorrencia";
            this.btnfecharOcorrencia.Size = new System.Drawing.Size(87, 54);
            this.btnfecharOcorrencia.TabIndex = 1;
            this.btnfecharOcorrencia.Text = "X";
            this.btnfecharOcorrencia.UseVisualStyleBackColor = true;
            this.btnfecharOcorrencia.Click += new System.EventHandler(this.btnfecharOcorrencia_Click);
            // 
            // Acordo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 586);
            this.Controls.Add(this.btnfecharOcorrencia);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Acordo";
            this.Text = "Acordo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfecharOcorrencia;
    }
}