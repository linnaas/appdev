using System;
using System.Collections.Generic;
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

namespace Test2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void EditDeleteFood_Click(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Uri("EditDeleteFood.xaml", UriKind.Relative));
        }

        private void EditDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Uri("EditDeleteEmployee.xaml", UriKind.Relative));
        }

        private void AddNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Uri("AddEmployee.xaml", UriKind.Relative));
        }

        private void AddNewFood_Click(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Uri("AddFood.xaml", UriKind.Relative));
        }
    }
}
