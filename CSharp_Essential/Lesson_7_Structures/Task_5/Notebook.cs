using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    struct Notebook
    {
        double price;
        string model;
        string producer;
        public Notebook (double price, string model, string producer)
        {
            this.price = price;
            this.model = model;
            this.producer = producer;
        }
        public void ShowNotebook()
        {
        Console.WriteLine($"Ціна: {price}; \nМодель: {model}; \nВиробник: {producer};");
        }
    }
}
