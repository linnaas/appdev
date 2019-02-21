using System.Configuration;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
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


namespace CanteenWebApplication.Models
{
    public class Account
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
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }



        public string tempUsername { get; set; }
        public string tempFirstName { get; set; }
        public string tempLastName { get; set; }
        public string tempPassword { get; set; }
        public string tempEmail { get; set; }
        public string tempPhoneNumber { get; set; }

        




    }
}