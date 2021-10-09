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
            if (NewCart.CartTable.Rows.Count == 0)
            {
                Label3.Text = "Nothing to see here!";
            }
            else
            {
                GridView2.DataSource = NewCart.CartTable;
                GridView2.DataBind();
                Label3.Text = "Total Price: $ "+ GrandTotal().ToString();
               
            }
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