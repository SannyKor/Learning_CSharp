using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Models
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Відкриваю документ XML");
        }
        public override void Create()
        {
            Console.WriteLine("Створюю документ XML");
        }
        public override void Chenge()
        {
            Console.WriteLine("Корегую документ XML");
        }
        public override void Save()
        {
            Console.WriteLine("Зберігаю документ XML");
        }
    }
}
