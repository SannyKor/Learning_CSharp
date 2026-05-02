using Task_4;
Console.OutputEncoding = System.Text.Encoding.Unicode;
MyArrayList list = new MyArrayList();


list.Add("Hello");
Console.WriteLine($"Додаємо до списку: {list[0]}");
list.Add(42);
Console.WriteLine($"Додаємо до списку: {list[1]}");
list.Add(true);
Console.WriteLine($"Додаємо до списку: {list[2]}");
list.Add(3.14);
Console.WriteLine($"Додаємо до списку: {list[3]}\n");


for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"Елемент {i + 1}: {list[i]}");
}

Console.WriteLine($"\nКількість елементів: {list.Count}");
Console.WriteLine($"Другий елемент: {list[1]}");

list[1] = 100;
Console.WriteLine($"Оновлений другий елемент: {list[1]}");
    
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"Елемент {i + 1}: {list[i]}");
}

Console.ReadKey();