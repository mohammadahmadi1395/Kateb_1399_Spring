using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);

            byte[] a = new byte[] { 60 }; //0 + 0 + 32 + 16 + 8 + 4 + 0 + 0 (00111100)
            byte[] b = new byte[] { 13 }; //0 + 0 + 0  +  0 + 8 + 4 + 0 + 1 (00001101)
                                                                          // 00001100
                                                                          // 00110001

            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            Console.WriteLine("Bit Array ba1 : 60");
            //for (int i = 0; i < ba1.Count; i++)
            //    Console.WriteLine("{0,-6}", ba1[i]);
            foreach (var bit in ba1)
                Console.WriteLine("{0,-6}", bit);

            Console.WriteLine("Bit Array ba2 : 13");
            //for (int i = 0; i < ba1.Count; i++)
            //    Console.WriteLine("{0,-6}", ba2[i]);
            foreach (var bit in ba2)
                Console.WriteLine("{0,-6}", bit);

            BitArray ba3 = new BitArray(8);
            ba3 = ba1.Xor(ba2);
            Console.WriteLine("Bit Array ba3 : 49");
            foreach (var bit in ba3)
                Console.WriteLine("{0,-6}", bit);

            Console.Read();
        }
    }
}
