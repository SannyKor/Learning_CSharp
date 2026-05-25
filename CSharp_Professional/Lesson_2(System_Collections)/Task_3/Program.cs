

using System.Collections;

Console.WriteLine("Перший варіант, через Dictionary<TKey, TValue>:");
Dictionary<int, decimal> accounts = new Dictionary<int, decimal>();

accounts.Add(1001, 2500.75m);
accounts.Add(1002, 12000.50m);
accounts.Add(1003, 500.00m);

foreach (var account in accounts)
{
    Console.WriteLine($"Рахунок: {account.Key}  Сума: {account.Value}");
}
Console.WriteLine(new string('-', 40));

Console.WriteLine("\nДругий варіант, через Hashtable:");
Hashtable accountsHashT = new Hashtable();

accountsHashT.Add(1001, 2500.75m);
accountsHashT.Add(1002, 12000.50m);

foreach (DictionaryEntry account in accountsHashT)
{
    Console.WriteLine(
        $"Рахунок: {account.Key}, Сума: {account.Value}");
}
Console.WriteLine(new string('-', 40));

Console.WriteLine("Третій варіант, через SortedList:");
SortedList<int, decimal> accountsSL =
            new SortedList<int, decimal>();

accountsSL.Add(1003, 5000.50m);
accountsSL.Add(1001, 1200.75m);
accountsSL.Add(1002, 9800.00m);

foreach (var account in accountsSL)
{
    Console.WriteLine(
        $"Рахунок: {account.Key}, Сума: {account.Value}");
}
