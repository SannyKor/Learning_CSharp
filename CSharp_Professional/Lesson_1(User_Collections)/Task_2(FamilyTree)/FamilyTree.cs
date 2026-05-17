using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Task_2;

namespace Task_2
{
    public class FamilyTree : ICollection<Person>
    {
        Person? RootMom { get; }
        Person? RootDad { get;  }
        private List<Person> familyMembers = new List<Person>();

        public int Count => familyMembers.Count;

        public bool IsReadOnly => false;
        public FamilyTree(Person rootMom, Person rootDad)
        {
            RootMom = rootMom;
            RootDad = rootDad;
            familyMembers.Add(rootMom);
            familyMembers.Add(rootDad);
        }
        public FamilyTree(Person rootMember)
        {
            if (rootMember.Gender == Gender.Male)
            {
                RootDad = rootMember;
                familyMembers.Add(rootMember);
            }
            else
            {
                RootMom = rootMember;
                familyMembers.Add(rootMember);
            }
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
        bool IsDescendant(Person? descendant)
        {
            if (descendant == null) { 
                return false; }
            if (descendant.ParentMom != null)
            {
                if (familyMembers.Contains(descendant.ParentMom) || IsDescendant(descendant.ParentMom)) { 
                    return true; }
            }
            if (descendant.ParentDad != null)
            {
                if (familyMembers.Contains(descendant.ParentDad) || IsDescendant(descendant.ParentDad)) { 
                    return true; }
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
        public void ShowFamilyTree()
        {
            foreach (var member in familyMembers)
            {
                Console.WriteLine(member);
            }
        }
        public List<Person> AllDescendantsOf (Person person)
        {
            List<Person> descendants = new List<Person>();
            foreach (var member in person.Children)
            {
                    descendants.Add(member);
                    descendants.AddRange(AllDescendantsOf(member));
            }
            return descendants;
        }
            
    }
}