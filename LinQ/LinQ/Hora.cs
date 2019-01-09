using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Hora
    {
        string jmeno;
        int vyska;

        public int Vyska { get { return vyska; }}
        public string Jmeno { get; set; }

        public Hora(string jmeno, int vyska)
        {
            this.jmeno = jmeno;
            this.vyska = vyska;
        }

        public override string ToString()
        {
            return "Hora:" + jmeno + " Vyska:" + vyska;
        }
    }

    class Pohori 
    {
        string jmeno_pohori;
        List<Hora> hory;

        public List<Hora> Hory { get; }
        int pocetHor = 1;

        public Pohori(string jmeno_pohori)
        {
            this.jmeno_pohori = jmeno_pohori;
            hory = new List<Hora>();
        }

        public void PridejHoru(string jmeno, int vyska)
        {
            hory.Add(new Hora(jmeno, vyska));
        }

        public int PocetPohori()
        {
            return hory.Count;
        }

        public void VypisSerazeneHory()
        {
            var sortMount = from h in hory
                            orderby h.Vyska descending
                            select h;

            foreach (Hora h in sortMount)
            {
                Console.WriteLine(h.ToString());
            }
            Console.WriteLine();
        }

        public void VypisHoryNad(int par)
        {
            var sortMount = from h in hory
                            where h.Vyska > par
                            select h;
            foreach(Hora h in sortMount)
            {
                Console.WriteLine(h.ToString());
            }
            Console.WriteLine();
        }

        public void VypisHory()
        {
            foreach (Hora h in hory)
            {
                Console.WriteLine(h.ToString() + " " + pocetHor);
                pocetHor++;
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Pohori: " + jmeno_pohori + "\n";
        }
    }
}
