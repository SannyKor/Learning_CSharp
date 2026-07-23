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
using System.Windows.Threading;

namespace Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            AddMessage("Дані отримані");
        }

        private async void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            btnConnect.IsEnabled = false;
            AddMessage("Підключення до бази даних...");
            await Task.Delay(4000);
            AddMessage("Підключено до бази даних");
            timer.Start();
            btnDisconnect.IsEnabled = true;
        }

        private async void btnDisconnect_Click(object sender, RoutedEventArgs e)
        {
            btnDisconnect.IsEnabled = false;
            AddMessage("Відключення від бази даних...");
            await Task.Delay(4000);
            timer.Stop();
            AddMessage("Відключено від бази даних");
            btnConnect.IsEnabled = true;
        }

        private void AddMessage(string message)
        {
            tbLog.AppendText($"{DateTime.Now:T}  {message}{Environment.NewLine}");
            tbLog.ScrollToEnd();
        }
    }
}