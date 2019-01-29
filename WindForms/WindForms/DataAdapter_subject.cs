using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindForms
{
    class DataAdapter_subject
    {
        public static string GetName()
        {
            return "";
        }

        public static string GetName(Int32 id)
        {
            Connect();
            SqlCommand com = new SqlCommand("Select * from table where id =" + id);
            // through parameter, value
            com.Parameters.AddWithValue("@id", id);

            // through parametr, value data type
            com.Parameters.Add("@type",SqlDbType.SmallInt);
            com.Parameters["@type"].Value = 2;

            //Call function
            string output = Convert.ToString(com.ExecuteScalar());

            return "Name: " + output;
        }

        public static string Command(string command)
        {
            Connect();
            
            
            return "";
        }

        static void Connect()
        {
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.DataSource = "webdev.spsejecna.cz,11433";
            connString.InitialCatalog = "dinh";
            connString.UserID = "dinh";
            connString.Password = "pvDinh2019";
            SqlConnection con = new SqlConnection(connString.ConnectionString);
            con.Open();
        }

        static void Connect(string DataSource, string InitialCatalog, string UserID, string Password)
        {
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.DataSource = DataSource;
            connString.InitialCatalog = InitialCatalog;
            connString.UserID = UserID;
            connString.Password = Password;
            SqlConnection con = new SqlConnection(connString.ConnectionString);
            con.Open();
        }
    }
}
