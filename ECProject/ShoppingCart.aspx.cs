using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Data;

namespace ECProject
{
    public partial class Shopping_Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cart.ShoppingCart.Count == 0)
            {
                Label1.Text = "Nothing to see here!";
            }
            else
            {
                DataTable ShoppingList = new DataTable();
                DataRow row;
                float total = 0;
                         
               
                ShoppingList.Columns.Add("Item", typeof(string));
                ShoppingList.Columns.Add("Quantity", typeof(int));
                ShoppingList.Columns.Add("Price", typeof(float));
                ShoppingList.Columns.Add("Modify Order", typeof(CheckBox));
              
                foreach (KeyValuePair<string, iteminfo> item in Cart.ShoppingCart)
                {
                    
                    row = ShoppingList.NewRow();

                    row["Item"] = item.Key;
                    row["Quantity"] = item.Value.qnty;
                    row["Price"] = item.Value.price * (int) row["Quantity"];
                   
                    total = total + (float)row["Price"];
                    ShoppingList.Rows.Add(row);
                }
                GridView1.DataSource = ShoppingList;
                GridView1.DataBind();
                               
                Label2.Text = "Total Price: $ " + total.ToString();
            
            }
        }

       







    }
}