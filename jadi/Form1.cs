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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\jadi\jadi\EventMK.mdf;Integrated Security=True";
        public static string Username="";
        void conn()
        {
            con = new SqlConnection(Constr);
            con.Open();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (Name_txt.Text == "" && Pass_txt.Text == "")
            {
                MessageBox.Show("Enter Valid Username and Password", "Error");
            }
            else
            {
                conn();
da = new SqlDataAdapter("SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Password = @Password", con);
da.SelectCommand.Parameters.AddWithValue("@Username", Name_txt.Text);
da.SelectCommand.Parameters.AddWithValue("@Password", Pass_txt.Text);

DataTable dt = new DataTable();
da.Fill(dt);

if (dt.Rows[0][0].ToString() == "1")
{
    Username = Name_txt.Text;
    this.Hide();
    Form3 f3 = new Form3();
    f3.Show();
}

                else
                {
                    MessageBox.Show("Invalid Username Or Password");
                }
            }






            
        }
    }
}
