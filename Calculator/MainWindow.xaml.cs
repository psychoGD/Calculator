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

namespace Calculator
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
        public char Op { get; set; } = 'e';
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public int Count { get; set; } = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (Op == '+')
            {
                var result = FirstNumber + SecondNumber;
                Label.Content = result;
                FirstNumber = result;
                SecondNumber = 0;
                Op = 'e';
                
            }
            else if(Op == '-')
            {
                var result = FirstNumber - SecondNumber;
                Label.Content = result;
                FirstNumber = result;
                SecondNumber = 0;
                Op = 'e';
            }
            else if (Op == '*')
            {
                var result = FirstNumber * SecondNumber;
                Label.Content = result;
                FirstNumber = result;
                SecondNumber = 0;
                Op = 'e';
            }
            else
            {
                if(SecondNumber == 0 && FirstNumber == 0)
                {
                    Label.Content = "Result is undefined";
                }
                else if(SecondNumber == 0 && FirstNumber > 0)
                {
                    Label.Content = "Cannot Divide By Zero";
                }
                else
                {
                    var result = FirstNumber / SecondNumber;
                    Label.Content = result;
                    FirstNumber = result;
                    SecondNumber = 0;
                    Op = 'e';
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var sender2 = sender as Button;
            this.Label.Content += sender2.Content.ToString();
            
            if (Op=='e')
            {
                FirstNumber = double.Parse(Label.Content.ToString());
                
            }
            else
            {
                var s2 = SecondNumber.ToString();
                SecondNumber = double.Parse(s2+sender2.Content.ToString());
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Label.Content = string.Empty;
            
        }

        private void OpButton_Click_3(object sender, RoutedEventArgs e)
        {
            var sender2 = sender as Button;
            this.Label.Content += sender2.Content.ToString();
            Op = char.Parse(sender2.Content.ToString());
        }
    }
}
