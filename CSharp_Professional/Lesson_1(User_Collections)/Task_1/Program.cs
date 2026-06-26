using Task_1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<ClassMonth> months = new List<ClassMonth>
{
    new ClassMonth("January", 1, 31, WeatherSeason.Winter),
    new ClassMonth("February", 2, 28, WeatherSeason.Winter),
    new ClassMonth("March", 3, 31, WeatherSeason.Spring),
    new ClassMonth("April", 4, 30, WeatherSeason.Spring),
    new ClassMonth("May", 5, 31, WeatherSeason.Spring),
    new ClassMonth("June", 6, 30, WeatherSeason.Summer),
    new ClassMonth("July", 7, 31, WeatherSeason.Summer),
    new ClassMonth("August", 8, 31, WeatherSeason.Summer),
    new ClassMonth("September", 9, 30, WeatherSeason.Autumn),
    new ClassMonth("October", 10, 31, WeatherSeason.Autumn),
    new ClassMonth("November", 11, 30, WeatherSeason.Autumn),
    new ClassMonth("December", 12, 31, WeatherSeason.Winter)
};

Console.WriteLine("Знаходим місяць за номером 5:");
int monthNumber = 5; // Example month number
var selectedMonth = months.Find(m => m.Number == monthNumber);
if (selectedMonth != null)
{
    Console.WriteLine(selectedMonth);
}
else
{
    Console.WriteLine("Month not found.");
}

Console.WriteLine("\nЗнаходим місяці з 30 днями:");
var monthsWith30Days = months.FindAll(m => m.Days == 30);
foreach (var month in monthsWith30Days)
{
    Console.WriteLine(month);
}

Console.WriteLine("\nЗнаходим місяці, які належать до сезону 'Summer':");
var summerMonths = months.FindAll(m => m.Season == WeatherSeason.Summer);
foreach (var month in summerMonths)
{
    Console.WriteLine(month);
}