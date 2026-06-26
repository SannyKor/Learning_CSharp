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
        public Person? ParentMom { get; internal set; }   
        public Person? ParentDad { get; internal set; }
        public Person(string? name, DateTime birthday, Gender gender)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Gender = gender;
            this.Children = new List<Person>();
        }
        public Person (Person Mom, Person Dad, string? name, DateTime birthday, Gender gender) : this(name, birthday, gender)
        {
            ParentMom = Mom;
            ParentMom.Children.Add(this);
            ParentDad = Dad;
            ParentDad.Children.Add(this);
        }
        public Person(Person parent, string? name, DateTime birthday, Gender gender) : this (name, birthday, gender)
        {
            if (parent.Gender == Gender.Male)
            {
                ParentDad = parent;
                ParentDad.Children.Add(this);
            }
            else
            {
                ParentMom = parent;
                ParentMom.Children.Add(this);
            }
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
                $"\n\tfather: {ParentDad?.Name}\n\tmother: {ParentMom?.Name}";
        }
    }
}
