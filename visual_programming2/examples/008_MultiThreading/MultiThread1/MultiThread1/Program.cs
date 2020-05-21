using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThread1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 
            // myFunction();
            
            //2. 
            // ThreadStart start = new ThreadStart(myFunction);
            //Thread myThread = new Thread(start);
            
            // 3.
            Thread myThread = new Thread(myFunction);
            myThread.Start();

            Console.WriteLine("My thread is running");

            Thread current = Thread.CurrentThread;
            Console.WriteLine("current thread name is {0}", current.Name);

            current.Name = "MainThread";
            Console.WriteLine("current thread name is {0}", current.Name);

            Console.Read();
        }

        static void myFunction()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
