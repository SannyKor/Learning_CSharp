using Task_3_MyDictionary;

Console.OutputEncoding = System.Text.Encoding.UTF8;
MyDictionary<string, string> myDict = new MyDictionary<string, string>();


myDict.Add("apple", "яблуко");
myDict.Add("book", "книга");
myDict.Add("sun", "сонце");

Console.WriteLine($"Кількість елементів: {myDict.Count}");
Console.WriteLine();

Console.WriteLine($"Значення для ключа 'book': {myDict["book"]}");
Console.WriteLine();

Console.WriteLine("Перелік усіх елементів:");
foreach (var pair in myDict)
{
    Console.WriteLine($"{pair.Key} — {pair.Value}");
}
Console.WriteLine();

Console.WriteLine($"Помилковий пошук ключа 'moon':");
try
{
    Console.WriteLine(myDict["moon"]);
}
catch (KeyNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();