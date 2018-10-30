using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficManagement.View
{
    public partial class CreateRole : Form
    {
         
       SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
        public CreateRole()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminControls ar = new AdminControls();
            ar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand sqlcmd = new SqlCommand("sp_RoleInsert1", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Add");
                sqlcmd.Parameters.AddWithValue("@roleName", textBox1.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@roleDescription", textBox2.Text.Trim());
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Insert Successfully");
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
