using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFFractionCalculator
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        static void OpenLink(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
                Console.WriteLine($"Opening URL: {url}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while opening the link: {ex.Message}");
            }
        }

        private void TextBlock_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/NielsDenoo/FractionsCalculator";
            OpenLink(url);
        }
    }
}
