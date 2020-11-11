using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security;

namespace WebAppASP
{
    public partial class ADONet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string cs = "data source=.;database=Employees;integrated security = SSPI";
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = cs;

            //SecureString psw = new SecureString();
            //psw.Equals("7535963236");  NOT DONE !!!!!!!!!
            //SqlCredential pw = new SqlCredential("sa",psw);
            //SqlConnection con = new SqlConnection(cs,pw);

            SqlConnection con = new SqlConnection("data source=.;database=Employees;integrated security = SSPI");
            try
            {
                SqlCommand cmd = new SqlCommand("select * from employees", con);
                con.Open();
                ////SqlDataReader rdr = cmd.ExecuteReader();
                //GridView1.DataSource = rdr;
                //GridView1.DataBind();
            }
            catch 
            { 
            }
            finally
            {
                con.Close();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}