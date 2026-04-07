using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6
{
    public class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id = {Id}, Name: {Name}";
        }
    }
}
