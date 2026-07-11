using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Заварюємо чай");
        }

        protected override void AddIngredients()
        {
            Console.WriteLine("Додаємо лимон");
        }
    }
}
