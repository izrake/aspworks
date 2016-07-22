using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CGI.WindoApp.Day8
{
    public partial class GridViewControl : Form
    {
        public GridViewControl()
        {
            InitializeComponent();
        }

        private void GridViewControl_Load(object sender, EventArgs e)
        {
            SqlConnection conObj = new SqlConnection("Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true");
            SqlCommand cmdObj = new SqlCommand("select distinct U_Country from UserRegistration", conObj);

            if (conObj.State == ConnectionState.Closed)
                conObj.Open();
            SqlDataReader rdr = cmdObj.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    cbnCountrySDetail.Items.Add(rdr[0].ToString());
                }
            }
            cmdObj.Dispose();
            conObj.Close();
        }

        private void cbnCountrySDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conObj = new SqlConnection("Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true");
            SqlCommand cmdObj = new SqlCommand("select * from UserRegistration where U_Country=@country", conObj);
            cmdObj.Parameters.AddWithValue("@country", cbnCountrySDetail.Text);

            if (conObj.State == ConnectionState.Closed)
                conObj.Open();
            SqlDataReader rdr = cmdObj.ExecuteReader();

            DataTable dt = new DataTable();

            if (rdr.HasRows)
            {
                
                dt.Load(rdr, LoadOption.PreserveChanges);
            }

            gvPeopleDetails.DataSource = dt;
            cmdObj.Dispose();
            conObj.Close();
            
          


        }

       
    }
}
