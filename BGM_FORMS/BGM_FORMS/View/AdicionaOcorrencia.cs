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
            int status;
            if (cbfisico.Checked)
            {
                status = 1;
                if (Controller.InsereOcorrencia(txtNumero.Text, txtData.Text, Convert.ToDouble(txtValor.Text), status, txtTerceiro.Text, txtCPF.Text, txtCNPJ.Text, txtCNH.Text, txtRenavam.Text, txtEmail.Text, txtTelefone.Text, txtCEP.Text))
                {
                    Controller.InsereTerceiro(status, txtTerceiro.Text, txtCPF.Text, txtCNPJ.Text, txtCNH.Text, txtRenavam.Text, txtEmail.Text, txtTelefone.Text, txtCEP.Text);

                    Controller.InsereOcorrencia(txtNumero.Text, txtData.Text, Convert.ToDouble(txtValor.Text), status, txtTerceiro.Text, txtCPF.Text, txtCNPJ.Text, txtCNH.Text, txtRenavam.Text, txtEmail.Text, txtTelefone.Text, txtCEP.Text);

                    MessageBox.Show("Ocorrencia cadastrada com sucesso");

                }
                else
                {
                    MessageBox.Show("Erro na requisição");
                }
            }
            else if (cbjuridico.Checked)
            {
                status = 0;
                if (Controller.InsereOcorrencia(txtNumero.Text, txtData.Text, Convert.ToDouble(txtValor.Text), status, txtTerceiro.Text, txtCPF.Text, txtCNPJ.Text, txtCNH.Text, txtRenavam.Text, txtEmail.Text, txtTelefone.Text, txtCEP.Text))
                {
                    Controller.InsereTerceiro(status, txtTerceiro.Text, txtCPF.Text, txtCNPJ.Text, txtCNH.Text, txtRenavam.Text, txtEmail.Text, txtTelefone.Text, txtCEP.Text);

                    Controller.InsereOcorrencia(txtNumero.Text, txtData.Text, Convert.ToDouble(txtValor.Text), status, txtTerceiro.Text, txtCPF.Text, txtCNPJ.Text, txtCNH.Text, txtRenavam.Text, txtEmail.Text, txtTelefone.Text, txtCEP.Text);

                    MessageBox.Show("Ocorrencia cadastrada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro na requisição");
                }
            }
        }//Adiciona a ocorrência
    }
}
