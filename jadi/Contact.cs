using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jadi
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Contact_Load(object sender, EventArgs e)
        {

        }

        private void M_Discuss_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Discuss dis = new Discuss();
            dis.Show();
        }

        private void M_view_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            View vi = new View();
            vi.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Discuss D = new Discuss();
            D.Show();
        }
    }
}
