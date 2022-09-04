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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var result = this.Label.Content.ToString();

            //int.Parse(result);
            List<int> listofNumber = new List<int>();
            listofNumber.Add(1);
            listofNumber.Add(2);
            List<char> chars = new List<char>();
            chars.Add('+');
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var sender2 = sender as Button;
            this.Label.Content += sender2.Content.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var last = this.Label.Content.ToString().Length - 1;
            this.Label.Content= this.Label.Content.ToString().Remove(last);
        }
    }
}
