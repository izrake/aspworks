﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Flipkart
{
    public partial class FlipkartMain : System.Web.UI.MasterPage
    {
        SqlConnection conObj = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataLoad();
            }
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            if (exc is HttpUnhandledException)
            {
               
                Response.Redirect("Error.aspx?Error=" + "Please load the page after some time we are working to fix the issue");
            }
            Server.ClearError();

        }


        private void DataLoad()
        {
            try
            {

                conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
            }
            catch (SqlException ex)
            {
                Response.Redirect("Error.aspx?Error=" + "We are currently working on...Please try again latter");
                DataManager.ErrorLog(ex);
            }

            SqlCommand cmdObj = new SqlCommand("select * from Product", conObj);
            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmdObj);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Product");
            DataUpload.DataSource = ds.Tables["Product"];
            DataUpload.DataBind();

        }

        protected void DataUpload_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "BuyNow")
            {
                Response.Redirect("OrderReview.aspx?ID=" + e.CommandArgument);
            }
        }

        protected void DataUpload_ItemDataBound(object sender, DataListItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if (Session["Username"] != null)
                {
                    Label lbl = Page.Master.FindControl("lblName") as Label;//this is to change the labels in the master
                    lbl.Text = Session["Name"].ToString();
                    lnkSignUp.Visible = false;
                    lnlSignIn.Visible = false;

                    string user = Session["Username"].ToString();

                    if (!user.Equals("prashantt"))
                    {


                        Button btn = e.Item.FindControl("cmdBuyNow") as Button;
                        btn.Visible = true;



                    }
                    else
                    {

                        Button btn = e.Item.FindControl("cmdBuyNow") as Button;
                        btn.Visible = false;
                        cmdSignOut.Visible = false;
                        lnkSignUp.Visible = false;
                        lnlSignIn.Visible = false;

                    }

                }
                else
                {

                    Button btn = e.Item.FindControl("cmdBuyNow") as Button;
                    btn.Visible = false;
                    cmdSignOut.Visible = false;


                }
            }

        }

        protected void lnlElectronics_Click(object sender, EventArgs e)
        {
            LinkButton lbkButton = (LinkButton)sender;
            string category = lbkButton.Text;
            try
            {
                conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
            }
            catch (SqlException ex)
            {
                Response.Redirect("Error.aspx?Error=" + "We are currently working on...Please try again latter");
                DataManager.ErrorLog(ex);
            }
            SqlCommand cmdObj = new SqlCommand("select * from Product where Category=@category or SubCategory=@category", conObj);
            cmdObj.Parameters.AddWithValue("@category", category);
            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmdObj);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Product");
            DataUpload.DataSource = ds.Tables["Product"];
            DataUpload.DataBind();

        }

        protected void cmdSignOut_Click(object sender, EventArgs e)
        {
            Session.Remove("Username");
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("SignIn.aspx");


        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
                string search = txtSearch.Text;
                conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
                SqlCommand cmdObj = new SqlCommand("select * from Product where Category=@search or SubCategory=@search or ProductName=@search", conObj);
                cmdObj.Parameters.AddWithValue("@search", search);
                if (conObj.State == ConnectionState.Closed)
                {
                    conObj.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmdObj);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Product");
                DataUpload.DataSource = ds.Tables["Product"];
                DataUpload.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write("Connection Error");
            }

        }
    }
}