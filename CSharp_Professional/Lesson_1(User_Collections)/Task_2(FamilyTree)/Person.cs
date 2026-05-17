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
        public List <Person> Children { get; } = new List <Person> ();
        Person? parentMom = null;
        public Person? ParentMom { get { return parentMom; } }   
        Person ? parentDad = null;
        public Person? ParentDad { get { return parentDad; } }
        public Person (Person Mom, Person Dad, string? name, DateTime birthday, Gender gender)
        {
            parentMom = Mom;
            parentMom.Children.Add(this);
            parentDad = Dad;
            parentDad.Children.Add(this);
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
                parentDad.Children.Add(this);
            }
            else
            {
                parentMom = parent;
                parentMom.Children.Add(this);
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
            return $"Name: {Name}, Birthday: {Birthday.ToShortDateString()}, Gender: {Gender}" +
                $"\n\t{ParentDad?.Name}\n\t{ParentMom?.Name}";
        }
    }
}
