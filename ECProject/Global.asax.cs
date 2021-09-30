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
    public class Cart
    {
        Dictionary<string, int> ShoppingCart = new Dictionary<string, int> ();
        //https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/
        void addCart(string pid, int qnt) // Product data is to be stored on the database
        {
            ShoppingCart.Add(pid, qnt);
        }
    }
    /*
    public class User
    {
        string name ="Bob";
        string password = "password";
        Dictionary<string, int> ShoppingCart = new Dictionary<string, int>();        
        void additemtoCart(string pid,int qnt)
        {

            if(!ShoppingCart.ContainsKey(pid)) //Does this do the same thing as below? Lets see
            {
                ShoppingCart[pid] = qnt;
            }
            else
            {
                ShoppingCart[pid] = ShoppingCart[pid] + qnt;
                return;
            }





            /*
            //search for item
            foreach(KeyValuePair<string,int> item in ShoppingCart)
            {
                if(item.Key == pid) //Searches to see if item exists in Shopping Cart. 
                {
                    int temp = item.Value+qnt;
                    ShoppingCart.Remove(item.Key);
                    ShoppingCart.Add(pid, temp);
                    return;
                    // If it does, it will remove the old key and value and replace it with an updated one with the new quantity bought by user.
                }
            }
            //If it is a new item, we will just add it.
            ShoppingCart.Add(pid, qnt);
            return;
           
        }
        
    }

*/
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            User Bill;
        }
    }
}