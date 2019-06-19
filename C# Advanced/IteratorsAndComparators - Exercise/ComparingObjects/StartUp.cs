using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0].ToLower() != "end")
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];

                people.Add(new Person(name, age, town));

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            int personIndex = int.Parse(Console.ReadLine()) - 1;
            Person person = people[personIndex];
            people.RemoveAt(personIndex);

            int matches = 0;
            int notEqual = 0;

            foreach (var otherPerson in people)
            {
                int result = person.CompareTo(otherPerson);
                if (result != 0)
                {
                    notEqual++;
                    continue;
                }
                matches++;
            }

            if (matches == 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine($"{matches+1} {notEqual} {people.Count+1}");
        }
    }
}
