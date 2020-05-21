using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread is running...");
            Thread myThread = new Thread(myFunction);
            Console.WriteLine("my Thread is starting....");
            myThread.Start();
            Thread.Sleep(2000);
            Console.WriteLine("Aborting myThread");
            myThread.Abort();
            Console.Read();
        }
        static void myFunction()
        {
            for(int counter = 0; counter <= 10; counter++)
            {
                Thread.Sleep(500);
                Console.WriteLine(counter);
            }
        }
    }
    //Time       myThread          mainThread
    //  0         ----             Main thread is running ....          myThread is starting .... 
    //500         0
    //1000        1
    //1500        2
    //2000        3                 Aborting my Thread
    //2500        4
    //3000        5

}
