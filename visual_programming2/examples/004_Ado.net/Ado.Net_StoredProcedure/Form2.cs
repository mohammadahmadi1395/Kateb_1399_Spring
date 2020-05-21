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
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=Member;Integrated Security=True";
        private string PersonName { get; set; }
        private string PersonFamily { get; set; }
        private int PersonID { get; set; }
        
        public Form2(int id = 0, string name = null , string family = null)
        {
            InitializeComponent();
            PersonID = id;
            PersonName = name;
            PersonFamily = family;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtID.Text = PersonID.ToString();
            txtName.Text = PersonName;
            txtFamily.Text = PersonFamily;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;

            if (!ValidateEntry())
                return;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Family", txtFamily.Text);

            if (PersonID > 0) // Update
            {
                cmd.CommandText = "PersonUpdate";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            }
            else // Insert
            {
                cmd.CommandText = "PersonInsert";
                //var param = cmd.Parameters.Add("@ID", SqlDbType.Int);
                //param.Direction = ParameterDirection.ReturnValue;
                //txtID.Text = param.Value.ToString();
            }

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            DialogResult = DialogResult.OK;
        }

        private bool ValidateEntry()
        {
            bool sw = true;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("name is required");
                sw = false;
            }

            if (string.IsNullOrWhiteSpace(txtFamily.Text))
            {
                MessageBox.Show("family is required");
                sw = false;
            }

            return sw;
            //if (sw == false)
            //    return false;
            //else
            //    return true;
        }
    }
}
