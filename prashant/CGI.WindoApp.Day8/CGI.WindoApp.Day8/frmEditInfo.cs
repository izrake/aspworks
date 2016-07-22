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
    public partial class frmEditInfo : Form
    {
        SqlConnection conObj = new SqlConnection();
        SqlCommand cmdObj = new SqlCommand();
        public frmEditInfo()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmdObj = new SqlCommand("updateData", conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;
            cmdObj.Parameters.AddWithValue("@U_UserId", txtUserId.Text.ToLower());
            cmdObj.Parameters.AddWithValue("@U_Password", txtOldPass.Text);
            cmdObj.Parameters.AddWithValue("@U_NewPass", txtNewPass.Text);
            if (conObj.State == ConnectionState.Closed)
                conObj.Open();
            int res = cmdObj.ExecuteNonQuery();
            if (res > 0)
                MessageBox.Show("Updated Successfully!!!");

            txtNewPass.Clear();
            txtOldPass.Clear();
            txtUserId.Clear();

        }

        private void frmEditInfo_Load(object sender, EventArgs e)
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmdObj = new SqlCommand("deleteUser", conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;
            cmdObj.Parameters.AddWithValue("@U_UserId", txtUserId.Text);
            cmdObj.Parameters.AddWithValue("@U_Pass", txtOldPass.Text);
            if (conObj.State == ConnectionState.Closed)
                conObj.Open();
            int res = cmdObj.ExecuteNonQuery();
            if (res > 0)
                MessageBox.Show("Deleted Successfully!!!");

            cmdObj.Dispose();
            conObj.Close();
        }

        private void lnkSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmdObj = new SqlCommand("select U_Password from UserRegistration where U_UserId=@U_UserId ", conObj);
            cmdObj.Parameters.AddWithValue("@U_UserId", txtUserId.Text);
            if (conObj.State == ConnectionState.Closed)
                conObj.Open();
            SqlDataReader rdr = cmdObj.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows)
                txtOldPass.Text = rdr["U_Password"].ToString();
            else
                MessageBox.Show("The userid not exist");

            cmdObj.Dispose();
            conObj.Close();


        }

        private void frmEditInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
