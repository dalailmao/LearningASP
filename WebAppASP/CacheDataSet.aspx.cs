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
    public partial class CacheDataSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] == null) { 
            string str = ConfigurationManager.ConnectionStrings["EmployeesConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(str))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select* from regions", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Cache["Data"] = ds;



                    gvRegions.DataSource = ds;
                    gvRegions.DataBind();
                }
                lblMessage.Text = "Data from DB";
            }
            else 
            {
                gvRegions.DataSource = (DataSet)Cache["Data"];
                gvRegions.DataBind();
                lblMessage.Text = "data from cache";

            }
        }

        protected void btnClearCache_Click(object sender, EventArgs e)
        {
            if(Cache["Data"] != null) 
            {
                Cache.Remove("Data");
                lblMessage.Text = "dataset removed from cache";
            }
            else 
            {
                lblMessage.Text = "nothing in cache to remove";
            }
        }
    }
}