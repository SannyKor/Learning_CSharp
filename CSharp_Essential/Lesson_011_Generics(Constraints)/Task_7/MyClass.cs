using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Task_7
{
    public class MyClass<T> where T : new()
    {
        public static T TFactoryMethod() { return new T();}
    }
}
