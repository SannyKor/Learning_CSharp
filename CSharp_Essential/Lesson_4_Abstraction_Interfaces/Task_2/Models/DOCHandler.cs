using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Models
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Відкриваю документ DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Створюю документ DOC");
        }
        public override void Chenge()
        {
            Console.WriteLine("Корегую документ DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Зберігаю документ DOC");
        }
    }
}
