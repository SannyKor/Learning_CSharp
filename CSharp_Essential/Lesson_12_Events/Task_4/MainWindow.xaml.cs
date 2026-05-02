using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICalculatorView
    {
        public double Value1 =>  double.TryParse(Value1TextBox.Text, out var value) ? value : throw new FormatException("Invalid input for Value 1");
        public double Value2 => double.TryParse(Value2TextBox.Text, out var value) ? value : throw new FormatException("Invalid input for Value 2");
        public double Result { set => ResultTextBox.Text = value.ToString(); }
        string _operation;
        public string Operation { get => _operation;
            private set { _operation = value;
                OperationTextBlock.Text = value; } }        
        public event EventHandler CalcClick;

        public MainWindow()
        {
            InitializeComponent();
            new CalculatorPresenter(this, new CalculatorModel());
        }

        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            Operation = "+";
            CalcClick?.Invoke(this, EventArgs.Empty);
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            Operation = "-";
            CalcClick?.Invoke(this, EventArgs.Empty);
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            Operation = "*";
            CalcClick?.Invoke(this, EventArgs.Empty);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            Operation = "/";
            CalcClick?.Invoke(this, EventArgs.Empty);
        }
        private void ValueTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == "Value")
            {
                textBox.Text = "";
            }
        }
    }
}