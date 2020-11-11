using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebAppASP
{
    public partial class SqlCommands : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["EmployeesConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select count(country_name) from countries";
                cmd.Connection = con;
                con.Open();
                //GridView1.DataSource = cmd.ExecuteReader();
                //GridView1.DataBind();
                int TotalCountries = (int)cmd.ExecuteScalar();
                Response.Write("Total Countries  :  " + TotalCountries.ToString());
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}