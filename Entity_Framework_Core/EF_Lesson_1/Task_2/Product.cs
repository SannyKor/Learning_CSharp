using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_2
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; private set; }
        public int ProductAlterId { get; set; }
        [Required(ErrorMessage = "Назва товару обов'язкова")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "Money")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Вартість товару повинна бути додатньою")]
        public decimal Cost { get; set; }
        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Кількість товару не може бути від'ємною")]
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