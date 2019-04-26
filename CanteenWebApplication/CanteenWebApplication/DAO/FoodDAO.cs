using System;
using System.Collections.Generic;
using CanteenWebApplication.Models;
using MySql.Data.MySqlClient;

namespace CanteenWebApplication.DAO
{
    public class FoodDAO
    {
        public List<Food> GetAllFoods()
        {
            List<Food> list = new List<Food>();
            using (MySqlConnection conn = new MySqlConnection("server = 178.62.232.207; port = 3306; database = gruppe4; user = gruppe4; password = apputvikling;"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from food", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int food_id = reader.GetInt32("food_id");
                        string food_name = reader.GetString("food_name");
                        bool enabled = (bool)reader["enabled"];
                        int price = reader.GetInt32("price");
                        int imageid = reader.IsDBNull(4) ? 0 : reader.GetInt32("image_id");
                        System.Diagnostics.Debug.WriteLine("Image id: " + imageid);
                        string description = reader.GetString("description");
                        if (enabled == true)
                        {
                            list.Add(new Food(food_id, food_name, enabled,price, imageid, description));
                        }
                    }
                }
                conn.Close();
            }
            return list;
        }

    }
}
