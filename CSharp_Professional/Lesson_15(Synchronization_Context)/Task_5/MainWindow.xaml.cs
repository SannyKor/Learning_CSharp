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

namespace Task_5
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
        public int Addition(int a, int b)
        {
            Thread.Sleep(1000);
            return a + b;
        }

        private async void MyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(
                        $"До await\n" +
                        $"ThreadId: {Thread.CurrentThread.ManagedThreadId}\n" +
                        $"IsThreadPool: {Thread.CurrentThread.IsThreadPoolThread}");
                //int result = await Task.Run(() => Addition(5, 10));
                int result = await Task.Run(() => Addition(5, 10)).ConfigureAwait(false);
                //Dispatcher.Invoke(() =>
                //{
                //    MyTextBox.Text = result.ToString();
                //});
                MessageBox.Show(
                        $"Після await\n" +
                        $"ThreadId: {Thread.CurrentThread.ManagedThreadId}\n" +
                        $"IsThreadPool: {Thread.CurrentThread.IsThreadPoolThread}");
                MyTextBox.Text = $"Результат додавання: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}