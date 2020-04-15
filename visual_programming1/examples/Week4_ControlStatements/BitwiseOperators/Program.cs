using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Please Enter x and y:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} & {1} = {2}",x, y, x & y); // 1
            Console.WriteLine("{0} | {1} = {2}", x, y, x | y); // 7
            Console.WriteLine("{0} ^ {1} = {2}", x, y, x ^ y); // 6
            Console.ReadKey();

            String s1;
            //if (x < 10)
            //    s1 = "hi";
            //else
            //    s1 = "bye";

            s1 = (x < 10) ? "hi" : "bye";
        }
    }
}
