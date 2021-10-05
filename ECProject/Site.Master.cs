using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECProject
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cnt = 0;
            foreach (KeyValuePair<string, int> item in Cart.ShoppingCart)
                cnt = cnt + item.Value;
            Label1.Text = cnt.ToString();
        }
    }
}