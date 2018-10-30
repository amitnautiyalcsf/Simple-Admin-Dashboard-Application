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
    public partial class DeleteUser : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);


        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand scmd = new SqlCommand("[sp_DeleteUser]", con);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@userName", textBox1.Text.Trim());
                scmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully");
                textBox1.Clear();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
