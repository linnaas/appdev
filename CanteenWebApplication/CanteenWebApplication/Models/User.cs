using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace CanteenWebApplication.Models
{
    public class User
    {
        public User(string username, string password, string first_name, string last_name, string email, string phone)
        {
            this.username = username;
            this.password = password;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone = phone;
        }

        public string username { get; set; }

        public string password { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public bool loginValidation(string username, string password)
        {
            bool valid = false;

            using (MySqlConnection conn = new MySqlConnection("server = 178.62.232.207; port = 3306; database = gruppe4; user = gruppe4; password = apputvikling;"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM user_list WHERE username='" + username + "' and password='" + password + "'", conn);

                valid = Convert.ToBoolean(cmd.ExecuteScalar());
                return valid;

            }
        }

    }
}
