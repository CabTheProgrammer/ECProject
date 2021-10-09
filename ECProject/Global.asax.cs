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

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            NewCart.MakeDataTable(); //initializes datatable object for shopping cart

        }
    }
}


  