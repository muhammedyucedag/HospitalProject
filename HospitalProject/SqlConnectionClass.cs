using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HospitalProject
{
    internal class SqlConnectionClass // Sınıfımın Adı
    {
        public SqlConnection connection() // Metodumun Adı 
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-M8JLN9L\\SQLEXPRESS;Initial Catalog=hospitalproject;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
