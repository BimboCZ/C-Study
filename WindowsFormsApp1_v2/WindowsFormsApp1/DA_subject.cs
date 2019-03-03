using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DA_subject
    {
        public static string GetName(Int32 id)
        {
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.DataSource = "webdev.spsejecna.cz,11433";
            connString.InitialCatalog = "C3B";
            connString.UserID = "C3B";
            connString.Password = "Developers3*";

            SqlConnection pripojeni;
            pripojeni = new SqlConnection(connString.ConnectionString);
            pripojeni.Open();

            //Příkaz
            SqlCommand prikaz;
            prikaz = new SqlCommand("SELECT last_name FROM sbj_subject WHERE id=@id", pripojeni);

            //Přidání parametru přes hodnotu
            prikaz.Parameters.AddWithValue("@id", id);

            //Přidání parametru přes datový typ
            prikaz.Parameters.Add("@type", SqlDbType.SmallInt);
            prikaz.Parameters["@type"].Value = 2;

            //Vyvolání příkazu
            string returnValue=Convert.ToString(prikaz.ExecuteScalar());

            return returnValue;
        }

        public static DataTable GetTable(Int32 id)
        {
            //Vytvořím si lokální tabulku
            DataTable lokalniTabulka = new DataTable();

            try
            {
                //Připojení k DB
                String connString = ConfigurationManager.ConnectionStrings["WebDev"].ConnectionString;

                SqlConnection pripojeni;
                pripojeni = new SqlConnection(connString);
                pripojeni.Open();

                //Vytvořím si data adapter
                SqlDataAdapter da = new SqlDataAdapter();

                //Přidám příkaz select do data adaptéru
                SqlCommand prikazSelect;
                prikazSelect = new SqlCommand("SELECT * FROM sbj_subject", pripojeni);

                da.SelectCommand = prikazSelect;

                //Pomocí data adapteru  naplníme lokální tabulku
                da.Fill(lokalniTabulka);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lokalniTabulka;
            
        }
    }
}
