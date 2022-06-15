using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DataLabs_TheCompany
{
    public class DBManager
    {
        public OleDbConnection Con;

        public void StartDB()
        {
            string connectionString = Properties.Settings.Default.Database1ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("The application has connected to the database successfully.");
            }
        }
    }
}
