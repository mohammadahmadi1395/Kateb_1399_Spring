using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStream
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileStream fs = new System.IO.FileStream("test.txt", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
                fs.WriteByte((byte)i);
            
            //fs.Position = 0;
            fs.Seek(0, System.IO.SeekOrigin.Begin);
            for (int i = 0; i <= 20; i++)
                Console.Write(fs.ReadByte());

            fs.Close();
            Console.ReadKey();
        }
    }
}
