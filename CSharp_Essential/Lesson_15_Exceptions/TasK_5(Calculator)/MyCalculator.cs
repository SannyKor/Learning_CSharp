using System;
using System.Collections.Generic;
using System.Text;

namespace TasK_5_Calculator_
{
    namespace CalculatorApp
    {
        public class Calculator
        {
            public double Add(double a, double b) => a + b;

            public double Sub(double a, double b) => a - b;

            public double Mul(double a, double b) => a * b;

            public double Div(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Помилка: Ділення на нуль неможливе.");
                }
                return a / b;
            }
        }
    }
}
