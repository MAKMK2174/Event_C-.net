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


namespace jadi
{
    public partial class Discuss : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\jadi\jadi\EventMK.mdf;Integrated Security=True";

        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }
        public Discuss()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void M_Contact_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact cn = new Contact();
            cn.Show();
        }

        private void M_Events_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event ev = new Event();
            ev.Show();
        }

        private void M_Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void M_Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void M_view_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            View vi = new View();
            vi.Show();
        }

        private void D_submit_btn_Click(object sender, EventArgs e)
        {
            connection();

            string query = "INSERT INTO Discuss (C_Name, Contact, Venue, Memeber, Budget, Date_Time,Description) " +
               "VALUES ('"+D_Name_txt.Text+"','"+D_Contact_txt.Text+"','"+D_Venue_txt.Text+"','"+D_Member_txt.Text+"','"+D_Budget_txt.Text+"','"+D_datetime_txt.Text+"','"+D_Description_txt.Text+"')";

            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DONE");
        }
    }
}
