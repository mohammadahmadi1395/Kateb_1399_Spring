using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_Constraint
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student max = Maximum(new Student { Name = "Reza", Family = "Hamidi" },
            //                      new Student { Name = "Fateme", Family = "Hasani" },
            //                      new Student { Name = "Gholi", Family = "Osgol" });

            string max = Maximum("Reza", "Fateme", "Gholi");
            Console.WriteLine(max);
        }

        //x y z
        //max = x
        //    if (y > max)
        //    max = y;
        //    if (z > max)
        //    max = z;
        public static T Maximum<T>(T t1, T t2, T t3)
            where T : IComparable
        {
            T max = t1;
            if (t2.CompareTo(max) > 0)
                max = t2;
            if (t3.CompareTo(max) > 0)
                max = t3;
            return max;
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
