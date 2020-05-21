using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Capacity = 20;
            al.Add(3);
            al.Add("Mohammad");
            al.Add(3.75);
            al.Add(new Student { Name= "Ahmad", Family = "Rezaei"});
            al.Add(3);
            al.Add("Mohammad");
            al.Add(3.75);
            al.Add(3);
            al.Add("Mohammad");
            al.Add(3.75);
            //Console.WriteLine(al.Contains(4));
            //Console.WriteLine(al.Contains(3.75));
            //Console.WriteLine(al.IndexOf(4));
            al.Insert(2, "Reza");
            al.Remove(3);
            al.RemoveAt(2);
            al.RemoveRange(2, 3);
            Console.WriteLine(al.Capacity);
            Console.WriteLine(al.Count);
            //al.Capacity = al.Count;
            al.TrimToSize();
            Console.WriteLine(al.Capacity);
            //Console.WriteLine(al[2]);
            Console.Read();
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
