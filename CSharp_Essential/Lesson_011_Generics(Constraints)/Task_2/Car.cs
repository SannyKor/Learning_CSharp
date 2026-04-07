using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Car
    {
        private int year;
        private string model;
        public int Year { get { return year; } }
        public string Model { get { return model; } }
        public Car(int year, string model)
        {
            this.year = year;
            this.model = model;
        }
        public override string ToString()
        {
            return $"Рік випуску: {year}, Модель: {model}";
        }
    }
}
