using BGM_FORMS.Control;
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
    public partial class EditaOcorencia : Form
    {
        public EditaOcorencia()
        {
            InitializeComponent();
        }

        private void btnVoltarAdicionar_Click(object sender, EventArgs e)
        {
            new Ocorrencias().Show();
            this.Close();
        }

        private void cbfisico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbfisico.Checked)
            {
                txtCNPJ.Visible = false;
                txtCPF.Visible = true;
                cbjuridico.Checked = false;
            }
        }

        private void cbjuridico_CheckedChanged(object sender, EventArgs e)
        {
            if (cbjuridico.Checked)
            {
                txtCNPJ.Visible = true;
                txtCPF.Visible = false;
                cbfisico.Checked = false;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Ocorrencias().Show();
            this.Close();
        }
    }
}
