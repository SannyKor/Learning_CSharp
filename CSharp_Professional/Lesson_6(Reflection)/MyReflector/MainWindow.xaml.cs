using Microsoft.Win32;
using System.Reflection;
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

namespace MyReflector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Assembly? _assembly = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файли збірок (*.dll;*.exe)|*.dll;*.exe|Усі файли (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;

                try
                {
                    _assembly = Assembly.LoadFrom(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка завантаження збірки: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("===============================================================================================");
                sb.AppendLine($"ЗБІРКА: {path} - УСПІШНО ЗАВАНТАЖЕНА");
                sb.AppendLine($"Повне ім'я: {_assembly.FullName}");
                sb.AppendLine($"Шлях: {_assembly.Location}");
                sb.AppendLine("===============================================================================================");
                sb.AppendLine();

                try
                {
                    Type[] types = _assembly.GetTypes();
                    sb.AppendLine($"Кількість типів у збірці: {types.Length}");
                    sb.AppendLine();

                    // Аналіз кожного типу всередині збірки
                    foreach (Type type in types)
                    {
                        sb.AppendLine("-----------------------------------------------------------------------------------------------");

                        string typeKind = type.IsClass ? "Клас" :
                                          type.IsInterface ? "Інтерфейс" :
                                          (type.IsValueType && !type.IsEnum) ? "Структура" :
                                          type.IsEnum ? "Перерахування (Enum)" : "Тип";

                        sb.AppendLine($"{typeKind}: {type.FullName}");

                        // Базовий клас
                        if (type.BaseType != null)
                        {
                            sb.AppendLine($"  Базовий клас: {type.BaseType.FullName}");
                        }

                        Type[] interfaces = type.GetInterfaces();
                        if (interfaces.Length > 0)
                        {
                            sb.AppendLine("  Реалізовані інтерфейси:");
                            foreach (Type i in interfaces)
                            {
                                sb.AppendLine($"    - {i.FullName}");
                            }
                        }

                        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                        if (fields.Length > 0)
                        {
                            sb.AppendLine("  Поля:");
                            foreach (FieldInfo field in fields)
                            {
                                string access = field.IsPublic ? "public" : (field.IsPrivate ? "private" : "protected/internal");
                                sb.AppendLine($"    [{access}] {field.FieldType.Name} {field.Name}");
                            }
                        }

                        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                        if (properties.Length > 0)
                        {
                            sb.AppendLine("  Властивості:");
                            foreach (PropertyInfo prop in properties)
                            {
                                sb.AppendLine($"    {prop.PropertyType.Name} {prop.Name} {{ {(prop.CanRead ? "get;" : "")} {(prop.CanWrite ? "set;" : "")} }}");
                            }
                        }

                        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
                        if (methods.Length > 0)
                        {
                            sb.AppendLine("  Методи:");
                            foreach (MethodInfo method in methods)
                            {
                                string access = method.IsPublic ? "public" : (method.IsPrivate ? "private" : "protected/internal");

                                ParameterInfo[] parameters = method.GetParameters();
                                string[] paramStrings = new string[parameters.Length];
                                for (int i = 0; i < parameters.Length; i++)
                                {
                                    paramStrings[i] = $"{parameters[i].ParameterType.Name} {parameters[i].Name}";
                                }
                                string paramsText = string.Join(", ", paramStrings);

                                sb.AppendLine($"    [{access}] {method.ReturnType.Name} {method.Name}({paramsText})");
                            }
                        }
                        sb.AppendLine();
                    }
                }
                catch (ReflectionTypeLoadException ex)
                {
                    sb.AppendLine($"[Помилка зчитування типів]: {ex.Message}");
                    if (ex.LoaderExceptions != null)
                    {
                        foreach (Exception? loaderEx in ex.LoaderExceptions)
                        {
                            if (loaderEx != null) sb.AppendLine($"  Додатково: {loaderEx.Message}");
                        }
                    }
                }
                ResultTextBox.Text = sb.ToString();
            }
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}