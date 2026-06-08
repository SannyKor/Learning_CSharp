using System.IO;
using System.IO.IsolatedStorage;
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
        private const string FileName = "user_settings.txt";
        public MainWindow()
        {
            InitializeComponent();
            LoadDataFromStorage();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForAssembly())
                {
                    using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(FileName, FileMode.Create, isoStore))
                    {
                        using (StreamWriter writer = new StreamWriter(isoStream))
                        {
                            writer.Write(NoteTextBox.Text);
                        }
                    }
                }
                MessageBox.Show("Дані успішно збережено в Isolated Storage!", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadDataFromStorage()
        {
            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForAssembly())
                {
                    if (isoStore.FileExists(FileName))
                    {
                        using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(FileName, FileMode.Open, isoStore))
                        {
                            using (StreamReader reader = new StreamReader(isoStream))
                            {
                                NoteTextBox.Text = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            NoteTextBox.Clear();

            try
            {
                using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForAssembly())
                {
                    if (isoStore.FileExists(FileName))
                    {
                        isoStore.DeleteFile(FileName);
                        MessageBox.Show("Файл видалено зі сховища.", "Інфо", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при видаленні: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}