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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void M_Logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void M_Events_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event ev = new Event();
            ev.Show();
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
    }
}
