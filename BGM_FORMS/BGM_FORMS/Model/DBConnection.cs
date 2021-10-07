using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGM_FORMS.Model
{
    public static class DBConnection
    {
        public static MySqlConnection MyConnection { get; } = new MySqlConnection("server=127.0.0.1;user id = root; persistsecurityinfo=True;database=mydb;pwd=root");
        

        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D87;Initial Catalog=BDTurmaTarde;User ID=guest01;Password=@Senac2021");

    }
}
