using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Task_2_XML_Serialization_
{
    public class EmployeeXmlAttribute
    {
        [XmlAttribute("EmployeeName")]
        public string Name { get; set; } = string.Empty;

        [XmlAttribute("EmployeeAge")]
        public int Age { get; set; }

        [XmlAttribute("EmployeeSalary")]
        public double Salary { get; set; }

        public EmployeeXmlAttribute() { }

        public EmployeeXmlAttribute(string name, int age, double salary)
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
