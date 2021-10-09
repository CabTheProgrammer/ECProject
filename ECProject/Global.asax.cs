using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;



namespace ECProject
{



    public static class NewCart
    {
        public static DataTable CartTable = new DataTable("CartTable");

        public static DataTable MakeDataTable()
        {
            //static DataSet Table;

            DataColumn ID = new DataColumn("ID");
            DataColumn Qty = new DataColumn("Quantity");
            DataColumn Prc = new DataColumn("Price");
            DataColumn Stotal = new DataColumn("Sub-Total");

            //For each column in the shopping cart
            ID.DataType = System.Type.GetType("System.String");
            Qty.DataType = System.Type.GetType("System.Int32");
            Prc.DataType = System.Type.GetType("System.Decimal");
            Stotal.DataType = System.Type.GetType("System.Decimal");

            CartTable.Columns.Add(ID);
            CartTable.Columns.Add(Qty);
            CartTable.Columns.Add(Prc);
            CartTable.Columns.Add(Stotal);

            return CartTable;
        }

        public static void AddtoCart(string id, int qnt, float price)
        {
            for (int i = 0; i <CartTable.Rows.Count; i++)
            {
                if (CartTable.Rows[i][0].ToString() == id)
                {
                    int amount = (int)CartTable.Rows[i][1];  
                    float prc = Convert.ToSingle(CartTable.Rows[i][2]); //converts to single-precision floating-point

                        CartTable.Rows[i][1] = amount + qnt;
                        amount = amount + qnt;
                        CartTable.Rows[i][3] = amount * prc;
                    return;
                }
            }

            DataRow row = CartTable.NewRow();
            row["ID"] = id;
            row["Quantity"] = qnt;
            row["Price"] = price;
            row["Sub-Total"] = price * qnt;
            CartTable.Rows.Add(row);

        }

        

    }


    public struct iteminfo2
    {
        public string id;
        public int quantity;
        public float price;
    }

    public static class Cart2
    {
        static iteminfo2[] Scart;

        static void addCart(string id, int quantity, float price)
        {
            //checks if the item exists in the cart
            for (int i = 0; i <= Scart.Length; i++)
            {
                if (String.Equals(Scart[i].id, id))
                {
                    Scart[i].quantity = Scart[i].quantity + quantity;
                    return;
                }
            }
            //otherwise create a new item in the array.

        }
    }

    public struct iteminfo
    {
        public float price;
        public int qnty;
    }



    public static class Cart
    {
        public static Dictionary<string, iteminfo> ShoppingCart = new Dictionary<string, iteminfo>();
        //https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/

        public static void addCart(string pid, int qnt)//This one is just for the shopping page; the price of the item is known
        {
            iteminfo temp;
            if (ShoppingCart.ContainsKey(pid)) //Does this do the same thing as below? Lets see
            {
                temp.qnty = qnt + 1;
                temp.price = ShoppingCart[pid].price;

                ShoppingCart[pid] = temp;


            }

        }

        public static void addCart(string pid, int qnt, float price) // Product data is to be stored on the database
        {
            iteminfo temp;
            if (!ShoppingCart.ContainsKey(pid)) //Does this do the same thing as below? Lets see
            {
                temp.qnty = qnt;
                temp.price = price;

                ShoppingCart[pid] = temp;

            }
            else
            {
                temp.qnty = ShoppingCart[pid].qnty + qnt;
                temp.price = ShoppingCart[pid].price;

                ShoppingCart[pid] = temp;
                return;
            }
        }
        public static void removeItem(string itemid, int qnt) // Removes a certain quantity from the shopping cart
        {
            iteminfo temp;
            if (ShoppingCart.ContainsKey(itemid) == true)
            {
                if (ShoppingCart[itemid].qnty - qnt < 0)
                    ShoppingCart.Remove(itemid);
                else
                {
                    temp.price = ShoppingCart[itemid].price;
                    temp.qnty = ShoppingCart[itemid].qnty - qnt;

                    ShoppingCart[itemid] = temp;
                }

            }
        }
    }

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            NewCart.MakeDataTable();

        }






    }
}


  