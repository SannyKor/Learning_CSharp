using System;
using System.Collections.Generic;
using System.Text;

namespace Generate_tests
{
    public class Employee
    {
        // Поля
        private int experience;          // стаж у роках
        private string position;         // посада
        private int workedHours;         // кількість відпрацьованих годин

        // Конструктор
        public Employee(int experience, string position, int workedHours)
        {
            this.experience = experience;
            this.position = position;
            this.workedHours = workedHours;
        }

        // Метод розрахунку зарплати
        public decimal CalculateSalary()
        {
            decimal hourlyRate = GetHourlyRate();

            // Базова зарплата
            decimal salary = hourlyRate * workedHours;

            // Надбавка за стаж
            if (experience >= 10)
            {
                salary *= 1.25m; // +25%
            }
            else if (experience >= 5)
            {
                salary *= 1.15m; // +15%
            }
            else if (experience >= 2)
            {
                salary *= 1.05m; // +5%
            }

            // Податок 18%
            decimal tax = salary * 0.18m;

            // Військовий збір 1.5%
            decimal militaryTax = salary * 0.015m;

            // Зарплата після відрахувань
            decimal finalSalary = salary - tax - militaryTax;

            return finalSalary;
        }

        // Метод визначення ставки за годину залежно від посади
        private decimal GetHourlyRate()
        {
            switch (position.ToLower())
            {
                case "manager":
                    return 500;

                case "developer":
                    return 700;

                case "designer":
                    return 450;

                default:
                    return 300;
            }
        }

        // Метод для виводу інформації
        public void ShowInfo()
        {
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Стаж: {experience} років");
            Console.WriteLine($"Відпрацьовано годин: {workedHours}");
            Console.WriteLine($"Зарплата після податків: {CalculateSalary()} грн");
        }
    }
}
