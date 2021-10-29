using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ECProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
            //SqlCommand command;
            SqlDataReader dataReader;
            Session["Username"] = TextBox1.Text;
            Session["Password"] = TextBox2.Text;



            SqlCommand cmd = new SqlCommand("select * from USER_DATA where Username=@username and Password=@word", conn);
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("word", TextBox2.Text);

            //string cmd = "SELECT usid from USER_DATA WHERE Username=" + Session["UserName"].ToString().Trim() +"AND Password="+Session["Password"].ToString().Trim();
            conn.Open();

            //command = new SqlCommand(cmd, conn);

            dataReader = cmd.ExecuteReader();
            
            if(dataReader.HasRows==true)
            {
                if(dataReader.Read())
                {
                    Session["Password"] = null; //for security
                    
                    NewCart.UserID = dataReader.GetValue(1).ToString();
                    NewCart.Username = Convert.ToString(dataReader.GetValue(2));
                    if ((int)dataReader.GetValue(4) == 1)
                        Session["IsAdmin"] = true;
                    else
                        Session["IsAdmin"] = false;

                    if(NewCart.CartTable.Rows.Count>0)
                    {
                        for (int i = 0; i < NewCart.CartTable.Rows.Count; i++)
                            NewCart.CartTable.Rows[i][4] = NewCart.UserID;
                    }
                    

                    dataReader.Read();
                    dataReader.Close();
                    conn.Close();
                    //NewCart.LoadfromDatabase();
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    dataReader.Close();
                    conn.Close();
                    Label3.Text = "Incorrect Username or password";
                    Label3.ForeColor = System.Drawing.Color.Red;
                }
                
            }

            Session["Username"] = "Guest";
            dataReader.Close();
            conn.Close();
            Label3.Text = "Incorrect Username or password";
            Label3.ForeColor = System.Drawing.Color.Red;
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}