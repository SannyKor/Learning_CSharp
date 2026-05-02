using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    internal class Dwarf : ICreature
    {
        public string CreatureType { get; }
        public string Name { get; }
        public Dwarf(string creatureType, string name)
        {  CreatureType = creatureType; Name = name;}
    }
}
