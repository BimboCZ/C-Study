using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Pohori p = new Pohori("Alpy");
            p.PridejHoru("Matterhorn", 4478);
            p.PridejHoru("dawd", 2465);
            p.PridejHoru("hhfawdad", 3217);
            p.PridejHoru("sda", 5456);
            p.PridejHoru("asdttwe", 212);

            p.VypisSerazeneHory();
            p.VypisHoryNad(1000);
            Console.WriteLine("Pocet Hor: " + p.PocetPohori());
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
