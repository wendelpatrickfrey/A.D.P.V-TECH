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
    public partial class CadastroScreen : Form
    {
        public CadastroScreen()
        {
            InitializeComponent();
        }

        private void CadastroScreen_Load(object sender, EventArgs e)
        {
            cbFuncao.Items.Add("Admin");
            cbFuncao.Items.Add("Analista");
            cbFuncao.Text = "Analista";
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (Controller.ConfereUsuario(txtusuario.Text))
            {

                if (txtsenha.Text == txtConfirmaSenha.Text)
                {
                    if (cbFuncao.Text == "Admin")
                    {
                        temp = 1;
                        Controller.InsereCadastro(txtnome.Text, txtusuario.Text, txtsenha.Text, temp);
                        MessageBox.Show("Administrador adicionado");
                        Clear();
                    }
                    else
                    {
                        Controller.InsereCadastro(txtnome.Text, txtusuario.Text, txtsenha.Text, temp);
                        MessageBox.Show("Analista adicionado");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem");
                }

            }
            else
            {
                MessageBox.Show("Usuario já existente");
            }
        }
        public void Clear()
        {
            txtnome.Clear();
            txtusuario.Clear();
            txtsenha.Clear();
            txtConfirmaSenha.Clear();
            cbFuncao.Text = "";
        }



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
        }
    }
}
