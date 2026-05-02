using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public dynamic Subtract(dynamic a, dynamic b)
        {
            return a - b;
        }
        public dynamic Multiply(dynamic a, dynamic b)
        {
            return a * b;
        }
        public dynamic Divide(dynamic a, dynamic b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
        public void AllActions(dynamic a, dynamic b)
        {
            Console.WriteLine($"Add: {Add(a, b)}");
            Console.WriteLine($"Subtract: {Subtract(a, b)}");
            Console.WriteLine($"Multiply: {Multiply(a, b)}");
            Console.WriteLine($"Divide: {Divide(a, b)}");
        }

    }
}
