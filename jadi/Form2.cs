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
using System.IO;

namespace jadi
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\jadi\jadi\EventMK.mdf;Integrated Security=True";

        void conn()
        {
            con = new SqlConnection(Constr);
            con.Open();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void R_Register_Click(object sender, EventArgs e)
        {
            if (RName_txt.Text == "" || RPass_txt.Text == "")
            {
                MessageBox.Show("Enter Valid Username Or Password", "Error");
            }
            else if (Rcode_txt.Text == "" || Rcode_txt.Text != "MK2174")
            {
                MessageBox.Show("Enter Valid Key Code", "Error");
            }
            else
            {
                conn();
                cmd = new SqlCommand("INSERT INTO [User] (Username, Password) VALUES (@Username, @Password)", con);
                cmd.Parameters.AddWithValue("@Username", RName_txt.Text);
                cmd.Parameters.AddWithValue("@Password", RPass_txt.Text);
                cmd.ExecuteNonQuery();
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();


            }
        }
    }
}
