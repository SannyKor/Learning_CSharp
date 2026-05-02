using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class MagicBag<T> where T : ICreature
    {
        private Dictionary<string, DateTime> lastGifTime;
        private List<string> gifts;
        public MagicBag()
        {
            lastGifTime = new Dictionary<string, DateTime>();
            gifts = new List<string>();
            FillBag();
        }
        public string GetGift(T creature)
        {
            if (lastGifTime.ContainsKey(creature.Name))
            {
                var lastTime = lastGifTime[creature.Name];
                if ((DateTime.Now - lastTime).TotalDays < 1)
                {
                    return $"Шукач скарбів {creature.Name}, ти вже отримав чарівний подарунок. Треба зачекати до наступної винагороди.";
                }
            }
            string gift = GenerateGift(creature);
            if (!lastGifTime.ContainsKey(creature.Name))
                lastGifTime.Add(creature.Name, DateTime.Now);

            lastGifTime[creature.Name] = DateTime.Now;
            
            return $"{creature.CreatureType} {creature.Name} отримує {gift}"; ;
        }
        private string GenerateGift(T creature)
        {
            Random rand = new Random();
            return gifts[rand.Next(gifts.Count)];
        }
        private void FillBag ()
        {
            gifts.Add("Чарівна пличка");
            gifts.Add("Меч чаклуна");
            gifts.Add("Амулет Валькірії");
            gifts.Add("Кришталева куля");
            gifts.Add("Зілля невидимості");
            gifts.Add("Книга заклять");
            gifts.Add("Крила фенікса");
        }
    }
}
