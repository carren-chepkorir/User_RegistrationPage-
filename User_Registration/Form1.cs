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

namespace User_Registration
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lable2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void warning2_Click(object sender, EventArgs e)
        {

        }

        private void warning1_Click(object sender, EventArgs e)
        {

        }

        private void textconfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_Click(object sender, EventArgs e)
        {

        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (textusername.Text == "" || textpassword.Text == "")
            {
                MessageBox.Show("Please fill the mandatory field");

            }
            else if (textpassword.Text != textconfirmpassword.Text)
            {
                MessageBox.Show("password do not match");
                 
                }
            else { 
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", textlastname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", textcontact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", textaddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserName", textusername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textpassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration was successful");
                    Clear();
                }

            }
        }
        void Clear()
        {
            txtfirstname.Text = textaddress.Text = txtpassword.Text = textcontact.Text = txtusername.Text = textlastname.Text=textconfirmpassword.Text = "";
        }
    }
}
