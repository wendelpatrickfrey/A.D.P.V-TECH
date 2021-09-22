﻿using BGM_FORMS.Control;
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
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (txtsenha.Text == txtConfirmaSenha.Text)
            {
                if (cbFuncao.Text == "Admin")
                {
                    temp = 1;
                    Controller.InsereCadastro(txtnome.Text, txtusuario.Text, txtsenha.Text,temp);
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
        public void Clear()
        {
            txtnome.Clear();
            txtusuario.Clear();
            txtsenha.Clear();
            txtConfirmaSenha.Clear();
            cbFuncao.Text = "";
        }
    }
}
