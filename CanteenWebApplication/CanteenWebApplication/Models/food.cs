using System;
using System.Collections.Generic;

namespace CanteenWebApplication.Models
{
    public class Food
    {
        public Food()
        {
        }

        public Food(int food_id, string food_name, bool enabled, int price, int image_id, string description)
        {
            this.food_id = food_id;
            this.food_name = food_name;
            this.enabled = enabled;
            this.price = price;
            this.image_id = image_id;
            this.description = description;
        }

        public int food_id { get; set; }

        public string food_name { get; set; }

        public Nullable<bool> enabled { get; set; }

        public int price { get; set; }

        public Nullable<int> image_id { get; set; }

        public string description { get; set; }

        public List<Food> foodinfo { get; set; }


    }
}
