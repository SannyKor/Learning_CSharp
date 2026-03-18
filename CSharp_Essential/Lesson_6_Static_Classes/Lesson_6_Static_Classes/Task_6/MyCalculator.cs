using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6
{
    static class MyCalculator
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Помилка: Ділення на нуль неможливе.");
                return double.NaN; // Повертаємо NaN для позначення помилки
            }
            return a / b;
        }
    }
}
