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
   
    
    public static class Cart
    {
        public static Dictionary<string, int> ShoppingCart = new Dictionary<string, int> ();
        //https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/
        public static void addCart(string pid, int qnt) // Product data is to be stored on the database
        {
            if (!ShoppingCart.ContainsKey(pid)) //Does this do the same thing as below? Lets see
            {
                ShoppingCart[pid] = qnt;
            }
            else
            {
                ShoppingCart[pid] = ShoppingCart[pid] + qnt;
                return;
            }
        }
        public static void removeItem(string itemid, int qnty) // Removes a certain quantity from the shopping cart
        {
            if(ShoppingCart.ContainsKey(itemid)==true)
            {
                if (ShoppingCart[itemid] - qnty < 0)
                    ShoppingCart[itemid] = 0;
                else
                    ShoppingCart[itemid] = ShoppingCart[itemid] - qnty;
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


        
        public void additemtoCart(string pid, int qnt)
        {
            Dictionary <string, int> temp = (Dictionary<string,int>)Session["ShoppingCart"];
            if (!temp.ContainsKey(pid)) //Does this do the same thing as below? Lets see
            {
                temp[pid] = qnt;
            }
            else
            {
                temp[pid] = temp[pid] + qnt;
                return;
            }
            Session["ShoppingCart"] = temp;
        }

       
    }
}
