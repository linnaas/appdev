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

namespace Admin___Edit_Delete_food
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        private object NavigationService;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The food { newNameoffoodText.Text } has now been updated!");
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The food has now been deleted!");
        }


        private void SaveButton1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The food {newNameoffoodText1.Text} has now been updated!");
        }

        private void DeleteButton1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The food has now been deleted!");
        }

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Page1.xaml , UriKind.Relative");
        }
    }
}
