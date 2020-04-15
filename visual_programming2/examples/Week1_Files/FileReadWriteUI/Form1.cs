using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReadWriteUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            txtFilePath.Text = openFileDialog1.FileName;
            txtContent.Text = System.IO.File.ReadAllText(txtFilePath.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFilePath, null);
            errorProvider1.SetError(txtContent, null);

            bool sw = true;
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                errorProvider1.SetError(txtContent, "این فیلد اجباری است");
                sw = false;
            }

            if (string.IsNullOrWhiteSpace(txtFilePath.Text))
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    txtFilePath.Text = saveFileDialog1.FileName;
                else
                {
                    errorProvider1.SetError(txtFilePath, "این فیلد الزامی است");
                    sw = false;
                }

            if (sw)
            {
                try
                {
                    int a = 0;
                    int x = 5 / a;
                    System.IO.File.WriteAllText(txtFilePath.Text, txtContent.Text);
                    MessageBox.Show("عملیات با موفقیت انجام شد.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (!validationMoveOrCopy())
            {
                MessageBox.Show("عملیات قابل انجام نیست", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                System.IO.File.Move(txtSourcePath.Text, txtDestinationPath.Text);
                MessageBox.Show("عملیات با موفقیت انجام شد", "success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!validationMoveOrCopy())
            {
                MessageBox.Show("عملیات قابل انجام نیست", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                System.IO.File.Copy(txtSourcePath.Text, txtDestinationPath.Text);
                MessageBox.Show("عملیات با موفقیت انجام شد", "success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!validationDelete())
            {
                MessageBox.Show("عملیات قابل انجام نیست", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                System.IO.File.Delete(txtSourcePath.Text);
                MessageBox.Show("عملیات با موفقیت انجام شد", "success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validationMoveOrCopy()
        {
            errorProvider1.SetError(txtSourcePath, null);
            errorProvider1.SetError(txtDestinationPath, null);

            bool sw = true;

            if (string.IsNullOrWhiteSpace(txtSourcePath.Text))
            {
                errorProvider1.SetError(txtSourcePath, "برای انتقال یا کپی این فیلد الزامی است");
                sw = false;
            }

            if (string.IsNullOrWhiteSpace(txtDestinationPath.Text))
            {
                errorProvider1.SetError(txtDestinationPath, "برای انتقال یا کپی این فیلد الزامی است");
                sw = false;
            }

            return sw;
        }


        private bool validationDelete()
        {
            errorProvider1.SetError(txtSourcePath, null);
            errorProvider1.SetError(txtDestinationPath, null);

            bool sw = true;

            if (string.IsNullOrWhiteSpace(txtSourcePath.Text))
            {
                errorProvider1.SetError(txtSourcePath, "برای انتقال یا کپی این فیلد الزامی است");
                sw = false;
            }

            return sw;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtSourcePath.Text = openFileDialog1.FileName;
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtDestinationPath.Text = openFileDialog1.FileName;

        }
    }
}
