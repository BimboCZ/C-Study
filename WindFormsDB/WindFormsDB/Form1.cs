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
            dataGridView1.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Načtu si data z databáze
            dataSubject = DB_Adapter.GetTable();

            BindingSource datZdroj = new BindingSource(dataSubject, null);

            textBox1.DataBindings.Add("Text", datZdroj, "last_name");

            //Přiřadím datovou tabulku ke gridu
            dataGridView1.DataSource = datZdroj;
        }
    }
}
