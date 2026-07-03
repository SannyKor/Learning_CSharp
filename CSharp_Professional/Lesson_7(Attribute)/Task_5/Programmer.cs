using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    [AccessLevel(AccessLevel.User)]
    public class Programmer : Employee
    {
        public Programmer(string name) : base(name) {}
    }
}
