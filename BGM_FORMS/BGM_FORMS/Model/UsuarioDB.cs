using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGM_FORMS.Model
{
    class UsuarioDB
    {
        public static void InsereCadastro(string usuario, string senha)
        {
            string insert = $"insert into tcc_bgm.usuario(LOGIN,SENHA,ID_FUNCIONARIO) values ('{usuario}','{senha}',{8})";
            MySqlCommand cmd = new MySqlCommand(insert, DBConnection.Connection);
            DBConnection.Connection.Open();
            cmd.ExecuteNonQuery();
            DBConnection.Connection.Close();

            //return true;
        }
        public static void InsereFuncionario(string nome, string sexo, string funcao, string cpf_cnpj, string celular, string email)
        {
            string insert = $"insert INTO tcc_bgm.funcionario (NOME,SEXO,FUNCAO,CPF_CNPJ,CELULAR,EMAIL)values('{nome}', '{sexo}', '{funcao}', '{cpf_cnpj}', '{celular}', '{email}')";
            MySqlCommand cmd = new MySqlCommand(insert, DBConnection.Connection);
            DBConnection.Connection.Open();
            cmd.ExecuteNonQuery();
            DBConnection.Connection.Close();

            //return true;
        }
        public static bool Login(string login, string senha)
        {
            bool temp = false;
            string select = $"SELECT * from tcc_bgm.usuario WHERE LOGIN = '{login}' AND SENHA = '{senha}'";
            MySqlCommand cmd = new MySqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                temp = true;
            }
            else
            {
                temp = false;
            }
            dr.Close();
            DBConnection.Connection.Close();
            return temp;
        }

        //public static string SelectUsuario(string usuario)
        //{
        //    string confere = "";
        //    string select = $"SELECT Usuario from dbo.CadastroBGM WHERE Usuario = '{usuario}' ";
        //    SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
        //    DBConnection.Connection.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        confere = dr[0].ToString();
        //    }           
        //    dr.Close();
        //    DBConnection.Connection.Close();

        //    return confere;
        //}

    }
}
