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

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Ocorrencias().Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Acordo().Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Ajuizado().Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new CadastroScreen().Show();
            this.Close();
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














    }
}
