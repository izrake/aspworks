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
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            SqlConnection conObj = new SqlConnection("Data Source=pc-PC;Initial Catalog=UserDetails;Integrated Security=true");
            SqlCommand cmdObj = new SqlCommand("Select * from UserRegistration", conObj);
            DataTable dt = new DataTable();
            if (conObj.State == ConnectionState.Closed)
                conObj.Open();
            SqlDataReader rdr = cmdObj.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr, LoadOption.PreserveChanges);
            }
            gvPosition.DataSource = dt;
            cmdObj.Dispose();
            conObj.Close();
            
        }
    }
}
