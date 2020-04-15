using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week1_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.WriteAllText("./test.txt", "Hello World");
            //Console.WriteLine("The text is written in test.txt");

            //List<String> lines = new List<string>();
            //lines.Add("My Name is : ");
            //lines.Add("Mohammad Ahmadi");
            //File.WriteAllLines("./test2.txt", lines);
            //Console.WriteLine("The lines are written in test2.txt");

            //var strText = "How are you?";
            //var byteText = System.Text.Encoding.UTF8.GetBytes(strText);
            //File.WriteAllBytes("./test3.txt", byteText);
            //Console.WriteLine("The bytes are written in test3.txt");

            var text = File.ReadAllText("./test.txt");
            Console.WriteLine(text);

            Console.WriteLine("\n");

            var lines = File.ReadAllLines("./test2.txt");
            foreach (var line in lines)
                Console.WriteLine(line);
            
            Console.ReadKey();
        }
    }
}
