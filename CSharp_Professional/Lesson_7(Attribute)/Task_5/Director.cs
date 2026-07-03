using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    [AccessLevel(AccessLevel.Admin)]
    public class Director : Employee
    {
        public Director(string name) : base(name) {}
    }
}
