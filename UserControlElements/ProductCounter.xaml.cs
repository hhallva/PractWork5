using System.Windows;
using System.Windows.Controls;

namespace UsersControlElemets
{
    /// <summary>
    /// Логика взаимодействия для ProductCounter.xaml
    /// </summary>
    public partial class ProductCounter : UserControl
    {
        public int MaxValue { get; set; }
        public int Value { get; set; }

        public event RoutedEventHandler ValueChanged;

        public ProductCounter()
        {
            InitializeComponent();

            Value = 0;
            DigitTextBox.Text = Value.ToString();
            MinusButton.IsEnabled = false;
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value > 0)
            {
                Value--;
                if (Value == 0)
                    MinusButton.IsEnabled = false;
                PlusButton.IsEnabled = true;

                DigitTextBox.Text = Value.ToString();
                ValueChanged?.Invoke(this, new RoutedEventArgs());
            }
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value < MaxValue)
            {
                Value++;
                if (Value == MaxValue)
                    PlusButton.IsEnabled = false;
                MinusButton.IsEnabled = true;

                DigitTextBox.Text = Value.ToString();
                ValueChanged?.Invoke(this, new RoutedEventArgs());
            }
        }
    }
}
