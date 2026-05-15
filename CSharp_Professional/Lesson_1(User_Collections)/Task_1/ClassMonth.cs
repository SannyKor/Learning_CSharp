using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public enum WeatherSeason
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public class ClassMonth
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Days { get; set; }

        public WeatherSeason Season { get; set; }
        public ClassMonth(string name, int number, int days, WeatherSeason season) { 
            Name = name;
            Number = number;
            Days = days;
            Season = season;
        }
        public override string ToString()
        {
            return $"Month: {Name}, Number: {Number}, Days: {Days}, Season: {Season}";
        }
    }
}
