using BGM_FORMS.Control;
using BGM_FORMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGM_FORMS
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroLoginScreen().Show();
            this.Hide();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            bool funcao = Controller.Login(txtusuario.Text, txtsenha.Text);
            if (funcao)
            {
                new MenuScreen().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("credenciais incorretas");
            }
            txtusuario.Clear();
            txtsenha.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtsenha.PasswordChar = '\0';
            }
            else
            {
                txtsenha.PasswordChar = '*';
            }
        }
    }
}
