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
    public partial class UpdateRole : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);

        public UpdateRole()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminControls ar = new AdminControls();
            ar.Show();

        }

        void fillDataGridView()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter aa = new SqlDataAdapter("[sp_SearchUser12]", con);
            aa.SelectCommand.CommandType = CommandType.StoredProcedure;
            aa.SelectCommand.Parameters.AddWithValue("@roleName", textBox1.Text.Trim());
            DataTable dtd1 = new DataTable();
            aa.Fill(dtd1);
            dataGridView1.DataSource = dtd1;
         
            con.Close();


        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                fillDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand sqlcmd = new SqlCommand("sp_RoleInsert1", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                sqlcmd.Parameters.AddWithValue("@roleName", textBox1.Text.Trim());
              sqlcmd.Parameters.AddWithValue("@roleDescription", textBox2.Text.Trim());
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
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
