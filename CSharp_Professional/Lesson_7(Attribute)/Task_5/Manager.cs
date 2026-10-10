using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    [AccessLevel(AccessLevel.Manager)]
    public class Manager : Employee
    {
        public Manager(string name) : base(name) {}
    }
}
