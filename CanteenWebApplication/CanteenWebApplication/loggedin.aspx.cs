using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CanteenWebApplication
{
    public partial class loggedin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usernameS"]!=null)
            {
                loggedInUser.Text = "You are logged in as " + Session["usernameS"].ToString() + " ! ";
            }           
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Remove("usernameS");
            Response.Redirect("~/Login.aspx");
        }
    }
}