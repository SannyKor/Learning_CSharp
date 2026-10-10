using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public abstract class TemperatureConverter
    {
        protected double baseTemperature;
        protected string converterName;
        protected TemperatureUnit targetUnit;

        protected TemperatureConverter()
        {
            // Стандартне налаштування цільової одиниці
            targetUnit = TemperatureUnit.Celsius;
        }

        protected TemperatureConverter(string converterName, double baseTemperature, TemperatureUnit targetUnit)
            : this()
        {
            this.converterName = converterName;
            this.baseTemperature = baseTemperature;
            this.targetUnit = targetUnit;
        }

        // Абстрактний метод для виконання конвертації (аналог Acceleration)
        public abstract double Convert();

        // Метод для виведення інформації (аналог Driver)
        public void ShowConverterInfo(string operatorName)
        {
            Console.WriteLine("Оператор: {0}. Конвертер: {1}", operatorName, converterName);
        }

        #region Властивості

        public string ConverterName
        {
            get { return converterName; }
            set { converterName = value; }
        }

        public double BaseTemperature
        {
            get { return baseTemperature; }
            set { baseTemperature = value; }
        }

        public TemperatureUnit TargetUnit
        {
            get { return targetUnit; }
        }

        #endregion
    }
}
