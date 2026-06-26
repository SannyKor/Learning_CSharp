using Task_4_OrderedDictionry_;

Console.OutputEncoding = System.Text.Encoding.UTF8;
MyOrderedDictionary<string, int> d1 = new MyOrderedDictionary<string, int>
{
    ["num1"] = 10,
    ["num2"] = 20,
    ["num3"] = 30,
    ["num4"] = 40,
    ["num5"] = 50
};
Console.WriteLine($"\nСтворена колекція {nameof(d1)}:");
foreach (var kvp in d1)
{
    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
}

MyOrderedDictionary<string, int> d2 = new MyOrderedDictionary<string, int>
{
    ["num1"] = 50,
    ["num2"] = 40,
    ["num3"] = 30,
    ["num4"] = 20,
    ["num5"] = 10
};
Console.WriteLine($"\nСтворена колекція {nameof(d2)}:");
foreach (var kvp in d2)
{
    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
}
MyOrderedDictionary<string, int> d3 = new MyOrderedDictionary<string, int>
{
    ["num1"] = 10,
    ["num2"] = 20,
    ["num3"] = 30,
    ["num4"] = 40,
    ["num5"] = 50
};
Console.WriteLine($"\nСтворена колекція {nameof(d3)}:");
foreach (var kvp in d3)
{
    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
}

MyOrderedDictionary<string, int> d4 = new MyOrderedDictionary<string, int>();
d4 = d1;
Console.WriteLine($"\nСтворена колекція {nameof(d4)}:");
foreach (var kvp in d4)
{
    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
}

MyOrderedDictionary<string, int> d5 = new MyOrderedDictionary<string, int>
{
    ["num1"] = 10,
    ["num2"] = 20,
    ["num3"] = 30
};
Console.WriteLine($"\nСтворена колекція {nameof(d5)}:");
foreach (var kvp in d5)
{
    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
}
Console.WriteLine($"\nПорівнюємо {nameof(d1)} та {nameof(d2)}:");
d1.Equals(d2);
Console.WriteLine($"\nПорівнюємо {nameof(d1)} та {nameof(d3)}:");
d1.Equals(d3);
Console.WriteLine($"\nПорівнюємо {nameof(d1)} та {nameof(d4)}:");
d1.Equals(d4);
Console.WriteLine($"\nПорівнюємо {nameof(d1)} та {nameof(d5)}:");
d1.Equals(d5);
