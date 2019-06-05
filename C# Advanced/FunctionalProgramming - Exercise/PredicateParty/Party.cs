namespace PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Party
    {
        public static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Party!")
            {
                string action = input[0].ToLower();
                string criteria = input[1].ToLower();
                string value = input[2];

                if (action == "double")
                {
                    DoublePeople(people, criteria, value, CriteriaPass);
                }
                else if (action == "remove")
                {
                    RemovePerson(people, criteria, value, CriteriaPass);
                }

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (people.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ",people)} are going to the party!");
            }
            else
            {
                Console.WriteLine($"Nobody is going to the party!");
            }
        }

        private static void RemovePerson(List<string> people, string criteria, string value, Func<string, string, string, bool> criteriaPass)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (criteriaPass(people[i], criteria, value))
                {
                    people.Remove(people[i]);
                    i--;
                }
            }
        }

        private static void DoublePeople(List<string> people, string criteria, string value, Func<string, string, string, bool> criteriaPass)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (criteriaPass(people[i], criteria, value))
                {
                    people.Insert(people.IndexOf(people[i]) + 1, people[i]);
                    i++;
                }
            }
        }

        public static Func<string, string, string, bool> CriteriaPass = (value, criteria, compareValue) =>
           {
               if (criteria == "startswith")
               {
                   return value.StartsWith(compareValue);
               }
               if (criteria == "endswith")
               {
                   return value.EndsWith(compareValue);
               }
               if (criteria == "length")
               {
                   return value.Length == int.Parse(compareValue);
               }
               return false;
           };
    }
}
