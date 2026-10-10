using System.Reflection;

namespace Task_3_using_reflection_from_task_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                Assembly asm = Assembly.Load("Task_2(TemperatureConverterLibrary)");
                Console.WriteLine($"Збірку '{asm.FullName}' успішно завантажено за допомогою рефлексії.\n");

                Type converterType = asm.GetType("Task_2.CelsiusToFahrenheitConverter");

                if (converterType == null)
                {
                    Console.WriteLine("Помилка: Тип 'CelsiusToFahrenheitConverter' не знайдено в збірці.");
                    return;
                }
                string converterName = "Рефлексивний Конвертер 1.0";
                double celsiusValue = 25.0; 

                object[] constructorArgs = new object[] { converterName, celsiusValue };
                object converterInstance = Activator.CreateInstance(converterType, constructorArgs);

                Console.WriteLine($"Екземпляр типу {converterType.Name} успішно створено.");
                MethodInfo infoMethod = converterType.GetMethod("ShowConverterInfo");
                if (infoMethod != null)
                {
                    infoMethod.Invoke(converterInstance, new object[] { "Олександр" });
                }
                MethodInfo convertMethod = converterType.GetMethod("Convert");

                if (convertMethod != null)
                {
                    Console.WriteLine($"\nВикликаємо метод {convertMethod.Name}()...");
                    object result = convertMethod.Invoke(converterInstance, null);

                    Console.WriteLine($"Початкова температура: {celsiusValue} °C");
                    Console.WriteLine($"Результат конвертації: {result} °F");
                }
                else
                {
                    Console.WriteLine("Помилка: Метод 'Convert' не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка під час роботи рефлексії: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Внутрішня помилка: {ex.InnerException.Message}");
                }
            }
        }
    }
}
