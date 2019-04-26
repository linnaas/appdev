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
    
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();

            if (System.Windows.Application.Current.Properties["usernameS"] != null)
            {
                WelcomeMessage.Content = "Welcome " + System.Windows.Application.Current.Properties["usernameS"] + " !";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow d = new MainWindow();
            d.ShowDialog();
        }
    }
}
