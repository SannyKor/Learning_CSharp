using Task_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Block block1 = new Block(10, 20, 30, 40);
Block block2 = new Block(10, 20, 30, 40);
Block block3 = new Block(5, 10, 15, 20);


Console.WriteLine("Інформація про блоки:");
Console.WriteLine(block1.ToString());
Console.WriteLine(block3.ToString());


Console.WriteLine("\nПорівняння:");
Console.WriteLine($"block1 дорівнює block2: {block1.Equals(block2)}"); 
Console.WriteLine($"block1 дорівнює block3: {block1.Equals(block3)}");

Console.ReadKey();