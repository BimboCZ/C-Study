using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindFormsDB
{
    class DB_Adapter
    {
        static string connString = ConfigurationManager.ConnectionStrings["WebDev"].ConnectionString;

        public static void DB_Connect(SqlConnection connection, string connString)
        {
            try
            {
                connection = new SqlConnection(connString);
                connection.Open();

                //Do something

                MessageBox.Show("Open");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void DB_Connect(string connString)
        {
            try
            {
                SqlConnection con = new SqlConnection(connString);
                con.Open();

                MessageBox.Show("Open");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void DB_Command(string command, SqlConnection connection)
        {
            DB_Connect(connection, connString);
            SqlCommand com = new SqlCommand(command, connection);
            connection.Close();
        }

        public static void DB_Command(string command)
        {
            DB_Connect(connString);
            SqlCommand com = new SqlCommand(command);
        }

        public static string GetLastName(Int32 id)
        {
            SqlConnection con = new SqlConnection(connString);

            SqlCommand com = new SqlCommand("Select * from table where id =" + id);
            DataTable localTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                con.Open();
                MessageBox.Show("Open");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            // through parameter, value
            com.Parameters.AddWithValue("@id", id);

            // through parametr, value data type
            com.Parameters.Add("@type", SqlDbType.SmallInt);
            com.Parameters["@type"].Value = 2;

            //Call function
            string output = Convert.ToString(com.ExecuteScalar());

            //Adding Select command to DataAdapter
            da.SelectCommand = com;
            da.Fill(localTable);// Fill to localTable

            con.Close();

            return "Name: " + output;

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
            con.Close();

            return localTable;
        }
    }
}
