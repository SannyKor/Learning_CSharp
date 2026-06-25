using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging.Effects;
using System.IO;
using System.Text;
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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        private readonly string filePath = "user_data.txt";
        public UserWindow()
        {
            InitializeComponent();
            LoadUserData();
            ApplicationSettings settings = new ApplicationSettings();
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("settings.json", optional: false)
                .Build();
            configuration.GetSection("Application").Bind(settings);

            /*titleTextBlock.Text = configuration["Application:HeaderText"];
            infoTextBox.Background = new SolidColorBrush((Color)ColorConverter
                .ConvertFromString(configuration["Application:BackGroundColor"]));
            infoTextBox.Foreground = new SolidColorBrush((Color)ColorConverter
                .ConvertFromString(configuration["Application:textColor"]));
            infoTextBox.FontSize = double.Parse(configuration["Application:FontSize"]);
            Title = configuration["Application:WindowTitle"];*/
            titleTextBlock.Text = settings.HeaderText;
            Title = settings.WindowTitle;
            infoTextBox.FontSize = double.Parse(settings.FontSize.ToString());
            infoTextBox.Background = new SolidColorBrush((Color)ColorConverter
                .ConvertFromString(settings.BackgroundColor)); ;
            infoTextBox.Foreground = new SolidColorBrush((Color)ColorConverter
                .ConvertFromString(settings.TextColor));
        }
        private void LoadUserData()
        {
            try
            {
                if(File.Exists(filePath))
                {
                    infoTextBox.Text = File.ReadAllText(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void infoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void infoTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if(infoTextBox.Text == "Почніть запис...")
            {
                infoTextBox.Text = string.Empty;
                infoTextBox.Foreground = ;
            }
        }

        private void infoTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(infoTextBox.Text == string.Empty)
            {
                infoTextBox.Text = "Почніть запис...";
                infoTextBox.Foreground = Brushes.Gray;
            }
        }

        private void saveInfoButton_Click(object sender, RoutedEventArgs e)
        {
            string savedInfo = infoTextBox.Text.Trim();
            try
            {
                File.WriteAllText(filePath, savedInfo);
                MessageBox.Show("Дані збережено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при збереженні даних: " + ex.Message);
            }
        }
    }
}
