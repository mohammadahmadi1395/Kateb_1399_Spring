using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyService
{
    public partial class MyService : ServiceBase
    {
        public MyService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Service is started at " + DateTime.Now);
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 5000;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            WriteToFile("System is running at " + DateTime.Now);
        }

        protected override void OnStop()
        {
            WriteToFile("Service is stopped at " + DateTime.Now);
        }

        private void WriteToFile(string message)
        {
            string dirPath = AppDomain.CurrentDomain.BaseDirectory + "/Logs";
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            string path = dirPath + "/ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            //if (!File.Exists(path))
            //{
            //    StreamWriter sw = new StreamWriter(path, false, Encoding.ASCII);
            //    sw.WriteLine(message);
            //    sw.Close();
            //}
            //else
            //{
                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);
                sw.WriteLine(message);
                sw.Close();
            //}
        }
    }
}
