using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    internal class Elf : ICreature
    {
        public string CreatureType { get; }
        public string Name { get; }
        public Elf (string creatureType, string name)
        {  CreatureType = creatureType; Name = name;}
    }
}
