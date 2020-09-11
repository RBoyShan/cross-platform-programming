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

namespace WPFAppCore
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button button = new Button();
            //button.Click = new MouseButtonEventHandler(object sender, RoutedEventArgs e)

            grid.Children.Add(button);
        }

        private void ShowNumber(object sender, RoutedEventArgs e)
        {
          
            String inputValue = enterDataField.Text;
            Int32 convertValue = 0;

            try
            {
                convertValue = Convert.ToInt32(inputValue);
            }
            catch (Exception exception)
            {
                convertValue = inputValue.Split(' ').Length - 1;
            }
            finally
            {
                MessageBox.Show(convertValue.ToString());
            }
        }


    }
}
