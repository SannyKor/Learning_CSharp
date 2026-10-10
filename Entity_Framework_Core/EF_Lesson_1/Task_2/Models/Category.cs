using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Models
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
