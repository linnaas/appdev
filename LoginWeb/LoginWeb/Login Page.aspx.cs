using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using LoginWeb.Models;



namespace LoginWeb
{
    public partial class Login_Page : System.Web.UI.Page
    {
        private void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Session["usernameS"] = usernametxt.Text;


            string ConnectionS = "Server=remotemysql.com;Database=FgzHi9GyXc;Uid=FgzHi9GyXc;Pwd=c7V92jzX5b;";
            using (MySqlConnection con = new MySqlConnection(ConnectionS))
            {
                con.Open();
                using (MySqlCommand cmd = con.CreateCommand())
                {

                    cmd.CommandText = @"select count(*) from user_list where username=@User_N and password=@Pword";
                    cmd.Parameters.Add(new MySqlParameter("User_N", usernametxt.Text));
                    cmd.Parameters.Add(new MySqlParameter("Pword", passwordtxt.Text));
                    int i = Convert.ToInt32(cmd.ExecuteScalar());

                    if (i > 0)
                    {


                        var routingPage = new LoggedInPage();
                        routingPage.loginRoutePage();
                    }
                    else
                    {
                        var wrongPass = new MessageLogin();
                        wrongPass.wrongPass();
                    }
                }

            }

            Response.Redirect("~/Logged In.aspx");
        }
    }
}