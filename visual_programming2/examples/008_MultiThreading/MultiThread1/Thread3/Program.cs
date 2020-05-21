using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread3
{
    class Program
    {
        public static void myFunction()
        {
            Console.WriteLine("Child thread starts");
            // the thread is paused for 5000 milliseconds
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        static void Main(string[] args)
        {
            ThreadStart start = new ThreadStart(myFunction);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(start);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
