using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLProject;

namespace MyWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirst.Text) || string.IsNullOrWhiteSpace(txtSecond.Text) || !int.TryParse(txtFirst.Text, out _) || !int.TryParse(txtSecond.Text, out _))
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MyClass clp = new MyClass();
            txtResult.Text = clp.power(Convert.ToInt32(txtFirst.Text), Convert.ToInt32(txtSecond.Text)).ToString();
        }
    }
}
