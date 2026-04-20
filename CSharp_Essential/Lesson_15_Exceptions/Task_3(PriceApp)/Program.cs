using System;
using System.Linq;
using Task_3;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

const int count = 2;
Price[] prices = new Price[count];


for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введіть дані для товару #{i + 1}:");

    Console.Write("Назва товару: ");
    string productName = Console.ReadLine();

    Console.Write("Назва магазину: ");
    string shopName = Console.ReadLine();

    decimal cost;
    while (true)
    {
        Console.Write("Вартість товару (грн): ");
        if (!decimal.TryParse(Console.ReadLine(), out cost))
        {
            Console.WriteLine("Помилка: введено некоректну вартість. Повторіть введення.");
            continue;
        }
        else
            break;
    }

    prices[i] = new Price
    {
        ProductName = productName,
        ShopName = shopName,
        Cost = cost
    };
    Console.WriteLine();
}


prices = prices.OrderBy(p => p.ShopName).ToArray();

while (true)
{
    Console.Write("Введіть назву магазину для пошуку: ");
    string searchShop = Console.ReadLine();

    try
    {
        List<Price> results = new List<Price>();
        foreach (var pr in prices)
        {
            if (pr.ShopName.ToLower() == searchShop.ToLower())
            {
                Console.WriteLine($"Назва товару: {pr.ProductName}, Вартість: {pr.Cost} грн.");
                results.Add(pr);
            }
        }

        if (results.Count == 0)
        {
            // Якщо товарів немає, генеруємо виняток
            throw new Exception($"Помилка: Магазин '{searchShop}' не знайдено у списку.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Будь ласка, спробуйте ще раз.");
        Console.WriteLine("Щоб вийти, натисніть клавішу Esc.");
        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
        {
            break;
        }
    }
    Console.WriteLine("Щоб вийти, натисніть клавішу Esc.");
    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
    {
        break;
    }
}

       