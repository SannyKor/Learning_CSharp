using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Task_2
{
    public class Buyer
    {
        public string Name { get; set; }  
        private List<Item> items;
        public IEnumerable<Item> Items => items;
        public Buyer(string name)
        {
            Name = name;
            items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public Item this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return items[index];
            }
        }
    }
}
