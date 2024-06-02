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

namespace UsersControlElemets
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

        private void PriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PriceTextBox.Text == string.Empty)
                CostLabel.Content = "0";
            else
                CostLabel.Content = ProductCounter.Value * Convert.ToInt32(PriceTextBox.Text);
        }

        private void ProductCounter_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PriceTextBox.Text, out int cost))
                CostLabel.Content = ProductCounter.Value * cost;
        }
    }
}
