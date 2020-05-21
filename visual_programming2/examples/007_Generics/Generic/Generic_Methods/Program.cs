using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5};
            char[] charArray = { 'A', 'f', 'g', 'z'};
            double[] doubleArray = { 1.1, 5.8, 13.5};

            Console.WriteLine("calling intarray displayarray function");
            DisplayArray(intArray);
            Console.WriteLine("calling doublearray displayarray function");
            DisplayArray(doubleArray);
            Console.WriteLine("calling chararray displayarray function");
            DisplayArray(charArray);

            Console.Read();
        }

        public static void DisplayArray<T>(T[] arr)
        {
            Console.WriteLine("I am Generic");

            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }
        }

        public static void DisplayArray(int[] arr)
        {
            Console.WriteLine("I am not Generic");
            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }
        }

        //public static void DisplayArray(double[] arr)
        //{
        //    foreach(var element in arr)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}
        //public static void DisplayArray(char[] arr)
        //{
        //    foreach(var element in arr)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}
    }
}
