using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace CGI.WindoApp.Day8
{
    public partial class frmSignIn : Form
    {
        SqlConnection conObj = new SqlConnection();
        SqlCommand cmdObj = new SqlCommand();
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmdObj = new SqlCommand("select U_FName,U_LName from UserRegistration where U_UserId=@userid and U_Password=@pass", conObj);
           cmdObj.Parameters.AddWithValue("@userid", txtUsername.Text);
           cmdObj.Parameters.AddWithValue("@pass", txtPassword.Text);
           if (conObj.State == ConnectionState.Closed)
               conObj.Open();
           SqlDataReader rdr = cmdObj.ExecuteReader();
           if (rdr.HasRows)
           {
               MessageBox.Show("Successfully loged in!!!!");
           }
           else
               MessageBox.Show("User Does Not Exist!!");
           cmdObj.Dispose();
           conObj.Close();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The values got reset");
        }

        private void frmSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
        }                                 
    }
}
