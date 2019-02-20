using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;
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
using System.Windows.Forms;


namespace login1
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
            
        protected void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            string ConnectionS = "Server=remotemysql.com;Database=FgzHi9GyXc; Uid =FgzHi9GyXc;Pwd=c7V92jzX5b;";
            using (MySqlConnection con = new MySqlConnection(ConnectionS))
            {
                con.Open();
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"select count(*) from user_list where username=@User_Name and password=@Pword";
                    cmd.Parameters.Add(new MySqlParameter("User_Name", usernametxt.Text));
                    cmd.Parameters.Add(new MySqlParameter("Pword", passwordtxt.Password));
                    int i = Convert.ToInt32(cmd.ExecuteScalar());

                    if (i > 0)
                    {
                        System.Windows.Application.Current.Properties["usernameS"] = usernametxt.Text;                 
                        this.Hide();
                        Welcome w = new Welcome();
                        w.ShowDialog();
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Wrong Password or Username");
                    }
                }
            }
        }

        private void Usernametxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
        
    

