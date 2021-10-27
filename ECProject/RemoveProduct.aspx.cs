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
    public partial class RemoveProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int itemid = Convert.ToInt32(TextBox1.Text);

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCT_INFO WHERE ID=" + itemid,conn);

            conn.Open();
            if(cmd.ExecuteNonQuery()!=0)
            {
                Label2.Text = "Item has been successfully removed";
            }
            conn.Close();

        }
    }
}