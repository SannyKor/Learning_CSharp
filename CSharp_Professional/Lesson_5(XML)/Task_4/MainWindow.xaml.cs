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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if(loginTextBox.Text == "UserName")
            {
                loginTextBox.Text = "";
            }
            loginTextBox.Foreground = Brushes.Black;
        }

        private void loginTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(loginTextBox.Text == "")
            {
                loginTextBox.Text = "UserName";
                loginTextBox.Foreground = Brushes.Gray;
            }

        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredLogin = loginTextBox.Text.Trim();
            if (string.Equals(enteredLogin, "Admin", StringComparison.OrdinalIgnoreCase))
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                MessageBox.Show("Вітаємо, Admin!", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else if (string.Equals(enteredLogin, "User", StringComparison.OrdinalIgnoreCase))
            {
                UserWindow userWindow = new UserWindow();
                userWindow.Show();
                MessageBox.Show("Вітаємо, User!", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний логін.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}