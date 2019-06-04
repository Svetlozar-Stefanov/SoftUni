namespace FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Filter
    {
        public static void Main(string[] args)
        {
            int linesOfCommands = int.Parse(Console.ReadLine());

            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < linesOfCommands; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries);
                KeyValuePair<string, int> info = new KeyValuePair<string, int>(input[0],int.Parse(input[1]));
                people.Add(info);
            }

            string criteria = Console.ReadLine();
            int criteriaAge = int.Parse(Console.ReadLine());
            string[] orderByCriteria = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var kvp in people)
            {
                if (Pass(kvp.Value,criteria,criteriaAge))
                {
                    Print(kvp, orderByCriteria);
                }
            }
        }

        private static void Print(KeyValuePair<string, int> kvp, string[] orderByCriteria)
        {
            if (orderByCriteria.Contains("name") && orderByCriteria.Contains("age"))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
            else if (orderByCriteria.Contains("name"))
            {
                Console.WriteLine(kvp.Key);
            }
            else if (orderByCriteria.Contains("age"))
            {
                Console.WriteLine(kvp.Value);
            }
        }

        private static bool Pass(int value, string criteria, int criteriaAge)
        {
            if (criteria == "older")
            {
                return value >= criteriaAge;
            }
            else if (criteria == "younger")
            {
                return value <= criteriaAge;
            }
            return false;
        }
    }
}
