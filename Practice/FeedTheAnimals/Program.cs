using System;
using System.Collections.Generic;
using System.Linq;

namespace FeedTheAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            Dictionary<string, List<string>> areas = new Dictionary<string, List<string>>();

            string[] command = Console.ReadLine().Split(":");

            while (command[0] != "Last Info")
            {
                if (command[0] == "Add")
                {
                    string name = command[1];
                    int foodLimit = int.Parse(command[2]);
                    string area = command[3];

                    if (!animals.ContainsKey(name))
                    {
                        animals.Add(name, 0);
                    }
                    animals[name] += foodLimit;

                    if (!areas.ContainsKey(area))
                    {
                        areas.Add(area, new List<string>());
                    }
                    if (!areas[area].Contains(name))
                    {
                        areas[area].Add(name);
                    }
                }

                if (command[0] == "Feed")
                {
                    string name = command[1];
                    int food = int.Parse(command[2]);
                    string area = command[3];

                    if (animals.ContainsKey(name))
                    {
                        animals[name] -= food;

                        if (animals[name] <= 0)
                        {
                            Console.WriteLine($"{name} was successfully fed");
                            animals.Remove(name);
                            areas[area].Remove(name);
                        }
                    }
                }

                command = Console.ReadLine().Split(":");
            }

            Console.WriteLine("Animals:");
            foreach (var animal in animals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            Console.WriteLine($"Areas with hungry animals:");
            foreach (var area in areas.OrderByDescending(x => x.Value.Count))
            {
                if (area.Value.Count > 0)
                {
                    Console.WriteLine($"{area.Key} : {area.Value.Count}");
                }
            }
        }
    }
}
