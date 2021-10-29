using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ECProject
{

    public static class NewCart
    {

        public static string Username;
        public static string UserID=null;

        public static DataTable CartTable = new DataTable("CartTable");

        public static DataTable MakeDataTable()
        {
            //static DataSet Table;

            DataColumn ID = new DataColumn("ID");
            DataColumn Qty = new DataColumn("Quantity");
            DataColumn Prc = new DataColumn("Price");
            DataColumn Stotal = new DataColumn("Sub-Total");
            DataColumn userid = new DataColumn("UserID");
            DataColumn datetime = new DataColumn("Order-Date");
            DataColumn orderid = new DataColumn("OrderID");
            DataColumn orderstatus = new DataColumn("Order-Status");

            //For each column in the shopping cart
            ID.DataType = System.Type.GetType("System.String");
            Qty.DataType = System.Type.GetType("System.Int32");
            Prc.DataType = System.Type.GetType("System.Decimal");
            Stotal.DataType = System.Type.GetType("System.Decimal");
            userid.DataType = System.Type.GetType("System.String");
            datetime.DataType = System.Type.GetType("System.DateTime");
            orderid.DataType = System.Type.GetType("System.String");
            orderstatus.DataType = System.Type.GetType("System.String");

            CartTable.Columns.Add(ID);
            CartTable.Columns.Add(Qty);
            CartTable.Columns.Add(Prc);
            CartTable.Columns.Add(Stotal);
            CartTable.Columns.Add(userid);
            CartTable.Columns.Add(datetime);
            CartTable.Columns.Add(orderid);
            CartTable.Columns.Add(orderstatus);

            return CartTable;
        }

        public static void AddtoCart(string id, int qnt, float price)
        {
            for (int i = 0; i < CartTable.Rows.Count; i++)
            {
                if (CartTable.Rows[i][0].ToString() == id)
                {
                    int amount = (int)CartTable.Rows[i][1];
                    float prc = Convert.ToSingle(CartTable.Rows[i][2]); //converts to single-precision floating-point

                    CartTable.Rows[i][1] = amount + qnt;
                    amount = amount + qnt;
                    CartTable.Rows[i][3] = amount * prc;

                   
                        CartTable.Rows[i][4] = UserID;
                        CartTable.Rows[i][5] = DateTime.Now;
                        CartTable.Rows[i][6] = (UserID+Convert.ToString(DateTime.Now));                  
                        CartTable.Rows[i][7] = "INCOMPLETE";
                    if (UserID != null)
                       SavetoDatabase();

                    return;
                }
            }

            DataRow row = CartTable.NewRow();
            row["ID"] = id;
            row["Quantity"] = qnt;
            row["Price"] = price;
            row["Sub-Total"] = price * qnt;
            row["UserID"] = UserID;
            row["Order-Date"] = DateTime.Now;
            row["OrderID"] = (UserID + Convert.ToString(DateTime.Now));
            row["Order-Status"] = "INCOMPLETE";
            CartTable.Rows.Add(row);
            if (UserID != null)
                SavetoDatabase();

        }

       public static void SavetoDatabase()
        {
     
          
            /*
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO ORDER_DATA(Usid,Date,Orderid)VALUES(@user,@date,@orderid) WHERE ");
            sqlCommand.Parameters.AddWithValue("user", UserID);
            sqlCommand.Parameters.AddWithValue("date", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("orderid", (Convert.ToString(DateTime.Now)+Convert.ToString(UserID)));
            */


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString))
            {
                connection.Open();
                using(SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = "ORDER_DATA";
                    bulkCopy.ColumnMappings.Add("ID", "Itemid");
                    bulkCopy.ColumnMappings.Add("Quantity", "Quantity");
                    bulkCopy.ColumnMappings.Add("UserID", "userid");
                    bulkCopy.ColumnMappings.Add("Order-Date", "Date");
                    bulkCopy.ColumnMappings.Add("OrderID", "Orderid");
                    bulkCopy.ColumnMappings.Add("Order-Status", "Orderstatus");
                    try
                    {
                        bulkCopy.WriteToServer(NewCart.CartTable);
                    }
                    catch(Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine(e.Message);   
                    }
                }
            }
            /*
            //adding userid, date and orderid
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();

            //TODO: TEST THIS TOMMOROW
            */

        
        
        
        
        }
       

       public static void LoadfromDatabase()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ORDER_DATA WHERE Orderstatus='INCOMPLETE' AND userid = @usid",conn);
            sqlCommand.Parameters.AddWithValue("usid", UserID);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            // this will query your database and return the result to your datatable
            da.Fill(NewCart.CartTable);
            conn.Close();
            da.Dispose();
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

        /*
        string Serial(DataTable Q)  //Serializes the values stored in a datatable so that it can be stored in a cookie
        {
            string items, itemid, itemqnty;
            items = "";
            for (int i = 0; i < NewCart.CartTable.Rows.Count; i++)
            {
                itemid = NewCart.CartTable.Rows[i][0].ToString();
                itemqnty = NewCart.CartTable.Rows[i][0].ToString();
                items = items + "|" + itemid+ "|" + itemqnty;
            }

            return items;
        }
        */

        /*
        DataTable Deserialize(string Q)
        {
            DataTable DT;

            //To initialize DT
            DataColumn ID = new DataColumn("ID");
            DataColumn Qty = new DataColumn("Quantity");
            DataColumn Prc = new DataColumn("Price");
            DataColumn Stotal = new DataColumn("Sub-Total");

            //For each column in the shopping cart
            ID.DataType = System.Type.GetType("System.String");
            Qty.DataType = System.Type.GetType("System.Int32");
            Prc.DataType = System.Type.GetType("System.Decimal");
            Stotal.DataType = System.Type.GetType("System.Decimal");

            DT.Columns.Add(ID);
            DT.Columns.Add(Qty);
            DT.Columns.Add(Prc);
            DT.Columns.Add(Stotal);


            string[] vs = Q.Split('|');
            int count = vs.Length;

            for(int i = 0; i<=count;i+=2)
            {
                DataRow row = DT.NewRow();
                
                 row["ID"] = vs[count];
                row["Quantity"] = [count+1];
                //row["Price"] = price;
                //row["Sub-Total"] = price * qnt;
             
                DT.Rows.Add(row);
            }    
           
            
           

            return DT;
        }
        */
    }
}


  