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


        //MenuLateral "animação"
        //private void btnMenu_Click(object sender, EventArgs e)
        //{
        //    if (MenuLateral.Width == 77)
        //    {
        //        MenuLateral.Width = 200;
        //    }
        //    else
        //    {
        //        MenuLateral.Width = 77;
        //    }
        //}

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Acordo().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Ocorrencias().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Ajuizado().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeVazio_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroScreen().Show();
            this.Hide();
        }
    }
}
