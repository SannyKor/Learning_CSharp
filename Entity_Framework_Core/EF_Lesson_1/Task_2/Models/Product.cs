using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Task_2.Models;

namespace Task_2
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public decimal ActionCost { get; set; }
        public string Description { get; set; } = string.Empty;
        public string DescriptionField1 { get; set; } = string.Empty;
        public string DescriptionField2 { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<KeyParams> Keywords { get; set; } = new List<KeyParams>();
        public Product()
        {
        }

        public Product(string name, decimal cost, string description, int quantity)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name,-12} | Cost: {Cost,7:C} | Desc: {Description}";
        }
    }
}