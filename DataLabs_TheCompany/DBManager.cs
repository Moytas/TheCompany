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

        public string StartDB()
        {
            string returnString = "Error";

            string connectionString = Properties.Settings.Default.MyDbConnectionString;
            Console.WriteLine(connectionString);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                returnString = "The application has connected to the database successfully.";
            }

            return returnString;
        }
    }
}
