using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_XML_Serialization_
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Ім'я: {Name}, Вік: {Age}, Зарплата: {Salary}";
        }
    }
}
