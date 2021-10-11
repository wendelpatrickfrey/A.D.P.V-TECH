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
    public partial class CadastroLoginScreen : Form
    {
        public CadastroLoginScreen()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtnome.Clear();
            txtusuario.Clear();
            txtsenha.Clear();
            txtConfirmaSenha.Clear();
        }//Limpa as textbox
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtsenha.PasswordChar = '\0';
                txtConfirmaSenha.PasswordChar = '\0';
            }
            else
            {
                txtsenha.PasswordChar = '*';
                txtConfirmaSenha.PasswordChar = '*';
            }
        }//Checkbox mostrar senha
        private void btncadastrar_Click(object sender, EventArgs e)//Botão de cadastro
        {

            if (txtsenha.Text == txtConfirmaSenha.Text)
            {
                Controller.InsereCadastro(txtusuario.Text, txtsenha.Text);
                MessageBox.Show("Login cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("As senhas não coincidem");
            }
        }

        private void btnvoltarcadastro_Click(object sender, EventArgs e)
        {
            new MenuScreen().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MenuScreen().Show();
            this.Close();
        }
    }
}
