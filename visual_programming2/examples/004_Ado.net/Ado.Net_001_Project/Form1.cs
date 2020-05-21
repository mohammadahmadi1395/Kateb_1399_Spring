using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Ado.Net_001_Project
{
    public partial class Form1 : Form
    {
        //SqlDataAdapter adapter;
        //DataSet ds;
        //string connString = "Data Source=.;Initial Catalog=Member;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=.;Initial Catalog=Member;Integrated Security=True";
            //con.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "insert into person(name, family) values ('mohammad', 'ahmadi')";
            //cmd.CommandText = "update person set Name = 'Ali' where Name like 'mohammad'";
            //cmd.CommandText = "delete from person where Name like 'Ali'";
            //cmd.ExecuteNonQuery();

            //try
            //{
            //    cmd.CommandText = "selet count(*) from person";
            //    int count = (int)cmd.ExecuteScalar();
            //    MessageBox.Show("person table has " + count.ToString() + " rows");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //cmd.CommandText = "select * from person";
            //SqlDataReader people = cmd.ExecuteReader();
            //string result = string.Empty;
            //while(people.Read())
            //{
            //    result += (people[1].ToString() + " " + people[2].ToString()) + "\n";
            //}
            //MessageBox.Show(result);

            //cmd.CommandText = "insert into person(name, family) values (@p1, @p2)";
            //cmd.Parameters.AddWithValue("p1", txtName.Text);
            //cmd.Parameters.AddWithValue("p2", txtFamily.Text);
            //cmd.ExecuteNonQuery();


            //cmd.CommandText = "select * from person";
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //gvMember.DataSource = dt;

            //con.Close();

            //cmd.CommandText = "Select * from person";
            //SqlDataAdapter da = new SqlDataAdapter();
            //DataSet ds = new DataSet();
            //da.SelectCommand = cmd;
            //da.Fill(ds, "T1");
            //gvMember.DataBindings.Add("datasource", ds, "T1");

            //adapter = new SqlDataAdapter("select * from person", connString);
            //ds = new DataSet();
            //adapter.Fill(ds);
            //gvMember.DataSource = ds.Tables[0];

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=Member;Integrated Security=True";

            SqlCommand cmd_insert = new SqlCommand("insert into person(Name, Family) values(@p1, @p2);", conn);
            cmd_insert.Parameters.AddWithValue("p1", txtName.Text);
            cmd_insert.Parameters.AddWithValue("p2", txtFamily.Text);

            SqlCommand cmd_select = new SqlCommand("select * from person;", conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmd_select;
            adapter.Fill(ds, "T1");
            gvMember.DataBindings.Add("datasource", ds, "T1");

            adapter.InsertCommand = cmd_insert;
            adapter.InsertCommand.Connection.Open();
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.InsertCommand.Connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //adapter.Update(ds);
        }
    }
}
