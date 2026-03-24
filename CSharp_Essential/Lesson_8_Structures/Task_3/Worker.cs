using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Worker
    {
        Post post;
        
        public Worker (Post post)
        { this.post = post; }
        public void BonusCalculation (int workedHours)
        {
            Accountant accountant = new Accountant ();
            bool getBonus = accountant.AskForBonus(post, workedHours);
            Console.WriteLine($"Посада: {post}, норма годин на місяць: {(int)post}");
            Console.WriteLine($"Відпрацьовано годин: {workedHours}год.");
            Console.WriteLine($"Премія: {(getBonus ? "Нарахувати премію." : "Підстава для премії відсутня.")}");
        }
    }
}
