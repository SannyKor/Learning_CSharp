using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AccessLevelAttribute : Attribute
    {
        public AccessLevel Level { get; }

        public AccessLevelAttribute(AccessLevel level)
        {
            Level = level;
        }
    }
}
