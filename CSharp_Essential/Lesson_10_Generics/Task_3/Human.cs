using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Human : ICreature
    {
        public string CreatureType {  get; }
        public string Name { get; }  
        public Human(string creatureType, string name)
        {
            CreatureType = creatureType;
            Name = name;
        }
    }
}
