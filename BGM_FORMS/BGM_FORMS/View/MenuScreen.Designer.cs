
namespace BGM_FORMS.View
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.lblNomeVazio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgdocumentomenu = new System.Windows.Forms.PictureBox();
            this.painelOcorrencias = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgmaosacordos = new System.Windows.Forms.PictureBox();
            this.imgmarteloajuizado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgdocumentomenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmaosacordos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmarteloajuizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.Color.White;
            this.MenuLateral.Controls.Add(this.button1);
            this.MenuLateral.Controls.Add(this.lblNomeVazio);
            this.MenuLateral.Controls.Add(this.label1);
            this.MenuLateral.Controls.Add(this.imgdocumentomenu);
            this.MenuLateral.Controls.Add(this.painelOcorrencias);
            this.MenuLateral.Controls.Add(this.label3);
            this.MenuLateral.Controls.Add(this.label2);
            this.MenuLateral.Controls.Add(this.imgmaosacordos);
            this.MenuLateral.Controls.Add(this.imgmarteloajuizado);
            this.MenuLateral.Controls.Add(this.pictureBox1);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.ForeColor = System.Drawing.Color.White;
            this.MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(200, 586);
            this.MenuLateral.TabIndex = 0;
            // 
            // lblNomeVazio
            // 
            this.lblNomeVazio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNomeVazio.AutoSize = true;
            this.lblNomeVazio.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeVazio.ForeColor = System.Drawing.Color.Black;
            this.lblNomeVazio.Location = new System.Drawing.Point(86, 511);
            this.lblNomeVazio.Name = "lblNomeVazio";
            this.lblNomeVazio.Size = new System.Drawing.Size(55, 24);
            this.lblNomeVazio.TabIndex = 10;
            this.lblNomeVazio.Text = "aaaaa";
            this.lblNomeVazio.Click += new System.EventHandler(this.lblNomeVazio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ocorrências";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imgdocumentomenu
            // 
            this.imgdocumentomenu.Image = ((System.Drawing.Image)(resources.GetObject("imgdocumentomenu.Image")));
            this.imgdocumentomenu.Location = new System.Drawing.Point(7, 121);
            this.imgdocumentomenu.Name = "imgdocumentomenu";
            this.imgdocumentomenu.Size = new System.Drawing.Size(74, 75);
            this.imgdocumentomenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgdocumentomenu.TabIndex = 2;
            this.imgdocumentomenu.TabStop = false;
            this.imgdocumentomenu.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // painelOcorrencias
            // 
            this.painelOcorrencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelOcorrencias.AutoSize = true;
            this.painelOcorrencias.Location = new System.Drawing.Point(197, 0);
            this.painelOcorrencias.Name = "painelOcorrencias";
            this.painelOcorrencias.Size = new System.Drawing.Size(823, 589);
            this.painelOcorrencias.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ajuizados";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Acordos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // imgmaosacordos
            // 
            this.imgmaosacordos.Image = ((System.Drawing.Image)(resources.GetObject("imgmaosacordos.Image")));
            this.imgmaosacordos.Location = new System.Drawing.Point(7, 232);
            this.imgmaosacordos.Name = "imgmaosacordos";
            this.imgmaosacordos.Size = new System.Drawing.Size(72, 75);
            this.imgmaosacordos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgmaosacordos.TabIndex = 5;
            this.imgmaosacordos.TabStop = false;
            this.imgmaosacordos.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // imgmarteloajuizado
            // 
            this.imgmarteloajuizado.Image = ((System.Drawing.Image)(resources.GetObject("imgmarteloajuizado.Image")));
            this.imgmarteloajuizado.Location = new System.Drawing.Point(7, 345);
            this.imgmarteloajuizado.Name = "imgmarteloajuizado";
            this.imgmarteloajuizado.Size = new System.Drawing.Size(70, 70);
            this.imgmarteloajuizado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgmarteloajuizado.TabIndex = 3;
            this.imgmarteloajuizado.TabStop = false;
            this.imgmarteloajuizado.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1014, 586);
            this.Controls.Add(this.MenuLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MenuScreen";
            this.Text = "MenuScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.MenuLateral.ResumeLayout(false);
            this.MenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgdocumentomenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmaosacordos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmarteloajuizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgmarteloajuizado;
        private System.Windows.Forms.PictureBox imgmaosacordos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel painelOcorrencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgdocumentomenu;
        private System.Windows.Forms.Label lblNomeVazio;
        private System.Windows.Forms.Button button1;
    }
}