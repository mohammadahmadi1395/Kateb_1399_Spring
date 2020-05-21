using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net_StoredProcedure
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=Member;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Grid_Refresh()
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("PersonGetAll", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            con.Close();
            gvPerson.DataSource = dt;
        }

        //private void gvPerson_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (gvPerson.SelectedRows.Count == 0 || gvPerson.SelectedRows.Count > 1)
        //        return;
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var cells = gvPerson.SelectedRows[0].Cells;
            int id = Convert.ToInt32(cells[0].Value.ToString());
            string name = cells[1].Value.ToString();
            string family = cells[2].Value.ToString();
            Form2 f = new Form2(id, name, family);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Grid_Refresh();
                MessageBox.Show("عملیات با موفقیت انجام شد");
            }
            else
                MessageBox.Show("عملیات شکست خورد");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Grid_Refresh();
                MessageBox.Show("عملیات با موفقیت انجام شد");
            }
            else
                MessageBox.Show("عملیات شکست خورد");
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("PersonDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                var param = cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(gvPerson.SelectedRows[0].Cells[0].Value.ToString()));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Grid_Refresh();
                MessageBox.Show("عملیات حذف با موفقیت انجام شد");
            }
            catch(Exception ex)
            {
                MessageBox.Show("عملیات حذف با شکست مواجه شد");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grid_Refresh();
        }
    }
}
