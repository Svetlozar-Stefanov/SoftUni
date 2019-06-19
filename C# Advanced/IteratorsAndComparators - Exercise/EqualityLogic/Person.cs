using System;
using System.Collections.Generic;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            if (Name != other.Name)
            {
                return Name.CompareTo(other.Name);
            }
            if (Age != other.Age)
            {
                return Age.CompareTo(other.Age);
            }
            return 0;
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (Name == other.Name)
            {
                return true;
            }
            if (Age == other.Age)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() * 17 + Age.GetHashCode();
        }
    }
}
