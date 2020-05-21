using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CallMethods();
            Console.Read();
        }

        static async void CallMethods()
        {
            //Task<int> count = Method1();
            //int count = await Method1();
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
        }

        static void Method3(int count)
        {
            Console.WriteLine("Total count is {0}", count);
        }

        static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 1 ===> {0}", i);
                    count++;
                }
            });
            return count;
        }

        static void Method2()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Method 2 ===> {0}", i);
        }
    }
}
