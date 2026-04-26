Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

var myDictionary = new List<dynamic>
{
    new { English = "Apple", Ukrainian = "Яблуко" },
    new { English = "Table", Ukrainian = "Стіл" },
    new { English = "Sky", Ukrainian = "Небо" },
    new { English = "Book", Ukrainian = "Книга" },
    new { English = "Water", Ukrainian = "Вода" },
    new { English = "Flower", Ukrainian = "Квітка" },
    new { English = "Mountain", Ukrainian = "Гора" },
    new { English = "Friend", Ukrainian = "Друг" },
    new { English = "Time", Ukrainian = "Час" },
    new { English = "City", Ukrainian = "Місто" }
};

foreach (var item in myDictionary)
{
    Console.WriteLine($"English: {item.English} = \tUkrainian: {item.Ukrainian}");
}