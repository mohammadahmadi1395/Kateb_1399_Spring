using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await_ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            CallMethod();
            Console.Read();
        }

        static async void CallMethod()
        {
            string filePath = "C:\\Users\\SELECT LAPTOP\\Desktop\\file.txt";
            //int len = await ReadFile(filePath);
            Task<int> task = ReadFileAsync(filePath);
            Console.WriteLine("This is text...");
            Console.WriteLine("This is text...");
            Console.WriteLine("This is text...");
            Console.WriteLine("This is text...");
            Console.WriteLine("This is text...");
            Console.WriteLine("This is text...");

            int len = await task;
            Console.WriteLine("Total length of this file is {0}", len);
            Console.WriteLine("This is another text");
            Console.WriteLine("This is another text");
            Console.WriteLine("This is another text");
        }

        static async Task<int> ReadFileAsync(string file)
        {
            int len = 0;
            Console.WriteLine("Starting Reading file...");
            using (StreamReader reader = new StreamReader(file))
            {
                string s = await reader.ReadToEndAsync();
                len = s.Length;
            }
            return len;
        }

    }
}
