using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppASP
{
    public partial class AddRegionADO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["EmployeesConnectionString"].ConnectionString;
            using (SqlConnection con =new SqlConnection(cs)) 
            {
                string command = "spAddNewRegion";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@active",DropDownList1.SelectedValue);
                con.Open();
                int ans = cmd.ExecuteNonQuery();
                Button1.Text = ans.ToString() +" Region added successfully!!";

            }
        }
    }
}