using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace Flipkart
{
    public partial class SignIn : System.Web.UI.Page
    {
        SqlConnection conObj = new SqlConnection();
        SqlCommand cmdObj = new SqlCommand();
        string name = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
            }
            catch (SqlException ex)
            {
                Response.Redirect("Error.aspx?Error=" +"We are currently working on...Please try again latter");
                DataManager.ErrorLog(ex);
            }
            if (!IsPostBack)
            {
                if (Request.Cookies["Usename"] != null && Request.Cookies["Pasword"] != null)
                {
                    txtUsername.Text = Request.Cookies["Usename"].Value;
                    txtPass.Attributes.Add("Value", Request.Cookies["Pasword"].Value);
                }
            }
        }
        protected void Page_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            if (exc is HttpUnhandledException)
            {
                Response.Redirect("Error.aspx?Error=" + "Please load the page after some time we are working to fix the issue");
            }


        }

        protected void cmdSignIn_Click(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                Response.Cookies.Add(new HttpCookie("Usename", txtUsername.Text.ToLower()));
                Response.Cookies["Usename"].Expires = DateTime.Now.AddDays(14);
                Response.Cookies.Add(new HttpCookie("Pasword", txtPass.Text.Trim()));
                Response.Cookies["Pasword"].Expires = DateTime.Now.AddDays(14);
            }
            else
            {
                Response.Cookies["Usename"].Value = " ";
                Response.Cookies["Pasword"].Value = " ";
            }
            cmdObj = new SqlCommand("select * from GmailSignUp where G_UserName=@username and G_Password=@password", conObj);
            cmdObj.Parameters.AddWithValue("@username", txtUsername.Text);
            cmdObj.Parameters.AddWithValue("@password", txtPass.Text);
            if (conObj.State == ConnectionState.Closed)
                conObj.Open();
            SqlDataReader rdr = cmdObj.ExecuteReader();

            rdr.Read();
            if (rdr.HasRows)
            {
                name = rdr["G_FName"].ToString();
                string username = rdr["G_Username"].ToString();
                string password = rdr["G_Password"].ToString();

                Session["Username"] = txtUsername.Text;
                Session["Name"] = name;
                Response.Redirect("UserPageFlipkart.aspx");

            }
            if (FormsAuthentication.Authenticate(txtUsername.Text.ToLower(), txtPass.Text.Trim()))
            {
                Session["Username"] = txtUsername.Text;
                Session["Name"] = "Prashant Maurya";
                FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
            }



            cmdObj.Dispose();
            conObj.Close();
        }
    }
}