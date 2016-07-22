using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

	
		 
	

namespace CGI.WindoApp.Day8
{
    public partial class frmRegistration : Form
    {
        SqlConnection conObj = new SqlConnection();
        SqlCommand cmdObj = new SqlCommand();
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmailId.Text == "" || txtMobileNo.Text == "" || txtPassword.Text == "" ||
                txtConfirmPass.Text == "" ||  txtCountry.Text == "")
            {
                MessageBox.Show("Enter all the details");
                txtConfirmPass.Clear();
                txtEmailId.Clear();
                txtMobileNo.Clear();
                txtLastName.Clear();
                txtFirstName.Clear();
                txtCountry.Clear();
                txtUserName.Clear();
                cbGender.SelectedItem = 0;
            }
            else
            {
                
                cmdObj = new SqlCommand("setTheValues", conObj);
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.Parameters.AddWithValue("@U_FName", txtFirstName.Text);
                cmdObj.Parameters.AddWithValue("@U_LName", txtLastName.Text);
                cmdObj.Parameters.AddWithValue("@U_Gender", cbGender.Text);
                cmdObj.Parameters.AddWithValue("@U_UserId", txtUserName.Text.ToLower());
                cmdObj.Parameters.AddWithValue("@U_Password", txtPassword.Text);
                cmdObj.Parameters.AddWithValue("@U_Mobile", txtMobileNo.Text);
                cmdObj.Parameters.AddWithValue("@U_Country", txtCountry.Text);
                cmdObj.Parameters.AddWithValue("@U_EmailId", txtEmailId.Text);
                if (conObj.State == ConnectionState.Closed)
                    conObj.Open();
                int res=cmdObj.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Signed Up Successfully!!!");

                txtPassword.Clear();
                txtEmailId.Clear();
                txtMobileNo.Clear();
                txtLastName.Clear();
                txtFirstName.Clear();
                txtCountry.Clear();
                txtUserName.Clear();
                txtConfirmPass.Clear();
                cbGender.Text = "--Select--";
                   
                
            }
            
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtFirstName.Focus();
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Focus();
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Focus();
            }
        }

        private void cbGender_Validating(object sender, CancelEventArgs e)
        {
            if (cbGender.SelectedText == "")
            {
                cbGender.Focus();
            }
        }

       

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();

            }
        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPass.Text == "")
            {
                txtConfirmPass.Focus();
            }
        }

        private void txtCountry_Validating(object sender, CancelEventArgs e)
        {
            if (txtCountry.Text == "")
            {
                txtCountry.Focus();
            }
        }

        private void txtMobileNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtMobileNo.Text == "")
            {
                txtMobileNo.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtEmailId.Clear();
            txtMobileNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtCountry.Clear();
            txtUserName.Clear();
            txtConfirmPass.Clear();
            cbGender.Text = "--Select--";

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            //txtSearchUserId.Focus();
            //SqlConnection conObj = new SqlConnection("Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true");
            ////conObj.ConnectionString = "Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true";
            //SqlCommand cmdObj = new SqlCommand("select * from UserRegistration", conObj);
            ////cmdObj.Connection = conObj;
            ////cmdObj.CommandText = "select * from UserRegistration";
            //conObj.Open();
            //SqlDataReader rdr = cmdObj.ExecuteReader();
            //rdr.Read();
            //txtFirstName.Text = rdr[0].ToString();
            //txtLastName.Text = rdr[1].ToString();
            //txtCountry.Text = rdr["U_Country"].ToString();
            //rdr.Close();
            //cmdObj.Dispose();
            //conObj.Close();     
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //SqlConnection conObj = new SqlConnection("Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true");
            ////conObj.ConnectionString = "Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true";
            //SqlCommand cmdObj = new SqlCommand("select * from UserRegistration where U_UserId=@userId", conObj);
            //cmdObj.Parameters.AddWithValue("@userId", txtSearchUserId.Text);
            ////cmdObj.Connection = conObj;
            ////cmdObj.CommandText = "select * from UserRegistration";
            //conObj.Open();
            //SqlDataReader rdr = cmdObj.ExecuteReader();
            //rdr.Read();
            //txtFirstName.Text = rdr[0].ToString();
            //txtLastName.Text = rdr[1].ToString();
            //txtCountry.Text = rdr["U_Country"].ToString();
            //rdr.Close();
            //cmdObj.Dispose();
            //conObj.Close();             
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditInfo edit = new frmEditInfo();
            edit.Show();
            this.Hide();
        }

        private void lnkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignIn sign = new frmSignIn();
            sign.Show();
            this.Hide();
        }


    }
}
