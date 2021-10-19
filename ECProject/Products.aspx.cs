using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECProject
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            // Response.Redirect("ShoppingCart.aspx");
            //(string)e.CommandArgument.ToString() + "command"
            string stuff = e.CommandArgument.ToString();
            Label1.Text = stuff;
            Session["ID"] = stuff;
           
            Response.Redirect("ProductData.aspx");
        }
    }
}