using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Test2
{
    /// <summary>
    /// Interaction logic for EditDeleteFood.xaml
    /// </summary>
    public partial class EditDeleteFood : Page
    {
        public EditDeleteFood()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server = 178.62.232.207; port = 3306; database = gruppe4; user = gruppe4; password = apputvikling;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from food", conn);

                using (var reader = cmd.ExecuteReader())

                {

                    while (reader.Read())

                    {

                        int foodid = reader.GetInt32("food_id");

                        string foodname = reader.GetString("food_name");

                        int enabled = reader.GetInt32("enabled");

                        int price = reader.GetInt32("price");

                        int imageid = reader.IsDBNull(4) ? 0 : reader.GetInt32("image_id");

                        System.Diagnostics.Debug.WriteLine("Image id: " + imageid);

                        string description = reader.GetString("description");


                        if (enabled == 1)

                        {

                            list.Add(new Food(foodid, foodname, enabled, price, imageid, description));

                        }

                    }

                }

                conn.Close();

            }

            return list;

        }
    }
    }
}
