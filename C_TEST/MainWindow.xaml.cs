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


namespace C_TEST
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

        private void BnCalc_Click(object sender, RoutedEventArgs e)
        {
            double num1;
            double num2;
            double num3;
            bool canConvert1;
            bool canConvert2;

            canConvert1 = double.TryParse(tb1.Text, out num1);
            canConvert2 = double.TryParse(tb2.Text, out num2);

            if (canConvert1 && canConvert2)
            {
                num3 = num1 + num2;
                tb3.Text = Convert.ToString(num3);
            }
            else
            {
                string message = "Numbers must be entered, close the application?";
                string title = "Error";

                MessageBoxResult result = MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.No);

                if (result == MessageBoxResult.Yes)
                {  
                    this.Close();
                }
                else
                {
                    
                }
            }
        }
    }
}
