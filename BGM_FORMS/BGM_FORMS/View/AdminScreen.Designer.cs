
namespace BGM_FORMS.View
{
    partial class AdminScreen
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
            this.btnfecharadm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfecharadm
            // 
            this.btnfecharadm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfecharadm.Location = new System.Drawing.Point(902, 12);
            this.btnfecharadm.Name = "btnfecharadm";
            this.btnfecharadm.Size = new System.Drawing.Size(91, 53);
            this.btnfecharadm.TabIndex = 1;
            this.btnfecharadm.Text = "X";
            this.btnfecharadm.UseVisualStyleBackColor = true;
            this.btnfecharadm.Click += new System.EventHandler(this.btnfecharadm_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 586);
            this.Controls.Add(this.btnfecharadm);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnfecharadm;
    }
}