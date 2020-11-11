using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppASP
{
    public partial class Dataset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["EmployeesConnectionString"].ConnectionString;
            using(SqlConnection con = new SqlConnection(str)) 
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("spGetData",con) ;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                da.Fill(ds);

                ds.Tables[0].TableName = "";
                ds.Tables[1].TableName = "";

                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

                GridView2.DataSource = ds.Tables[1];
                GridView2.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}