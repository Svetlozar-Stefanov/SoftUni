using System;
using System.Collections.Generic;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int numberOfFamilyMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfFamilyMembers; i++)
            {
                string[] input = Console.ReadLine().Split();
                family.AddMember(new Person(input[0], int.Parse(input[1])));
            }
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {

        }
        public string Name;
        public int Age;
    }

    class Family
    {
        public Family()
        {
            ListPerson = new List<Person>();
        }
        public List<Person> ListPerson;

        public void AddMember(Person person)
        {
            ListPerson.Add(person);
        }

        internal Person GetOldestMember()
        {
            int highestAge = int.MinValue;
            Person oldestMember = new Person();

            foreach (var person in ListPerson)
            {
                if (person.Age > highestAge)
                {
                    highestAge = person.Age;
                    oldestMember = person;
                }
            }
            return oldestMember;
        }
    }
}
