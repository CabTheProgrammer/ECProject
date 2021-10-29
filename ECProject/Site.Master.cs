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
        {//TODO: Make a cookie for guest and load shopping cart else

            if ((string)Session["Username"] == null || (string)Session["Username"] == "Guest")
            {
                Session["Username"] = "Guest";
                Session["IsAdmin"] = false;
                Logout.Visible = false;
                AddProducts.Visible = false;


            }
            else
            {
                Logout.Visible = true;// visible for users and admin
                if (Session["IsAdmin"] == null || (bool)Session["IsAdmin"] == false)
                    AddProducts.Visible = false;
                else
                    AddProducts.Visible = true;
            }

            Username.Text = (string)Session["Username"];
            int cnt = 0;
            for (int i = 0; i < NewCart.CartTable.Rows.Count; i++)
                cnt = cnt + (int)NewCart.CartTable.Rows[i][1];
            Label1.Text = cnt.ToString();
        }

        protected void logout(object sender, EventArgs e)
        {
            Session["Password"] = null; //for security
            NewCart.UserID = null;
            Session["Username"] = null;
            Session["IsAdmin"] = null;
            Logout.Visible = false;
            AddProducts.Visible = false;
            NewCart.CartTable.Clear();
            //TODO: if not admin, save order to database

            Response.Redirect("Default.aspx");
        }


    }
}