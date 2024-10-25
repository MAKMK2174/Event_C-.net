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
using System.Data;
using System.IO;

namespace jadi
{
    public partial class eventfrom : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\jadi\jadi\EventMK.mdf;Integrated Security=True";

        public eventfrom()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        private void Event_Submit_btn_Click(object sender, EventArgs e)
        {
            connection();



            string query = "INSERT INTO Event (EVENT, C_Name, Contact, Food, Food_item, Venue, Member, Date_Time, Budget, Note, [Total Amount], Token_Amount, Pendding_Amount, Paymnet) " +
               "VALUES ('"+Event_name.Text+"','"+Event_C_name_txt.Text+"','"+Event_Contact_txt.Text+"','"+ Event_Food_txt.Text + "','"+ Event_Food_Item_txt.Text + "','"+ Event_Venue_txt.Text + "','"+ Event_Member_txt.Text + "','" +Event_Date_time_txt.Text + "','"+ Event_Budget_txt.Text + "','"+ Event_note_txt.Text + "','"+ Event_T_Amount.Text + "','"+ Event_Token_Amount.Text + "','"+Event_Pending_Amount.Text+"','"+ Eve_payment.Text + "')";

            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Insert done");

            /*using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Event", Event_name.Text);
                cmd.Parameters.AddWithValue("@C_name", Event_C_name_txt.Text);
                cmd.Parameters.AddWithValue("@Contact", Event_Contact_txt.Text);
                cmd.Parameters.AddWithValue("@Food", Event_Food_txt.Text);
                cmd.Parameters.AddWithValue("@Food_item", Event_Food_Item_txt.Text);
                cmd.Parameters.AddWithValue("@Venue", Event_Venue_txt.Text);
                cmd.Parameters.AddWithValue("@Member", Event_Member_txt.Text);
                cmd.Parameters.AddWithValue("@Date_Time", Event_Date_time_txt.Text);
                cmd.Parameters.AddWithValue("@Budget", Event_Budget_txt.Text);
                cmd.Parameters.AddWithValue("@Note", Event_note_txt.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", Event_T_Amount.Text);
                cmd.Parameters.AddWithValue("@Token_Amount", Event_Token_Amount.Text);
                cmd.Parameters.AddWithValue("@Pendding_Amount", Event_Token_Amount.Text); // This seems to be incorrect, ensure it’s correct in your context
                cmd.Parameters.AddWithValue("@Payment", Eve_payment.Text);

                cmd.ExecuteNonQuery();
            }*/


        }
        private void Event_form_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void Event_back_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Event ev = new Event();
            ev.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
