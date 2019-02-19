using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindForms
{
    public partial class Form1 : Form
    {
        DataTable dataSubject;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string name = DataAdapter_subject.GetLastName(8);
            //textBox1.Text = name;

            //Načtu si data z databáze
            dataSubject = DataAdapter_subject.GetTable();

            //Přiřadím datovou tabulku ke gridu
            dataGridView1.DataSource = dataSubject;
        }
    }
}
