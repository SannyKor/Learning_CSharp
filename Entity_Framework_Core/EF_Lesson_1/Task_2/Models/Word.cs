using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Models
{
    public class Word
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Header { get; set; } = string.Empty;
        public string KeyWord { get; set; } = string.Empty;

        public List<KeyParams> ProductLink { get; set; } = new List<KeyParams>();
    }
}
