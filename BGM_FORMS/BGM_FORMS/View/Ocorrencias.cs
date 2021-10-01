using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGM_FORMS.View
{
    public partial class Ocorrencias : Form
    {
        public Ocorrencias()
        {
            InitializeComponent();
        }

       

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarOcorrencias_Click(object sender, EventArgs e)
        {
            new MenuScreen().Show();
            this.Close();
        }

        private void Ocorrencias_Load(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            new AdicionaOcorrencia().Show();
            this.Close();


        }
    }
}
