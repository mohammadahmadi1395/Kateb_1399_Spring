using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "mohammad");
            ht.Add(3, "Fateme");
            ht.Add(2, "reza");

            ht.Remove(1);
            Console.WriteLine(ht.ContainsKey("reza")); // False
            Console.WriteLine(ht.ContainsValue("reza")); // True

            foreach (var key in ht.Keys)
                Console.WriteLine(key);

            Console.Read();
        }
    }
}
