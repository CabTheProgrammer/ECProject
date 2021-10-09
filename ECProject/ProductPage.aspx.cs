﻿using System;
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
            float price = float.Parse(Label1.Text);
            int a = int.TryParse(DropDownList1.SelectedValue, out a) ? a : 0; // Converts the dropdown list number to an int
            Cart.addCart("The Frost Eater", a, price); // adds the number and the product id to a dictionary
            Cart.addCart("The Hot Eater", a, price); // adds the number and the product id to a dictionary
            NewCart.AddtoCart("The Frost Eater", a, price);
            NewCart.AddtoCart("Hot Eater", a, price);
            Response.Redirect(Request.RawUrl);

        }
    }
}