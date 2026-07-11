using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourIntoCup();
            AddIngredients();
            Console.WriteLine("----------------------");
        }

        private void BoilWater()
        {
            Console.WriteLine("Кип'ятимо воду");
        }

        private void PourIntoCup()
        {
            Console.WriteLine("Наливаємо у чашку");
        }
        protected abstract void Brew();
        protected abstract void AddIngredients();
        
    }
}
