using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class CelsiusToFahrenheitConverter : TemperatureConverter
    {
        public CelsiusToFahrenheitConverter() { }

        public CelsiusToFahrenheitConverter(string name, double baseTemperature)
            : base(name, baseTemperature, TemperatureUnit.Fahrenheit)
        {
        }

        public override double Convert()
        {
            double result = (baseTemperature * 1.8) + 32;
            Console.WriteLine("CELSIUS TO FAHRENHEIT: Конвертацію виконано успішно.");
            return result;
        }
    }
}
