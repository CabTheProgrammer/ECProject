using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECProject
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            Session["UserName"] = TextBox1.Text;
            Session["Email"] = TextBox4.Text;
            Session["Password"] = TextBox3.Text;
           */


            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            var user = new IdentityUser() { UserName = TextBox1.Text };

            IdentityResult result = manager.Create( user,TextBox3.Text);
            if(result.Succeeded)
            {
                Label5.Text = string.Format("User {0} was created successfully!", user.UserName);
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
                Session["UserName"] = TextBox1.Text;
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Label5.Text = result.Errors.FirstOrDefault();
            }
           // Response.Redirect("~/Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }
    }



}