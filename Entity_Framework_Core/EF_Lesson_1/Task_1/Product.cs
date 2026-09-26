using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Task_1
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double cost, string description, int quantity)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            Description = description;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name,-12} | Cost: {Cost,7:C} | Qty: {Quantity,3} | Desc: {Description}";
        }
    }
}
