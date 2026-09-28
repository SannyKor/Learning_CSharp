using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Models
{
    public class KeyParams
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public Guid WordId { get; set; }
        public Word Keywords { get; set; } = null!;
    }
}
