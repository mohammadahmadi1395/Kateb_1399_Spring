using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Variables_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string firstName;
            //age = 20;
            firstName = "Mohammad";

            Console.WriteLine("first name = {0}", firstName);
            //Console.ReadKey();

            Console.WriteLine("Hi {0}. How old are you? ", firstName);
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Good bye \\\"old man\"");
            Console.ReadKey();
        }
    }
}



