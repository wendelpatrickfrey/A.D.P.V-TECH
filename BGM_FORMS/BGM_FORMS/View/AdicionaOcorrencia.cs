using BGM_FORMS.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGM_FORMS.View
{
    public partial class AdicionaOcorrencia : Form
    {
        public AdicionaOcorrencia()
        {
            InitializeComponent();
        }

        private void AdicionaOcorrencia_Load(object sender, EventArgs e)
        {
            cbfisico.Checked = true;
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

        private void btnVoltarAdicionar_Click(object sender, EventArgs e)
        {
            new Ocorrencias().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Ocorrencias().Show();
            this.Close();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            

            //Controller.InsereOcorrencia(19870130, 19870130, txtnumeroocorrencia.Text, 182392.20/* Convert.ToDouble(txtValor.Text.Replace('.', ',').ToString(CultureInfo.InvariantCulture))*/);
            //MessageBox.Show("Ocorrência cadastrado com sucesso");


        }//Adiciona a ocorrência
    }
}
