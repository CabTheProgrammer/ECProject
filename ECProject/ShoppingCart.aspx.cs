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
                Button1.Visible = false;
            }
            else
            {
                if (NewCart.UserID == null)
                    Button1.Visible = false;
                else if(NewCart.UserID == null && NewCart.CartTable.Rows.Count>0)
                    Button1.Visible = true;

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
                
            {
                NewCart.CartTable.Rows[index].Delete();
                if (NewCart.UserID != null)
                    NewCart.SavetoDatabase();
            }
            else
            {
                NewCart.CartTable.Rows[index][1] = value + qnt;  //calculation for quantity
                value= value + qnt;
                NewCart.CartTable.Rows[index][3] = value * price; // calculation for sub-total
                if(NewCart.UserID!= null)
                    NewCart.SavetoDatabase();
            }

            Response.Redirect(Request.RawUrl);
            //Newcart method here
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

        protected void Button1_Click(object sender, EventArgs e)
        {

            string status = "COMPLETE";
            for (int i = 0; i < NewCart.CartTable.Rows.Count; i++)
                NewCart.CartTable.Rows[i][7] = status;

            NewCart.SavetoDatabase();
            NewCart.CartTable.Clear();
            Response.Redirect(Request.RawUrl);

        }



    }
}