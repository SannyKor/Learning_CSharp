using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    public class CalculatorModel
    {
        public double Calculate(double value1, double value2, string operation)
        {
            return operation switch
            {
                "+" => value1 + value2,
                "-" => value1 - value2,
                "*" => value1 * value2,
                "/" => value2 != 0 ? value1 / value2 : throw new DivideByZeroException("Cannot divide by zero"),
                _ => throw new InvalidOperationException("Invalid operation")
            };
        }
    }
}
