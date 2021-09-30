using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECProject
{
    public partial class ProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.TryParse(DropDownList1.SelectedValue, out a) ? a : 0;
            User Bill = new User();//TODO: FIX THIS URGENTLY!!
            Bill.additemtoCart("Chicken",a);


        }
    }
}