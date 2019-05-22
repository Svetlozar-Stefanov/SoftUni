namespace CitiesByContinetAndCountry
{
    using System;
    using System.Collections.Generic;

    public class Cities
    {
        public static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> regions = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string region = input[0];
                string country = input[1];
                string city = input[2];

                if (!regions.ContainsKey(region))
                {
                    regions[region] = new Dictionary<string, List<string>>();
                }
                if (!regions[region].ContainsKey(country))
                {
                    regions[region][country] = new List<string>();
                }
                regions[region][country].Add(city);
            }

            foreach (var pair in regions)
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (var country in pair.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ",country.Value)}");
                }
            }
        }
    }
}
