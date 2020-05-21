using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asyn_Await_ButtonClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<string> task = DoWork();
            ChangeButton2Text();
            string str = await task;
            ChangeButton1Text(str);
        }

        private async Task<string> DoWork()
        {

            await Task.Run(() =>
            {
                Thread.Sleep(5000);
            });
            return "Hi";
        }

        private void ChangeButton1Text(string str)
        {
            button1.Text = str;
        }
        private void ChangeButton2Text()
        {
            button2.Text = "Bye";
        }
    }
}
