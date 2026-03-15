using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    internal class Article
    {
        public string Name { get; set; }
        public string StoreName { get; set; }
        decimal Price { get; set; }
        public Article(string name, string storeName, decimal price)
        {
            Name = name;
            StoreName = storeName;
            Price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"\tНазва товару: {Name}; \n\tМагазин: {StoreName}; \n\tЦіна: {Price}грн.");
        }
    }
}
