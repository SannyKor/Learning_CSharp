using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Models
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Відкриваю документ TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Створюю документ TXT");
        }
        public override void Chenge()
        {
            Console.WriteLine("Корегую документ TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Зберігаю документ TXT");
        }
    }
}
