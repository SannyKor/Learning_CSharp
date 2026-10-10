using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class CelsiusToKelvinConverter : TemperatureConverter
    {
        public CelsiusToKelvinConverter() { }

        public CelsiusToKelvinConverter(string name, double baseTemperature)
            : base(name, baseTemperature, TemperatureUnit.Kelvin)
        {
        }

        public override double Convert()
        {
            double result = baseTemperature + 273.15;
            Console.WriteLine("CELSIUS TO KELVIN: Прискорене обчислення абсолютної температури!");
            return result;
        }
    }

    // Внутрішній клас (аналог SecretCar), який поки не реалізований
    internal class SecretAbsoluteZeroConverter : TemperatureConverter
    {
        public override double Convert()
        {
            throw new NotImplementedException("Секретний конвертер ще не налаштовано.");
        }
    }
}
