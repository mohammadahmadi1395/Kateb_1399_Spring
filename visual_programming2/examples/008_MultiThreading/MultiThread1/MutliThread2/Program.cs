using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MutliThread2
{
    class Program
    {
        static void Main(string[] args)
        {
            //work1();
            //work2();
            Thread firstThread = new Thread(work1);
            Thread secondThread = new Thread(work2);
            firstThread.Start();
            secondThread.Start();

            Console.Read();
        }
        static void work1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work1 thread is running ... {0}", i);
                Thread.Sleep(100);
            }
        }
        static void work2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work2 thread is running ... {0}", i);
                Thread.Sleep(100);
            }
        }
    }
}
