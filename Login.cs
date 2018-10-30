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
using System.Configuration;
namespace TrafficManagement.View
  
{
    public partial class Login : Form
    {
        static int attempt = 3;


        public Login()
        {
            InitializeComponent();

            
            pictureBox1.Image = new Bitmap(@"C:\Users\30661\Documents\Visual Studio 2015\Projects\TrafficManagement\log.gif");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            SqlConnection con;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            con.Open();
            if (attempt == 0)
            {
                lblMsg.Text = ("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");
                return;
            }
            
           SqlCommand scmd = new SqlCommand("select count (*) as cnt from dbo.TM_USERMASTER where userName=@usr and password=@pwd", con);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", textBox1.Text);
            scmd.Parameters.AddWithValue("@pwd", textBox2.Text);
            

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\30661\Documents\Visual Studio 2015\Projects\TrafficManagement\acgt.gif");
                lblMsg.Text = ("                                 Congrats");
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                
                this.Hide();
                AdminControls f2 = new AdminControls();
                f2.Show();
            }

            else
            {

                pictureBox1.Image = new Bitmap(@"C:\Users\30661\Documents\Visual Studio 2015\Projects\TrafficManagement\acd.gif");
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                lblMsg.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
             
            }
            con.Close();

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

