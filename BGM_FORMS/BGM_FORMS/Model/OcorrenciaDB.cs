using BGM_FORMS.Control;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGM_FORMS.Model
{
    class OcorrenciaDB
    {
        //public static void InsereOcorrencia(int datai, int dataa, string numero, double valor)
        //{
        //    string insert = $"insert into tcc_bgm.ocorrencia (DATAI,DATAA,NUMERO,VALOR) values ({datai}, {dataa}, '{numero}',{valor})";
        //    MySqlCommand cmd = new MySqlCommand(insert, DBConnection.Connection);
        //    DBConnection.Connection.Open();
        //    cmd.ExecuteNonQuery();
        //    DBConnection.Connection.Close();

        //    //return true;
        //}

        //public static bool InsereTerceiro(int status, string nome, string CPF, string CNPJ, string CNH, string RENAVAM, string EMAIL, string TELEFONE, string CEP)
        //{
        //    string insert = $"INSERT INTO TERCEIRO (STATUS,NOME,CPF,CNPJ,CNH,RENAVAM,EMAIL,TELEFONE,CEP) VALUES ({status},'{nome}','{CPF}','{CNPJ}','{CNH}','{RENAVAM}','{EMAIL}','{TELEFONE}','{CEP}')";

        //    MySqlCommand cmd = new MySqlCommand(insert, DBConnection.MyConnection);

        //    DBConnection.MyConnection.Open();

        //    cmd.ExecuteNonQuery();

        //    DBConnection.MyConnection.Close();

        //    return true;


        //}

        //public static int SelectTerceiro(int status, string nome, string cpf, string CNPJ, string CNH, string RENAVAM, string EMAIL, string TELEFONE, string CEP)
        //{
        //    int idTerceiro = -1;
        //    if (Controller.ConfereCpf(nome, cpf))
        //    {
        //        string select = $"SELECT idTERCEIRO from TERCEIRO WHERE CPF = {cpf}";
        //        MySqlCommand cmd = new MySqlCommand(select, DBConnection.MyConnection);
        //        DBConnection.MyConnection.Open();
        //        MySqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            idTerceiro = Convert.ToInt32(dr[0]);
        //        }
        //        else
        //        {
        //            dr.Close();
        //            DBConnection.MyConnection.Close();
        //            InsereTerceiro(status, nome, cpf, CNPJ, CNH, RENAVAM, EMAIL, TELEFONE, CEP);
        //            select = $"SELECT idTERCEIRO from TERCEIRO WHERE CPF = {cpf}";
        //            cmd = new MySqlCommand(select, DBConnection.MyConnection);
        //            DBConnection.MyConnection.Open();
        //            dr = cmd.ExecuteReader();
        //            if (dr.Read())
        //            {
        //                idTerceiro = Convert.ToInt32(dr[0]);
        //            }
        //        }
        //        dr.Close();
        //        DBConnection.MyConnection.Close();
        //        return idTerceiro;
        //    }
        //    else
        //    {
        //        return idTerceiro;
        //    }

        //}

        //public static int SelectBairro2(string bairro)
        //{
        //    int id = -1;
        //    if (Controller.ConfereBairro(bairro))
        //    {
        //        string select = $"SELECT IDBAIRRO from dbo.ABAIRRO WHERE NOME = '{bairro}'";
        //        SqlCommand cmd = new SqlCommand(select, Connection);
        //        Connection.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            id = Convert.ToInt32(dr[0]);
        //        }
        //        else
        //        {
        //            dr.Close();
        //            Connection.Close();
        //            InsertBairro(bairro);
        //            select = $"SELECT IDBAIRRO from dbo.ABAIRRO WHERE NOME = '{bairro}'";
        //            cmd = new SqlCommand(select, Connection);
        //            Connection.Open();
        //            dr = cmd.ExecuteReader();
        //            if (dr.Read())
        //            {
        //                id = Convert.ToInt32(dr[0]);
        //            }
        //        }
        //        dr.Close();
        //        Connection.Close();
        //        return id;
        //    }
        //    else
        //    {
        //        return id;
        //    }
        //}

        //public static string ConfereCPF(string terceiro)
        //{
        //    string cpf = "";
        //    string select = $"SELECT CPF from TERCEIRO WHERE NOME = '{terceiro}'";
        //    MySqlCommand cmd = new MySqlCommand(select, DBConnection.MyConnection);
        //    DBConnection.MyConnection.Open();
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        cpf = dr[0].ToString();
        //    }
        //    dr.Close();
        //    DBConnection.MyConnection.Close();
        //    return cpf;
        //}

        //public static bool InsereOcorrencia(string numero, string data, double valor, int status, string nome, string cpf, string CNPJ, string CNH, string RENAVAM, string EMAIL, string TELEFONE, string CEP)
        //{
        //    int idterceiro = SelectTerceiro(status, nome, cpf, CNPJ, CNH, RENAVAM, EMAIL, TELEFONE, CEP);
        //    if (Controller.ConfereCpf(nome, cpf))
        //    {


        //        if (idterceiro == -1)
        //        {
        //            return false;
        //        }
        //        else
        //        {

        //            string insert = $"INSERT INTO OCORRENCIA (NUMERO,DATA,VALOR,TERCEIRO_idTERCEIRO) values ('{numero}','{data}',{valor},{idterceiro})";
        //            MySqlCommand cmd = new MySqlCommand(insert, DBConnection.MyConnection);
        //            DBConnection.MyConnection.Open();
        //            cmd.ExecuteNonQuery();
        //            DBConnection.MyConnection.Close();
        //            return true;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }



        //}

        //public static List<string[]> SelecionaOcorrencia()
        //{
        //    List<string[]> lista = new List<string[]>();
        //    string select = "SELECT * from OCORRENCIA";
        //    MySqlCommand cmd = new MySqlCommand(select, DBConnection.MyConnection);
        //    DBConnection.MyConnection.Open();
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        string[] vetor = { dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
        //        lista.Add(vetor);
        //    }
        //    dr.Close();
        //    DBConnection.MyConnection.Close();
        //    return lista;
        //}
        //public static List<string> SelecionaTerceiro(List<string> lista)
        //{
        //    string select = "SELECT * from TERCEIRO";
        //    MySqlCommand cmd = new MySqlCommand(select, DBConnection.MyConnection);
        //    DBConnection.MyConnection.Open();
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        lista.Add(dr.ToString());
        //    }
        //    dr.Close();
        //    DBConnection.MyConnection.Close();
        //    return lista;
        //}
    }
}
