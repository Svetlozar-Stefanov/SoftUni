namespace PartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PartyFilter
    {
        public static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<KeyValuePair<string, string>> filters = new List<KeyValuePair<string, string>>();

            string[] input = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (input[0].ToLower() != "print")
            {
                string command = input[0].ToLower();
                string filter = input[1].ToLower();
                string value = input[2];

                if (command == "add filter")
                {
                    filters.Add(new KeyValuePair<string, string>(filter, value));
                }
                else if (command == "remove filter")
                {
                    filters.Remove(new KeyValuePair<string, string>(filter,value));
                }

                input = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            for (int i = 0; i < people.Count; i++)
            {
                string person = people[i];
                foreach (var filter in filters)
                {
                    if (IsPass(person,filter.Key,filter.Value))
                    {
                        people.Remove(person);
                        i--;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",people));
        }

        public static Func<string, string, string, bool> IsPass = (person, filter, value) =>
           {
               if (filter == "starts with")
               {
                   return person.StartsWith(value);
               }
               else if (filter == "ends with")
               {
                   return person.EndsWith(value);
               }
               else if (filter == "length")
               {
                   return person.Length == int.Parse(value);
               }
               else if (filter == "contains")
               {
                   return person.Contains(value);
               }
               return false;
           };
    }
}
