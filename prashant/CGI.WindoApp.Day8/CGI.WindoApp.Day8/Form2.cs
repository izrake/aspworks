using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CGI.WindoApp.Day8
{
    public partial class SearchPass : Form
    {
        public SearchPass()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conObj = new SqlConnection("Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true");
            //conObj.ConnectionString = "Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true";
            SqlCommand cmdObj = new SqlCommand("select U_UserId,U_Password from UserRegistration where U_UserId=@userId", conObj);
            cmdObj.Parameters.AddWithValue("@userId", txtSearchId.Text);
            //cmdObj.Connection = conObj;
            //cmdObj.CommandText = "select * from UserRegistration";
            if(conObj.State==ConnectionState.Closed)
                     conObj.Open();
            SqlDataReader rdr = cmdObj.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                lblUserId.Text = rdr[0].ToString();
                lblbPass.Text = rdr[1].ToString();
                rdr.Close();
            }
            else
            {
                MessageBox.Show("No records found!!");
            }
        
            cmdObj.Dispose();
            conObj.Close();          
        }

        private void SearchPass_Load(object sender, EventArgs e)
        {
            SqlConnection conObj = new SqlConnection("Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true");
            SqlCommand cmdObj = new SqlCommand("Select U_FName from UserRegistration");
            cmdObj.Connection = conObj;
            if (conObj.State == ConnectionState.Closed)
                conObj.Open();

            SqlDataReader rdr = cmdObj.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    cbnUsername.Items.Add(rdr[0].ToString());
                }
            }
            cmdObj.Dispose();
            conObj.Close();
        }

        private void cbnUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conObj = new SqlConnection("Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true");
            SqlCommand cmdObj = new SqlCommand("Select U_UserId,U_Password from UserRegistration where U_FName=@username",conObj);
            cmdObj.Parameters.AddWithValue("@username", cbnUsername.Text);
          
            if (conObj.State == ConnectionState.Closed)
                conObj.Open();

            SqlDataReader rdr = cmdObj.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                lblUserId.Text = rdr[0].ToString();
                lblbPass.Text = rdr[1].ToString();
                
            }
            cmdObj.Dispose();
            conObj.Close();
        }

        
    }
}
