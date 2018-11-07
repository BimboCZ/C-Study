using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Collections c = new Collections();
            c.ListArray();
            c.LinedListArray();

            Dic d = new Dic();
            d.Dictions();

            Console.ReadKey();
        }
    }
    class Collections
    {
        int x = 5;
        public void ListArray()
        {
            List<int> list = new List<int>();
            list.Add(8);
            list.Add(4);
            list.Add(6);
            Console.WriteLine("List");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ", ");
            }
            Console.WriteLine();

            foreach (int x in list)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();
        }
        public void LinedListArray()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(x);
            linkedList.AddLast(x + 8);
            //linkedList.AddBefore() ??
            //linkedList.AddAfter() ??
            
        }
    }
    class Dic
    {
        //<key,value>
        //key -> cant be repeated
        //value -> can be repeated
        public void Dictions()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("cat", "Kocka");
            Console.WriteLine("\nDictionary");
            foreach (KeyValuePair<string, string> kvp in d)
            {
                Console.WriteLine(kvp.Key + ", " + kvp.Value);
            }
        }
    }
}
