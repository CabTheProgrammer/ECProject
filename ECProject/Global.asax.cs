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
    public class User
    {
        string name;
        Cart Ucart ; //Array to hold customers cart items

        User(string nme)
        {
            name = nme;
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