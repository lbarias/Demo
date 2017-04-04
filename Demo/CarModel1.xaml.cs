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

namespace Demo
{
    /// <summary>
    /// Interaction logic for CarModel1.xaml
    /// </summary>
    public partial class CarModel1 : UserControl
    {
        public CarModel1()
        {
            InitializeComponent();
        }

        private void BlueisChecked(object sender, RoutedEventArgs e)
        {
            if (Brown.IsChecked ==true)
            {
                MainWindow.switchToBlueandBrown();
            }
            else if (Grey.IsChecked == true){
                MainWindow.switchToBlueandGrey();
            }
        }
    }
}
