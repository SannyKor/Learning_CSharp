using System.Text.RegularExpressions;

Console.OutputEncoding = System.Text.Encoding.UTF8;
while (true)
{
    Console.WriteLine("\nДля коректної реєстрації використовуйте латинські літери для логіну та цифри/символи для пароля.");
    Console.Write("Введіть логін: ");
    string login = Console.ReadLine()!;

    Console.Write("Введіть пароль: ");
    string password = Console.ReadLine()!;

    Regex loginRegex = new Regex(@"^[A-Za-z]+$");
    Regex passwordRegex = new Regex(@"^[0-9\W_]+$");

    bool loginValid = loginRegex.IsMatch(login);
    bool passwordValid = passwordRegex.IsMatch(password);

    if (!loginValid)
    {
        Console.WriteLine("Помилка: логін повинен містити тільки латинські літери.");
    }

    if (!passwordValid)
    {
        Console.WriteLine("Помилка: пароль повинен містити тільки цифри та символи.");
    }

    if (loginValid && passwordValid)
    {
        Console.WriteLine("Реєстрація успішна!");
        break;
    }
}

