using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Revision
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new TestForm());

            //Complex a = new Complex(4, 8);
            //Complex b = new Complex(3, 9);
            //Complex c = b + a;
        }
    }
}
