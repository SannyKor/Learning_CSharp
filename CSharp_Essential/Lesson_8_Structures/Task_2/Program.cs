
using System.Globalization;
using Task_2;

ColorPrinter colorPrinter = new ColorPrinter();
Console.WriteLine("Введіть текст для відображення:");
string str;
while(true)
{
    str = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(str))
        break;
    Console.WriteLine("Щось пішло не так, спробуйте ще.");
}

MyColor color;
Console.WriteLine("Виберіть один з кольорів:");
foreach (var value in Enum.GetValues(typeof(MyColor)))
{
    Console.WriteLine($"{(int)value} - {value}");
}
while (true)
{
    string chosen = Console.ReadLine();
    if (Enum.TryParse(chosen, true, out color) && Enum.IsDefined(typeof(MyColor), color))
        break;
    Console.WriteLine("Щось пішло не так, спробуйте ще.");
}
colorPrinter.PrintStr(str, color);