using Task_2;

Console.OutputEncoding = System.Text.Encoding.Unicode;

MyList<int> list = new MyList<int>();
Random rand = new Random();
for (int i = 0; i < 5; i++)
{
    list.Add(rand.Next(1, 100));
}
Console.WriteLine($"Кількість елементів у списку: {list.Count}");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"Елемент {i}: {list[i]}");
}