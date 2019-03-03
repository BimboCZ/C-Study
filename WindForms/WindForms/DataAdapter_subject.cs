using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Configuration;

namespace WindForms
{
    class DataAdapter_subject
    {
        public static string GetName()
        {
            return "";
        }

        public static DataTable GetTable()
        {

            DataTable localTable = new DataTable();
            // Commands and DataTables
            string conString = @"Data Source=webdev.spsejecna.cz,11433;Initial Catalog=C3B;User ID=C3B;Password=Developers3*";

            //String conString = ConfigurationManager.ConnectionStrings["WebDev"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlCommand com = new SqlCommand("Select * from sbj_subject", con);

            SqlDataAdapter da = new SqlDataAdapter
            {
                //Adding Select command to DataAdapter
                SelectCommand = com
            };
            da.Fill(localTable);// Fill to localTable


            return localTable;
        }

        public static string GetLastName(Int32 id)
        {
            Connect();
            // Commands and DataTables
            SqlCommand com = new SqlCommand("Select * from table where id =" + id);
            SqlCommand comSelect = new SqlCommand("Select * from table where id =" + id);
            DataTable localTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            // through parameter, value
            com.Parameters.AddWithValue("@id", id);

            // through parametr, value data type
            com.Parameters.Add("@type", SqlDbType.SmallInt);
            com.Parameters["@type"].Value = 2;

            //Call function
            string output = Convert.ToString(com.ExecuteScalar());

            //Adding Select command to DataAdapter
            da.SelectCommand = comSelect;
            da.Fill(localTable);// Fill to localTable

            return "Name: " + output;
        }

        public static string GetLastName(string id)
        {
            Connect();
            // Commands and DataTables
            SqlCommand com = new SqlCommand("Select * from table where id =" + id);
            SqlCommand comSelect = new SqlCommand("Select * from table where id =" + id);
            DataTable localTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            // through parameter, value
            com.Parameters.AddWithValue("@id", id);

            // through parametr, value data type
            com.Parameters.Add("@type", SqlDbType.SmallInt);
            com.Parameters["@type"].Value = 2;

            //Call function
            string output = Convert.ToString(com.ExecuteScalar());

            //Adding Select command to DataAdapter
            da.SelectCommand = comSelect;
            da.Fill(localTable);// Fill to localTable

            return "Name: " + output;
        }

        public static void Connect()
        {
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.DataSource = "webdev.spsejecna.cz, 1143";
            connString.InitialCatalog = "C3B";
            connString.UserID = "C3B";
            connString.Password = "Developers3*";
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
