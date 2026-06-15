using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string path = "receipt.txt";


using (StreamReader reader = new StreamReader(path))
{
    string? dateLine = reader.ReadLine();
    var date = DateTime.Parse(dateLine);

    //ліст закриваємо кортежем щоб розділити назву та ціну
    List<(string Name, decimal Price)> items = new();
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] parts = line.Split(":");
        if (parts.Length == 2)
        {
            items.Add((parts[0], decimal.Parse(parts[1], CultureInfo.InvariantCulture)));
        }
    }
    Console.WriteLine("=== Поточна локаль ===");
    PrintReceipt(date, items, CultureInfo.CurrentCulture);

    Console.WriteLine();

    Console.WriteLine("=== Локаль en-US ===");
    PrintReceipt(date, items, new CultureInfo("en-US"));
}
static void PrintReceipt(DateTime date, List<(string Name, decimal Price)> items, CultureInfo culture)
{
    decimal total = 0;
    Console.WriteLine($"Date: {date.ToString(culture)}");
    foreach(var item in items)
    {
        Console.WriteLine($"{item.Name}: {item.Price.ToString("C", culture)}");
        total += item.Price;
    }
    Console.WriteLine($"Total: {total.ToString("C", culture)}"); 
}

