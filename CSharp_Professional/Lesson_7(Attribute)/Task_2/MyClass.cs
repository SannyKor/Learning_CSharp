using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class MyClass
    {
        [Obsolete("Цей метод застарів. Використовуйте новий метод NewMethod замість нього.")]
        public void MethodOld()
        {
            Console.WriteLine("Замовлення оброблено старим методом.");
        }


        [Obsolete("Цей метод більше не підтримується і викликає помилку компіляції! Використовуйте NewMethod.", true)]
        public void MethodDeprecated()
        {
            Console.WriteLine("Цей код ніколи не виконається через помилку компіляції.");
        }



        public void NewMethod()
        {
            Console.WriteLine("Замовлення успішно оброблено сучасним методом NewMethod.");
        }
    }
}
