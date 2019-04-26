using System;
using System.Collections.Generic;
using CanteenWebApplication.Models;
using MySql.Data.MySqlClient;


namespace CanteenWebApplication.DAO
{
    public class UserDAO
    {
        public List<User> GetAllUsers   ()
        {
            List<User> list = new List<User>();
            using (MySqlConnection conn = new MySqlConnection("server = 178.62.232.207; port = 3306; database = gruppe4; user = gruppe4; password = apputvikling;"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user_list", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = reader.GetString("username");
                        string password = reader.GetString("password");
                        string first_name = reader.GetString("first_name");
                        string last_name = reader.GetString("last_name");
                        string email = reader.GetString("email");
                        string phone = reader.GetString("phone");
                      
                        list.Add(new User(username, password, first_name, last_name, email, phone));
                        


                    }
                }
                conn.Close();
            }
            return list;
        }

    }
}
