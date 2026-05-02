using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{

    public struct ColorPrinter
    {
        public void PrintStr(string str, MyColor color)
        {
            ConsoleColor consoleColor = (ConsoleColor)color;
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(str);
            Console.ResetColor();

        }
    }
}
