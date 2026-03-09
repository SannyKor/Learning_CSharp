using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5.Models
{
    abstract class AbstractHandler
    {
        protected string format;
        public void Open()
        {
            Console.WriteLine($"Відкриваю документ {format}");
        }
        public void Create()
        {
            Console.WriteLine($"Створюю документ {format}");
        }
        public void Chenge()
        {
            Console.WriteLine($"Корегую документ {format}");
        }
        public void Save()
        {
            Console.WriteLine($"Зберігаю документ {format}");
        }
    }
}
