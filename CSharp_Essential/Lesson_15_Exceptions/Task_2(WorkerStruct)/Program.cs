using Task_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

const int count = 5;
Worker[] workers = new Worker[count];

Console.WriteLine($"Введіть дані про {count} працівників:");

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"\nПрацівник #{i + 1}:");

    Console.Write("Прізвище та ініціали: ");
    string? name = Console.ReadLine();

    Console.Write("Посада: ");
    string? position = Console.ReadLine();

    int year;
    try
    {
        Console.Write("Рік прийняття на роботу: ");
        string? inputYear = Console.ReadLine();

                
        if (!int.TryParse(inputYear, out year) || inputYear.Length != 4 || year > DateTime.Now.Year)
        {
            throw new FormatException("Рік введено у невірному форматі або такої дати не існує.");
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Помилка: {ex.Message}");
        i--; // Повторити введення для цього ж працівника
        continue;
    }

    workers[i] = new Worker
    {
        Name = name ?? string.Empty,
        Position = position ?? "Не вказано.",
        YearJoined = year
    };
}

// Впорядкування за абеткою (за прізвищем)
var sortedWorkers = workers.OrderBy(w => w.Name).ToArray();

Console.Write("\nВведіть мінімальний стаж роботи для пошуку: ");
if (int.TryParse(Console.ReadLine(), out int requiredExperience))
{
    int currentYear = DateTime.Now.Year;
    bool found = false;

    Console.WriteLine($"\nПрацівники зі стажем понад {requiredExperience} років:");
    foreach (var worker in sortedWorkers)
    {
        int experience = currentYear - worker.YearJoined;
        if (experience > requiredExperience)
        {
            Console.WriteLine($"- {worker.Name} (Стаж: {experience} р.)");
            found = true;
        }
    }

    if (!found)
    {
        Console.WriteLine("Таких працівників не знайдено.");
    }
}
else
{
    Console.WriteLine("Некоректне значення стажу.");
}
