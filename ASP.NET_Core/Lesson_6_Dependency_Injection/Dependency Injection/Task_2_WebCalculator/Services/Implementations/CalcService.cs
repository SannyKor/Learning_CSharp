using Task_2_WebCalculator.Services.Interfaces;
namespace Task_2_WebCalculator.Services.Implementations
{
    public class CalcService : ICalcService
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ділення на нуль неможливе.");
            }

            return a / b;
        }
    }
}
