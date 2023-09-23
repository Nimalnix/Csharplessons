using System.Diagnostics;
using Microsoft.Data.SqlClient;
namespace FirstMvcApp.Models
{
    //datafirstapproch
    public class sqlhelper
    {

        public static SqlConnection CreateConnection()//connection factory
        {
            var connString = @"server=200411LTP2749\SQLEXPRESS;database = testdb;integrated security=true;Encrypt=false";

            SqlConnection sqlcn=new SqlConnection(connString);
            return sqlcn;
        }
    }
}
