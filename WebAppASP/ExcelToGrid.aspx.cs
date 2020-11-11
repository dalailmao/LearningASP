using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace WebAppASP
{
    public partial class ExcelToGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile == true)
            {
                string savePath = @"C:\Users\Dell\source\repos\WebAppASP\UploadedFiles\";
                string fileName = FileUpload1.FileName;
                savePath += fileName;
                FileUpload1.SaveAs(savePath);

                Label2.Visible = true;
                Label2.Text = FileUpload1.FileName;
                Button2.Visible = true;
                Label4.Visible = true;
                Button1.Text = "Upload another...";
            }
            else
            {
                Label4.Visible = true;
                Label4.Text = "No file choosen,please select a file again.";
            }

        }         
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            string savePath = @"C:\Users\Dell\source\repos\WebAppASP\UploadedFiles\"+Label2.Text;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + savePath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"");
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", con);
                con.Open();
                OleDbDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = rdr;
                GridView1.DataBind();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }
    }
}