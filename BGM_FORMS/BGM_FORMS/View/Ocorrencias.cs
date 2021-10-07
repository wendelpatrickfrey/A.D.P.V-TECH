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
    public partial class Ocorrencias : Form
    {
        public Ocorrencias()
        {
            InitializeComponent();
        }

       

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarOcorrencias_Click(object sender, EventArgs e)
        {
            new MenuScreen().Show();
            this.Close();
        }

        private void Ocorrencias_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }
        private void AtualizaDG()
        {
            List<string[]> elementos = Controller.SelecionaOcorrencia();
            DGVocorrencias.Rows.Clear();
            foreach (var item in elementos)
            {
                DGVocorrencias.Rows.Add(item);
            }
        }

        

        private void btneditar_Click(object sender, EventArgs e)//Tela Editar ocorrências
        {
            new EditaOcorencia().Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Fechar ocorrências

        private void pictureBox1_Click_1(object sender, EventArgs e)//Botão voltar ocorrências
        {
            new MenuScreen().Show();
            this.Close();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            new AdicionaOcorrencia().Show();
            this.Close();
        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            new EditaOcorencia().Show();
            this.Close();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            new RemoveOcorrencia().Show();
            this.Close();
        }
    }
}
