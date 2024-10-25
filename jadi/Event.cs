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
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void M_Contact_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact cn = new Contact();
            cn.Show();
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

        private void E_Birthday_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            eventfrom evn = new eventfrom();
            evn.Show();
        }

        private void E_Marriage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            eventfrom evn = new eventfrom();
            evn.Show();
        }

        private void E_seminar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            eventfrom evn = new eventfrom();
            evn.Show();
        }

        private void E_party_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            eventfrom evn = new eventfrom();
            evn.Show();
        }

        private void E_Exibition_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            eventfrom evn = new eventfrom();
            evn.Show();
        }

        private void E_Engagement_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            eventfrom evn = new eventfrom();
            evn.Show();
        }
    }
}
