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

namespace Task_3_Reflector_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Assembly? _assembly = null;
        private string _currentPath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();

            // Додаємо підписку на події зміни стану CheckBox, щоб інтерфейс оновлювався миттєво
            ShowFieldsCheckBox.Checked += FilterChanged;
            ShowFieldsCheckBox.Unchecked += FilterChanged;
            ShowPropertiesCheckBox.Checked += FilterChanged;
            ShowPropertiesCheckBox.Unchecked += FilterChanged;
            ShowMethodsCheckBox.Checked += FilterChanged;
            ShowMethodsCheckBox.Unchecked += FilterChanged;
            ShowAttributesCheckBox.Checked += FilterChanged;
            ShowAttributesCheckBox.Unchecked += FilterChanged;
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файли збірок (*.dll;*.exe)|*.dll;*.exe|Усі файли (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                _currentPath = openFileDialog.FileName;

                try
                {
                    _assembly = Assembly.LoadFrom(_currentPath);
                    AnalyzeAssembly();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка завантаження збірки: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void FilterChanged(object sender, RoutedEventArgs e)
        {
            // Оновлюємо аналіз лише якщо збірка вже завантажена
            if (_assembly != null)
            {
                AnalyzeAssembly();
            }
        }

        private void AnalyzeAssembly()
        {
            if (_assembly == null) return;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("===============================================================================================");
            sb.AppendLine($"ЗБІРКА: {_currentPath} - УСПІШНО ЗАВАНТАЖЕНА");
            sb.AppendLine($"Повне ім'я: {_assembly.FullName}");
            sb.AppendLine($"Шлях: {_assembly.Location}");
            sb.AppendLine("===============================================================================================");
            sb.AppendLine();

            try
            {
                Type[] types = _assembly.GetTypes();
                sb.AppendLine($"Кількість типів у збірці: {types.Length}");
                sb.AppendLine();

                bool showFields = ShowFieldsCheckBox.IsChecked ?? false;
                bool showProperties = ShowPropertiesCheckBox.IsChecked ?? false;
                bool showMethods = ShowMethodsCheckBox.IsChecked ?? false;
                bool showAttributes = ShowAttributesCheckBox.IsChecked ?? false;

                foreach (Type type in types)
                {
                    sb.AppendLine("-----------------------------------------------------------------------------------------------");

                    // Атрибути самого типу
                    if (showAttributes)
                    {
                        AppendAttributes(sb, type, "  ");
                    }

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

                    // Реалізовані інтерфейси
                    Type[] interfaces = type.GetInterfaces();
                    if (interfaces.Length > 0)
                    {
                        sb.AppendLine("  Реалізовані інтерфейси:");
                        foreach (Type i in interfaces)
                        {
                            sb.AppendLine($"    - {i.FullName}");
                        }
                    }

                    // 1. ПОЛЯ
                    if (showFields)
                    {
                        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                        if (fields.Length > 0)
                        {
                            sb.AppendLine("  Поля:");
                            foreach (FieldInfo field in fields)
                            {
                                if (showAttributes) AppendAttributes(sb, field, "    ");
                                string access = field.IsPublic ? "public" : (field.IsPrivate ? "private" : "protected/internal");
                                sb.AppendLine($"    [{access}] {field.FieldType.Name} {field.Name}");
                            }
                        }
                    }

                    // 2. ВЛАСТИВОСТІ
                    if (showProperties)
                    {
                        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                        if (properties.Length > 0)
                        {
                            sb.AppendLine("  Властивості:");
                            foreach (PropertyInfo prop in properties)
                            {
                                if (showAttributes) AppendAttributes(sb, prop, "    ");
                                sb.AppendLine($"    {prop.PropertyType.Name} {prop.Name} {{ {(prop.CanRead ? "get;" : "")} {(prop.CanWrite ? "set;" : "")} }}");
                            }
                        }
                    }

                    // 3. МЕТОДИ
                    if (showMethods)
                    {
                        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
                        if (methods.Length > 0)
                        {
                            sb.AppendLine("  Методи:");
                            foreach (MethodInfo method in methods)
                            {
                                if (showAttributes) AppendAttributes(sb, method, "    ");
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

        /// <summary>
        /// Допоміжний метод для зчитування та виведення атрибутів з будь-якого члена типу (MemberInfo)
        /// </summary>
        private void AppendAttributes(StringBuilder sb, MemberInfo member, string indent)
        {
            // Отримуємо всі атрибути, ігноруючи успадковані (inherit: false), або true якщо потрібні й батьківські
            object[] attributes = member.GetCustomAttributes(false);

            foreach (object attr in attributes)
            {
                sb.AppendLine($"Атрибут: {indent}[{attr.GetType().Name}]");
            }
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
