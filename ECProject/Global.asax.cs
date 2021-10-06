using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ECProject
{

    public struct iteminfo
    {
        public float price;
        public int qnty;

    }

    public static class Cart
    {
        
        public static Dictionary<string, iteminfo> ShoppingCart = new Dictionary<string, iteminfo> ();
        //https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/

        public static void addCart(string pid, int qnt)//This one is just for the shopping page; the price of the item is known
        {
            iteminfo temp;
            if (ShoppingCart.ContainsKey(pid)) //Does this do the same thing as below? Lets see
            {
                temp.qnty = qnt+1;
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
            if(ShoppingCart.ContainsKey(itemid)==true)
            {
                if (ShoppingCart[itemid].qnty - qnt < 0)
                    ShoppingCart.Remove(itemid);
                else
                {
                    temp.price = ShoppingCart[itemid].price;
                    temp.qnty = ShoppingCart[itemid].qnty -qnt;

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
          


        }


    

       
    }
}
