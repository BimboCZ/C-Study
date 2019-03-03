using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            string name = DA_subject.GetName(8);

            LastName_Value.Text = name;

            //Načtu si data z databáze
            dataSubject = DA_subject.GetTable(8);

            //
            BindingSource datovyZdroj = new BindingSource(dataSubject, null);

            textBox2.DataBindings.Add("Text", datovyZdroj, "last_name");

            //Přiřadím datovou tabulku ke gridu
            dataGridView1.DataSource = datovyZdroj;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
