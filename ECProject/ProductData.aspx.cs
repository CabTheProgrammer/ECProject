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
    public partial class ProductData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString);
            SqlCommand command;
            SqlDataReader dataReader;

            int id = 1001;
            string test = (string)Session["ID"];
            string cmd = "SELECT * from PRODUCT_INFO WHERE ID=1001";
      
            conn.Open();
            command = new SqlCommand(cmd, conn);


            dataReader = command.ExecuteReader();
            dataReader.Read();
            Image1.ImageUrl = dataReader.GetValue(5).ToString().Trim();
            Name.Text = "<b>Name: </b> " + Convert.ToString(dataReader.GetValue(1));
            Description.Text = "<b>Description: </b> "+Convert.ToString(dataReader.GetValue(2));
            Price.Text = "<b>Price: </b> " + Convert.ToString(dataReader.GetValue(3));
            Category.Text= "<b>Category: </b> " + Convert.ToString(dataReader.GetValue(6));
            ISBN.Text = "<b>ISBN: </b> " + Convert.ToString(dataReader.GetValue(4));

            dataReader.Close();
            conn.Close();
        }
    }
}