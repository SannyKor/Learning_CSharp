using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public enum Gender
    {
        Male = 0,
        Female = 1
    }
    public class Person
    {
        public DateTime Birthday { get;  }
        public string? Name { get; }
        public Gender Gender {
            get; }
        List <Person> Children { get; }
        Person? parentMom = null;
        public Person? ParentMom { get { return parentMom; } }   
        Person ? parentDad = null;
        public Person? ParentDad { get { return parentDad; } }
        public Person (Person Mom, Person Dad, string? name, DateTime birthday, Gender gender)
        {
            this.parentMom = Mom;
            this.parentDad = Dad;
            this.Name = name;
            this.Birthday = birthday;
            this.Gender = gender;
            this.Children = new List<Person>();
        }
        public Person(Person parent, string? name, DateTime birthday, Gender gender)
        {
            if (parent.Gender == Gender.Male)
            {
                parentDad = parent;
            }
            else
            {
                parentMom = parent;
            }
            this.Name = name;
            this.Birthday = birthday;
            this.Gender = gender;
            this.Children = new List<Person>();
        }
        public Person (string? name, DateTime birthday, Gender gender)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Gender = gender;
            this.Children = new List<Person>();
        }
        public Person? this[string name]
        {
            get
            {
                foreach (var child in Children)
                {
                    if (child.Name == name)
                    {
                        return child;
                    }
                }
                Console.WriteLine("Child not found.");
                return null;
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}, Birthday: {Birthday.ToShortDateString()}, Gender: {Gender}";
        }
    }
}
