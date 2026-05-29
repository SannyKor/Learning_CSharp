
Console.OutputEncoding = System.Text.Encoding.UTF8;
SortedList<string, decimal> fruits = new SortedList<string, decimal>
{
    { "Яблуко", 1.20m },
    { "Банан", 0.80m },
    { "Вишня", 2.50m },
    { "Груша", 1.50m },
    { "Апельсин", 1.00m },
    { "Ківі", 1.80m },
    { "Манго", 2.00m },
    { "Ананас", 3.00m },
    { "Лимон", 0.90m },
    { "Гранат", 2.20m },
    { "Персик", 1.70m },
    { "Слива", 1.30m },
    { "Малина", 2.80m },
    { "Лохина", 3.50m },
    { "Кавун", 0.60m }
};
Console.WriteLine("Список фруктів та їх ціни в алфавітному порядку:");
foreach (var fruit in fruits)
{
    Console.WriteLine($"\t{fruit.Key} \t- \t{fruit.Value} грн;");
}
Console.WriteLine(new string('-', 40));

Console.WriteLine("Список фруктів та їх ціни в зворотному алфавітному порядку:");
foreach (var fruit in fruits.Reverse())
{
    Console.WriteLine($"\t{fruit.Key} \t- \t{fruit.Value} грн;");
}