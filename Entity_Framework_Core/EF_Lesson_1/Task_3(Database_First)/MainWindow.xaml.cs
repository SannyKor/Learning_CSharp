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
using Task_1.Models;

namespace Task_3_Database_First_
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

        private void BtnLoadData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new ProductDbContext())
                {
                    var productsList = context.Products.ToList();
                    DgProducts.ItemsSource = productsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Помилка під час завантаження даних: {ex.Message}",
                    "Помилка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }
        }
    }
}