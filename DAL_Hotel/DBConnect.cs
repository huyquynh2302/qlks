using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DAL_Hotel
{


    public class DBConnect
    {
         protected MySqlConnection con2 =  new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=testdb;");
        //protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B182N8G\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True");
    }
}
