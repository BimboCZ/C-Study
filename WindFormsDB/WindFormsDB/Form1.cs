using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindFormsDB
{
    public partial class Form1 : Form
    {
        DataTable dataSubject;
        public Form1()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dataGridView1.AutoGenerateColumns = false;

            //Načtu si data z databáze
            dataSubject = DB_Adapter.GetTable();

            BindingSource datZdroj = new BindingSource(dataSubject, null);

            textBox1.DataBindings.Add("Text", dataSubject, "last_name");

            //Přiřadím datovou tabulku ke gridu
            dataGridView1.DataSource = dataSubject;
        }
    }
}
