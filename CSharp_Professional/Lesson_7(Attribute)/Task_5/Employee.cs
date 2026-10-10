using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public abstract class Employee
    {
        public string Name { get; }

        protected Employee(string name)
        {
            Name = name;
        }
    }
}
