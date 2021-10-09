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

                ListView2.DataSource = NewCart.CartTable;
                ListView2.DataBind();

                GridView2.DataSource = NewCart.CartTable;
                GridView2.DataBind();


                Label3.Text = "Total Price: $ "+ GrandTotal().ToString();
                Label2.Text = "Total Price: $ " + total.ToString();
            
            }
        }


        public void add(int index)
        {
            int loopcnt = 0;
            string key=null;
                
            Dictionary<string, iteminfo> tempCart = Cart.ShoppingCart;
               
                foreach(KeyValuePair<string, iteminfo> item in Cart.ShoppingCart)
                {
                    if(loopcnt == index)
                    {
                    key = item.Key;
                    break;
                    }
                    
                      loopcnt++;
                }
            if (key == null)
                return;

            Cart.addCart(key, 1);
            Response.Redirect(Request.RawUrl);
        }


        public  void table_mod(int index, int qnt)
        {
            int value = (int)NewCart.CartTable.Rows[index][1];
            float price =Convert.ToSingle(NewCart.CartTable.Rows[index][2]); //converts to single-precision floating-point

            if ((value + qnt) <= 0) // Deletes row if value falls below zero
                NewCart.CartTable.Rows[index].Delete();
            else
            {
                NewCart.CartTable.Rows[index][1] = value + qnt; 
                value= value + qnt;
                NewCart.CartTable.Rows[index][3] = value * price;
            }

            Response.Redirect(Request.RawUrl);
            
        }

        public  float  GrandTotal()
        {
            float total = 0;

            for(int i=0;i<NewCart.CartTable.Rows.Count;i++)
            {
                float test = Convert.ToSingle(NewCart.CartTable.Rows[i][3]);
                total = total+test;
            }

            return total;
        }







    }
}