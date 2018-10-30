using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficManagement.View
{
    public partial class AdminControls : Form
    {
        public AdminControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateRole cr = new CreateRole();
            cr.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser cru = new CreateUser();
            cru.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteRole dr = new DeleteRole();
            dr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser dru = new DeleteUser();
            dru.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateRole ur = new UpdateRole();
            ur.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateUser uru = new UpdateUser();
            uru.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowUser shu = new ShowUser();
            shu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowRole sh = new ShowRole();
            sh.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
