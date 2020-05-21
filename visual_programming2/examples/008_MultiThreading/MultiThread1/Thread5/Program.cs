using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread5
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(myFunction);
            myThread.Start();
            myThread.Join();
            Console.WriteLine("Work is completed");
            Console.Read();
        }

        static void myFunction()
        {
            for (int i = 0; i <= 10; i++)
                Console.WriteLine("Work is in progres ...");
        }
    }
}
