using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Готуємо каву");
        }

        protected override void AddIngredients()
        {
            Console.WriteLine("Додаємо молоко та цукор");
        }
    }
}
