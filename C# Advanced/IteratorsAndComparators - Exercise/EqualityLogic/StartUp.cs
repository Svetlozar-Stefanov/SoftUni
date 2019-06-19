using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashedSet = new HashSet<Person>();

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(info[0], int.Parse(info[1]));
                sortedSet.Add(person);
                hashedSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashedSet.Count);
        }
    }
}
