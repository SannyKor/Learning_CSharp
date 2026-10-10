using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_2
{
    public class Product
    {
        public Guid ProductId { get; private set; }
        public int ProductAlterId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public Product()
        {
        }

        public Product(string name, decimal cost, string description, int quantity)
        {
            ProductId = Guid.NewGuid();
            Name = name;
            Cost = cost;
            Description = description;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"ID: {ProductId} | Name: {Name,-12} | Cost: {Cost,7:C} | Qty: {Quantity,3} | Desc: {Description}";
        }
    }
}