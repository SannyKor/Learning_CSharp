using System.Reflection;

namespace Task_5
{
    internal class Program
    {
        static readonly AccessLevel RequiredLevel = AccessLevel.Admin;

        static void CheckAccess(Employee employee)
        {
            Type type = employee.GetType();

            AccessLevelAttribute attribute =
                type.GetCustomAttribute<AccessLevelAttribute>()
                ?? throw new Exception("Відсутній AccessLevelAttribute.");

            Console.WriteLine($"Співробітник: {employee.Name}");
            Console.WriteLine($"Посада: {type.Name}");
            Console.WriteLine($"Рівень доступу: {attribute.Level}");

            if (attribute.Level >= RequiredLevel)
            {
                Console.WriteLine("Доступ дозволено.");
            }
            else
            {
                Console.WriteLine("Доступ заборонено.");
            }

            Console.WriteLine(new string('-', 35));
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Employee[] employees =
            {
                new Manager("Іван"),
                new Programmer("Олександр"),
                new Director("Петро")
            };

            foreach (Employee employee in employees)
            {
                CheckAccess(employee);
            }
        }
    }
}
