using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using LoginWeb.Models;
using LoginWeb.Controllers;

namespace LoginWeb
{
    public partial class Logged_In : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usernameS"] != null)
            {
                loggedInUser.Text = "You are logged in as " + Session["usernameS"].ToString() + " ! ";
            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            var data = new DataLogout();
            data.logoutAction();

            Session.Remove("usernameS");
            Response.Redirect("~/Login Page.aspx");
        }
    }
}