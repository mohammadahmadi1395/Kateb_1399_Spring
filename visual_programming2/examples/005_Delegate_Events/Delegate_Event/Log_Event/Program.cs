using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Log_Event
{
    class Program
    {
        //public void SendMail()
        public static void OnMessageLogged(string message)
        {
            Console.WriteLine("Sending Mail...");
            Thread.Sleep(2000);
            Console.WriteLine("Mail Sent");
        }
        static void Main(string[] args)
        {
            Logger logger = new Logger(); // publisher
            //MailService mailer = new MailService();
            logger.MessageLogged += OnMessageLogged;
            logger.WriteLog("an error");
            Console.Read();
        }
    }

    //Subscriber
    //public class MailService
    //{
    //    public void OnMessageLogged(string message)
    //    {
    //        Console.WriteLine("Sending Mail...");
    //        Thread.Sleep(2000);
    //        Console.WriteLine("Mail Sent");
    //    }
    //}

    //Publisher
    public class Logger
    {
        public delegate void DataLoggedDelegate(string message);
        public event DataLoggedDelegate MessageLogged;

        public void WriteLog(string message)
        {
            Console.WriteLine("Logging Message : {0}" , message);
            Thread.Sleep(3000);
            MessageLogged(message);
            //MessageLogged += OnMessageLogged;
            //SendMail();
        }
    }
}
