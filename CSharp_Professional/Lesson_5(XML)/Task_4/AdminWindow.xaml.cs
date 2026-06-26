using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Task_4;

namespace Task_4
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            string[] colors = 
            {
                "White",
                "Black",
                "Red",
                "Blue",
                "Green",
                "Yellow",
                "Gray",
                "LightBlue",
                "LightGreen",
                "LightYellow",
                "Pink"
            };
            BackColorComboBox.ItemsSource = colors;
            FontColorComboBox.ItemsSource = colors;
            ApplicationSettings settings = new ApplicationSettings();
            string json = File.ReadAllText("settings.json");
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("settings.json", optional: false)
                .Build();
            configuration.GetSection("Application").Bind(settings);

            /*ConfigurationRoot? config =
                JsonSerializer.Deserialize<ConfigurationRoot>(json);
            if (config == null)
            {
                MessageBox.Show("Помилка читання конфігурації.");
                return;
            }
            ApplicationSettings settings =
                config.Application;*/
            HeaderTextBox.Text = settings.HeaderText;
            TitleTextBox.Text = settings.WindowTitle;
            FontSizeTextBox.Text = settings.FontSize.ToString();
            BackColorComboBox.SelectedItem = settings.BackgroundColor;
            FontColorComboBox.SelectedItem = settings.TextColor;
        }
        private void settingSaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ApplicationSettings settings = new ApplicationSettings
                {
                    HeaderText = HeaderTextBox.Text ?? "",
                    WindowTitle = TitleTextBox.Text ?? "",
                    FontSize = int.Parse(FontSizeTextBox.Text ?? "18"),
                    BackgroundColor = BackColorComboBox.SelectedItem?.ToString() ?? "White",
                    TextColor = FontColorComboBox.SelectedItem?.ToString() ?? "Black"
                };
                var config = new
                {
                    Application = settings
                };
                string json = JsonSerializer.Serialize(
                    config,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });
                File.WriteAllText("settings.json", json);
                MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
