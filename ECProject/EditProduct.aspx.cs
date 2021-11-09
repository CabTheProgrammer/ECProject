using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace ECProject
{
    public partial class EditProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        string FileFunction() //Handles Upload of Book Cover
        {
            if (BookImage.HasFile)
            {
                try
                {//TODO: CHANGE TO RELATIVE REFERENCES!!!!!

                    //string InputFile = System.IO.Path.GetExtension(BookImage.FileName);
                    string addr = BookImage.FileName.Replace(" ", "");
                    string fileaddress = "/Uploaded/" + addr;
                   // Response.Write(addr);
                    //string filelocation = "C:\\Users\\cbart\\Projects\\.NET\\ECProject\\ECProject\\Uploaded";
                    string filelocation = "C:\\Users\\cbart\\Projects\\.NET\\ECProject\\ECProject\\Uploaded\\";
                    BookImage.SaveAs(filelocation + addr);
                    return fileaddress;
                }
                catch (Exception ex)
                {
                    Response.Write("<br/>Error<br/>");
                    Response.Write("Unable to save file<br/>" + ex.Message);
                    string fileaddress = "C:/Users/cbart/Projects/.NET/ECProject/ECProject/Uploaded/Fantasy.jpg";
                    return fileaddress;

                }
            }
            else
            {
                string fileaddress = "Uploaded/Fantasy.jpg";
                return fileaddress;
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string FileLocation  = FileFunction();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("updatestuff", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // Adding various parameters
            cmd.Parameters.AddWithValue("ID", BookID.Text);
            cmd.Parameters.AddWithValue("Name", BookName.Text);
            cmd.Parameters.AddWithValue("Description", Description.Text);
            cmd.Parameters.AddWithValue("Price", Convert.ToDouble(Price.Text));
            cmd.Parameters.AddWithValue("ISBN", ISBN.Text);
            cmd.Parameters.AddWithValue("Img_Location", FileLocation);
            cmd.Parameters.AddWithValue("Category", Category.Text);
            cmd.Parameters.AddWithValue("Author", Author.Text);

            conn.Open();

            if(cmd.ExecuteNonQuery()==0) // returns non-zero value if successful
            {
                Label9.Text = "Product does not exist in the Database";
            }
            conn.Close();
        }
    }
}