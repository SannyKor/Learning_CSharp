
using System.Globalization;
using Task_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
while (true)
{
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
    var colors = (MyColor[])Enum.GetValues(typeof(MyColor));
    for (int i = 0; i < colors.Length; i++)
    {
        Console.WriteLine($"{(i + 1)} - {colors[i]}");
    }

    while (true)
    {
        string chosen = Console.ReadLine();
        if (Int32.TryParse(chosen, out int colorNumber)&&colorNumber <= colors.Length)
        { 
            color = colors[colorNumber - 1];
            break;
        }
        else if (Enum.TryParse(chosen, true, out color) && Enum.IsDefined(typeof(MyColor), color) && colorNumber <= colors.Length)
            break;
        Console.WriteLine("Щось пішло не так, спробуйте ще.");
    }
        colorPrinter.PrintStr(str, color);
    Console.WriteLine("Щоб продовжити або закінчити введіть Y/N:");
    char exit = Console.ReadKey().KeyChar;
    if (char.ToLower(exit) == 'n')
        break;
    Console.Clear();
}