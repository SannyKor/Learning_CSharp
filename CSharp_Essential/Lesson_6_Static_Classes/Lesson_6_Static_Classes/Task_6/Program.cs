using Task_6;


Random random = new Random();
int a = random.Next(1, 100);
int b = random.Next(1, 100);
Console.WriteLine($"{a} + {b} = {MyCalculator.Add(a, b)}");
Console.WriteLine($"{a} - {b} = {MyCalculator.Subtract(a, b)}");
Console.WriteLine($"{a} * {b} = {MyCalculator.Multiply(a, b)}");
Console.WriteLine($"{a} / {b} = {MyCalculator.Divide(a, b)}");
