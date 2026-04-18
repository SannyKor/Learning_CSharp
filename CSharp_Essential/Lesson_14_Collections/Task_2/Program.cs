using Task_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
MyList<int> numbers = new MyList<int>();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

Console.WriteLine($"Кількість елементів: {numbers.Count}");

Console.WriteLine($"Другий елемент (індекс 1): {numbers[1]}");

Console.WriteLine("Всі елементи колекції:");
foreach (var item in numbers)
{
    Console.WriteLine(item);
}

Console.ReadKey();