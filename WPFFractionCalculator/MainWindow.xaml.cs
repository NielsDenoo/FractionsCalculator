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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFFractionCalculator
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

        
        

        private void OperatorAdd(object sender, RoutedEventArgs e)
        {
            @operator.Text = "+";
            numerator3.Text = "";
            denominator3.Text = "";

            @operator.Visibility = Visibility.Visible;
            numerator1.Visibility = Visibility.Visible;
            denominator1.Visibility = Visibility.Visible;
            fractionLine1.Visibility = Visibility.Visible;

        }

        private void operatorSubtract(object sender, RoutedEventArgs e)
        {
            @operator.Text = "-";
            numerator3.Text = "";
            denominator3.Text = "";
            @operator.Visibility = Visibility.Visible;
            numerator1.Visibility = Visibility.Visible;
            denominator1.Visibility = Visibility.Visible;
            fractionLine1.Visibility = Visibility.Visible;
        }

        private void operatorMultiply(object sender, RoutedEventArgs e)
        {
            @operator.Text = "X";
            numerator3.Text = "";
            denominator3.Text = "";
            @operator.Visibility = Visibility.Visible;
            numerator1.Visibility = Visibility.Visible;
            denominator1.Visibility = Visibility.Visible;
            fractionLine1.Visibility = Visibility.Visible;
        }

        private void operatorDivide(object sender, RoutedEventArgs e)
        {
            @operator.Text = "/";
            numerator3.Text = "";
            denominator3.Text = "";
            @operator.Visibility = Visibility.Visible;
            numerator1.Visibility = Visibility.Visible;
            denominator1.Visibility = Visibility.Visible;
            fractionLine1.Visibility = Visibility.Visible;
        }


        private void operatorInvert(object sender, RoutedEventArgs e)
        {
            @operator.Text = "-f";
            @operator.Visibility = Visibility.Hidden;
            numerator1.Visibility = Visibility.Hidden;
            denominator1.Visibility = Visibility.Hidden;
            fractionLine1.Visibility = Visibility.Hidden;
            numerator3.Text = "";
            denominator3.Text = "";
        }

        private void operatorReciprocal(object sender, RoutedEventArgs e)
        {
            @operator.Text = "1/f";
            @operator.Visibility = Visibility.Hidden;
            numerator1.Visibility = Visibility.Hidden;
            denominator1.Visibility = Visibility.Hidden;
            fractionLine1.Visibility = Visibility.Hidden;
            numerator3.Text = "";
            denominator3.Text = "";


        }

        

        private void findResult(object sender, RoutedEventArgs e)
        {

            if (numerator1.Text == "0" || numerator2.Text == "0")
            {
                MessageBox.Show("You entered a 0 in one or more of the numerators", "warning");
                
            }
            else if (denominator1.Text == "0" || denominator2.Text == "0")
            {
                MessageBox.Show("You entered a 0 in one or more of the denominators which is not possible in fractions", "warning");
            }

            else if (@operator.Text == "+")
            {
                numerator3.Text = Convert.ToString(Convert.ToInt32(numerator1.Text) * Convert.ToInt32(denominator2.Text) + Convert.ToInt32(denominator1.Text) * Convert.ToInt32(numerator2.Text));
                denominator3.Text = Convert.ToString(Convert.ToInt32(denominator1.Text) * Convert.ToInt32(denominator2.Text));
                Simplify();
            }
            else if (@operator.Text == "-")
            {
                numerator3.Text = Convert.ToString(Convert.ToInt32(numerator1.Text) * Convert.ToInt32(denominator2.Text) - Convert.ToInt32(denominator1.Text) * Convert.ToInt32(numerator2.Text));
                denominator3.Text = Convert.ToString(Convert.ToInt32(denominator1.Text) * Convert.ToInt32(denominator2.Text));
                Simplify();
            }
            else if (@operator.Text == "X")
            {
                int num1 = Convert.ToInt32(numerator1.Text);
                int denum1 = Convert.ToInt32(denominator1.Text);
                int num2 = Convert.ToInt32(numerator2.Text);
                int denum2 = Convert.ToInt32(denominator2.Text);
                numerator3.Text = Convert.ToString(num1 * num2);
                denominator3.Text = Convert.ToString(denum1 * denum2);
                Simplify();
            }
            else if (@operator.Text == "/")
            {
                int num1 = Convert.ToInt32(numerator1.Text);
                int denum1 = Convert.ToInt32(denominator1.Text);
                int num2 = Convert.ToInt32(numerator2.Text);
                int denum2 = Convert.ToInt32(denominator2.Text);
                numerator3.Text = Convert.ToString(num1 * denum2);
                denominator3.Text = Convert.ToString(denum1 * num2);
                Simplify();
            }
            else if(@operator.Text == "-f")
            {
                int numerator = -Convert.ToInt32(numerator2.Text);
                int denominator = Convert.ToInt32(denominator2.Text);
                numerator3.Text = numerator.ToString();
                denominator3.Text = denominator.ToString();
                Simplify();
            }
            else if(@operator.Text == "1/f")
            {
                numerator3.Text = denominator2.Text;
                denominator3.Text = numerator2.Text;
                Simplify();
            }
            
        }
        public void Simplify()
        {
            int numerator = Convert.ToInt32(numerator3.Text);
            int denominator = Convert.ToInt32(denominator3.Text);

            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
            if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            else if (numerator > 0 && denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            numerator3.Text = Convert.ToString(numerator);
            denominator3.Text = Convert.ToString(denominator);
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void showInfo(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            this.Visibility = Visibility.Hidden;
            infoWindow.Show();
        }
    }   
}