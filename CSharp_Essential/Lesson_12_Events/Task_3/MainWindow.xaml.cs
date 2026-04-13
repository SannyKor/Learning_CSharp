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
using Task_3;

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IStopwatchView
    {
        public event EventHandler? StartClicked;
        public event EventHandler? StopClicked;
        public event EventHandler? ResetClicked;
        public MainWindow()
        {
            InitializeComponent();
            var model = new StopwatchModel();
            new StopwatchPresenter(this, model);
        }
        public void UpdateDisplay(string time) => TimeDisplay.Text = time;
        private void Button_Click(object sender, RoutedEventArgs e) => StartClicked?.Invoke(this, EventArgs.Empty);

        private void Button_Click_1(object sender, RoutedEventArgs e) => StopClicked?.Invoke(this, EventArgs.Empty);

        private void Button_Click_2(object sender, RoutedEventArgs e) => ResetClicked?.Invoke(this, EventArgs.Empty);
    }
}