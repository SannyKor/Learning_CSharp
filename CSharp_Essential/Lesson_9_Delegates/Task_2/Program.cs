
using System.Runtime.CompilerServices;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;

while (true)
{
    Console.Write("Введіть перше число: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Введіть друге число: ");
    double num2 = double.Parse(Console.ReadLine());

    Console.Write("Оберіть операцію (+, -, *, /): ");
    try
    {
        calculationDelegate op = Console.ReadLine() switch
        {
            "+" => (a, b) => a + b,
            "-" => (a, b) => a - b,
            "*" => (a, b) => a * b,
            "/" => (a, b) => b != 0 ? a / b : throw new DivideByZeroException("Ділити на нуль не можна!"),
            "_" => throw new InvalidOperationException("Невідома операція!")
        };
        Console.WriteLine($"Результат: {op.Invoke(num1, num2)}"); 
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine("Шоб продовжити обрахунок натисніть 'Y' або 'N' щоб вийти.");
    char exit = Console.ReadKey(true).KeyChar;
    if (Char.ToLower(exit) == 'n'|| Char.ToLower(exit) == 'т')
        break;
    Console.WriteLine();
}
    public delegate double calculationDelegate(double a, double b);
