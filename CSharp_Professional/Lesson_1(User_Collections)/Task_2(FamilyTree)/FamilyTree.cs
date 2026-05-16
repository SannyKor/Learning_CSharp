using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Task_2;

namespace Task_2
{
    public class FamilyTree : ICollection<Person>
    {
        Person? RootMale { get; }
        Person? RootFemale { get;  }
        private List<Person> familyMembers = new List<Person>();

        public int Count => familyMembers.Count;

        public bool IsReadOnly => false;
        public FamilyTree(Person male, Person female)
        {
            RootMale = male;
            RootFemale = female;
            familyMembers.Add(RootMale);
            familyMembers.Add(RootFemale);
        }
        public void Add(Person descendant)
        {
            if (IsDescendant(descendant))
            { 
                familyMembers.Add(descendant);
            }
            else
            {
                Console.WriteLine("This person is not a descendant of the family tree.");
            }
        }
        bool IsDescendant(Person descendant)
        {
            if (familyMembers.Contains(descendant.ParentMom) || familyMembers.Contains(descendant.ParentDad))
            {
                return true;
            }
            else if (IsDescendant(descendant.ParentDad) || IsDescendant(descendant.ParentMom))
            {
                return true;
            }
            return false;
        }

        public void Clear()
        {
            familyMembers.Clear();
        }

        public bool Contains(Person item)
        {
            return familyMembers.Contains(item);
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            familyMembers.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return familyMembers.GetEnumerator();
        }

        public bool Remove(Person item)
        {
            return familyMembers.Remove(item);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return familyMembers.GetEnumerator();
        }
    }
}