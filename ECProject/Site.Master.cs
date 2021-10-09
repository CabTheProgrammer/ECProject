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
            for(int i=0; i<NewCart.CartTable.Rows.Count;i++)
                cnt = cnt + (int)NewCart.CartTable.Rows[i][1];
            Label1.Text = cnt.ToString();
        }
    }
}