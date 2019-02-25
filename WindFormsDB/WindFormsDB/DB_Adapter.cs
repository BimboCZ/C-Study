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

        public static void DB_Connect()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                //Do something

                MessageBox.Show("Open");
                conn.Close();
                MessageBox.Show("Closed");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
