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
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            //btnMenu.Parent = MenuAcima;
            //btnMenu.BackColor = Color.Transparent;
        }

        private void botaoteste_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminScreen());


        }
        //Abrir forms dentro do forms
        private Form activeform = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            painelteste.Controls.Add(ChildForm);
            painelteste.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openChildForm(new Ocorrencias());

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuLateral.Width == 77)
            {
                MenuLateral.Width = 200;
            }
            else
            {
                MenuLateral.Width = 77;
            }
        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openChildForm(new Acordo());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openChildForm(new Ajuizado());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroScreen().Show();
            this.Hide();
        }
    }
}
