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
    public partial class ShowRole : Form
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);


        public ShowRole()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminControls ar = new AdminControls();
            ar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void ShowRole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDataSet.TM_ROLEMASTER' table. You can move, or remove it, as needed.
            this.tM_ROLEMASTERTableAdapter.Fill(this.trainingDataSet.TM_ROLEMASTER);

        }
    }
}
