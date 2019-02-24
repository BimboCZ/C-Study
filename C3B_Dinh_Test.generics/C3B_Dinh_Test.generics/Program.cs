using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3B_Dinh_Test.generics
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<DateTime, string> mess = new SortedList<DateTime, string>(new DescendedDateComparer());

            bool closeApp = true;
            do
            {
                Console.Write("Chcete pridat zpravu?: ");
                string zpr = Console.ReadLine();
                Console.WriteLine();
                if (zpr == "0" || zpr == "cancel" || zpr == "exit" || zpr == "ne")
                {
                    Console.WriteLine("Adios !");
                    closeApp = false;
                    break;
                }
                mess.Add(DateTime.Now, zpr);

            } while (closeApp);
            foreach (KeyValuePair<DateTime, string> s in mess)
            {
                Console.WriteLine(s.Value + " " + s.Key);
            }
        }
        class DescendedDateComparer : IComparer<DateTime>
        {
            public int Compare(DateTime x, DateTime y)
            {
                // use the default comparer to do the original comparison for datetimes
                int ascendingResult = Comparer<DateTime>.Default.Compare(x, y);

                // turn the result around
                return 0 - ascendingResult;
            }
        }
    }
}

