using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Flipkart
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection conObj = new SqlConnection();
        SqlCommand cmdObj = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
        }

        protected void btnSignUpMain_Click(object sender, EventArgs e)
        {
            if (chkAggreement.Checked)
            {
                cmdObj = new SqlCommand("GmailSignUpPro", conObj);
                cmdObj.CommandType = CommandType.StoredProcedure;
                cmdObj.Parameters.AddWithValue("@G_FName", txtFirstName.Text);
                cmdObj.Parameters.AddWithValue("@G_LName", txtLastName.Text);
                cmdObj.Parameters.AddWithValue("@G_Username", txtUsername.Text);
                cmdObj.Parameters.AddWithValue("@G_Password", txtPassword.Text);
                string dt = txtDay.Text + "/" + ddlMonth.SelectedValue.ToString() + "/" + txtYear.Text;
                cmdObj.Parameters.AddWithValue("@G_BirthDate", Convert.ToDateTime(dt));
                cmdObj.Parameters.AddWithValue("@G_Gender", ddlGender.SelectedValue.ToString());
                cmdObj.Parameters.AddWithValue("@G_MobileNo", txtMobileNo.Text);
                cmdObj.Parameters.AddWithValue("@G_AltEmail", txtAltEmail.Text);
                cmdObj.Parameters.AddWithValue("@G_Location", ddlLocation.SelectedValue.ToString());


                if (conObj.State == ConnectionState.Closed)
                    conObj.Open();

                int res = cmdObj.ExecuteNonQuery();

                if (res > 0)
                {
                    Server.Transfer("SignIn.aspx");
                }

                cmdObj.Dispose();
                conObj.Close();
            }
            else
                lblChkError.Text = "Please Check the agreement";
            }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }
    }
}