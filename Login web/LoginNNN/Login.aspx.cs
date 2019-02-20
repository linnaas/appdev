using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;




namespace loginNNN
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
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
                        Session["usernameS"] = usernametxt.Text;
                        Response.Redirect("~/loggedin.aspx");
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invalid");
                    }
                }

            }
        }
    }
}

