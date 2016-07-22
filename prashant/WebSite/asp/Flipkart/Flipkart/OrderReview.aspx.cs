﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Caching;

namespace Flipkart
{
    public partial class OrderReview : System.Web.UI.Page
    {
        SqlConnection conObj = new SqlConnection();
        static float price = 0;
        static int qty = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["Username"] == null)
                {
                    Response.Redirect("SignIn.aspx");
                }
                else
                {
                    DataLoad();
                }
            }
        }

        private void DataLoad()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
            lblUserName.Text = Session["Name"].ToString();
            string id = Request.QueryString["ID"].ToString();
            imgBuy.ImageUrl = "~/ImageHandler.ashx?ID=" + id;

            SqlCommand cmdObj = new SqlCommand("select * from Product where ProductCode=@id", conObj);

            cmdObj.Parameters.AddWithValue("@id", id);
            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();
            }

            SqlDataReader rdr = cmdObj.ExecuteReader();


            if (rdr.HasRows)
            {
                rdr.Read();
                price = float.Parse(rdr["Price"].ToString());
                lblPrice.Text = rdr["Price"].ToString();
                lblDesc.Text = rdr["P_Description"].ToString();
            }

            rdr.Close();
            conObj.Close();
        }

        protected void ddlQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(lblPrice.Text) * Convert.ToInt32(ddlQuantity.SelectedItem.ToString());
            lblTotal.Text = sum.ToString();
        }

        protected void cmdBuy_Click(object sender, EventArgs e)
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConCGI"].ConnectionString);
            int quant = Convert.ToInt32(ddlQuantity.SelectedItem.ToString());
            string username = Session["Username"].ToString();
            string id = Request.QueryString["ID"].ToString();
            SqlCommand cmdObj = new SqlCommand("inserOrderDetail", conObj);
            cmdObj.CommandType = CommandType.StoredProcedure;
            cmdObj.Parameters.AddWithValue("@Quantity", quant);
            cmdObj.Parameters.AddWithValue("@ProductCode", id);
            cmdObj.Parameters.AddWithValue("@G_Username", username);
            if (conObj.State == ConnectionState.Closed)
            {
                conObj.Open();

            }
            int res = cmdObj.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Redirect("UserPageFlipkart.aspx");
            }
            cmdObj.Dispose();
            conObj.Close();
        }

        protected void cmdSignOut_Click(object sender, EventArgs e)
        {
            Session.Remove("Username");
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("UserPageFlipkart.aspx");
        }
    }
}