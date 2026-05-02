using TasK_5_Calculator_.CalculatorApp;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Calculator calc = new Calculator();

Console.WriteLine("Вітаємо у простому калькуляторі!");
Console.WriteLine("Ви можете виконувати операції додавання (+), віднімання (-), множення (*), та ділення (/).");

bool exit = true;
while (exit)
{
    try
    {
        Console.Write("Введіть перше число: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
            throw new FormatException("Помилка: Введено не число.");

        Console.Write("Введіть друге число: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
            throw new FormatException("Помилка: Введено не число.");

        Console.WriteLine("Виберіть операцію (+, -, *, /): ");
        string? sign = Console.ReadLine();

        double result = 0;

        result = sign switch
        {
        "+" => calc.Add(num1, num2),
        "-" => calc.Sub(num1, num2),
        "*" => calc.Mul(num1, num2),
        "/" => calc.Div(num1, num2),
            _ => throw new InvalidOperationException("Помилка: Невідома операція.")
        };

        Console.WriteLine($"Результат: {result}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Виникла непередбачена помилка: {ex.Message}");
    }

    Console.WriteLine("\nЩоб продовжити або вийти введіть 'y/n': ");
    string? input = Console.ReadLine();
    if (input?.ToLower() == "n")
    {
        exit = false;
    }
}
       