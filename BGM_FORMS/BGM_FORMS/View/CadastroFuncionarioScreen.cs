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
    public partial class CadastroFuncionarioScreen : Form
    {
        public CadastroFuncionarioScreen()
        {
            InitializeComponent();
        }

        private void CadastroFuncionarioScreen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            Controller.InsereFuncionario(txtNome.Text, txtSexo.Text, txtFuncao.Text, txtCPFCNPJ.Text, txtCelular.Text, txtEmail.Text);
            MessageBox.Show("Funcionário cadastrado com sucesso");

        }

        private void botaobgm1_Click(object sender, EventArgs e)
        {
            new CadastroLoginScreen().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MenuScreen().Show();
            this.Close();
        }
    }
}
