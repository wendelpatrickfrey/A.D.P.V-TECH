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
        public static bool InsereCadastro(string nome,string usuario,string senha, int funcao)
        {
            string insert = $"INSERT into dbo.CadastroBGM (Nome,Usuario,Senha,Funcao) values ('{nome}','{usuario}','{senha}',{funcao})";
            SqlCommand cmd = new SqlCommand(insert, DBConnection.Connection);
            DBConnection.Connection.Open();
            cmd.ExecuteNonQuery();
            DBConnection.Connection.Close();

            return true;
        }
        public static int Login(string usuario, string senha)
        {
            int temp = 0;
            string select = $"SELECT Funcao from dbo.CadastroBGM WHERE Usuario = '{usuario}' AND Senha = '{senha}'";
            SqlCommand cmd = new SqlCommand(select,DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                temp = Convert.ToInt32(dr[0]);
            }
            else
            {
               temp = -1;
            }
            dr.Close();
            DBConnection.Connection.Close();
            return temp;
        }
    }
}
