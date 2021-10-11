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
    public partial class RemoveOcorrencia : Form
    {
        public RemoveOcorrencia()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Ocorrencias().Show();
            this.Close();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {

        }
    }
}
