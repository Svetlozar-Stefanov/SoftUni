using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasNewList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Child> kids = new List<Child>();
            List<Toys> toys = new List<Toys>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split("->");

                if (tokens[0] == "Remove")
                {
                    for (int i = 0; i < kids.Count; i++)
                    {
                        if (kids[i].Name == tokens[1])
                        {
                            kids.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    string kidName = tokens[0];
                    string toyType = tokens[1];
                    int points = int.Parse(tokens[2]);

                    Child newKid = new Child(kidName, points);
                    Toys newToy = new Toys(toyType, points);


                    bool kidExists = false;
                    foreach (var kid in kids)
                    {
                        if (kid.Name == newKid.Name)
                        {
                            kid.Points += newKid.Points;
                            kidExists = true;
                        }
                    }
                    if (!kidExists)
                    {
                        kids.Add(newKid);
                    }

                    bool toyExists = false;
                    foreach (var toy in toys)
                    {
                        if (toy.ToyName == newToy.ToyName)
                        {
                            toy.ToyCount += newToy.ToyCount;
                            toyExists = true;
                        }
                    }
                    if (!toyExists)
                    {
                        toys.Add(newToy);
                    }
                }

                command = Console.ReadLine();
            }

            kids = kids.OrderByDescending(x => x.Points).ThenBy(x => x.Name).ToList();
            if (kids.Count > 0)
            {
                Console.WriteLine("Children:");
                foreach (var kid in kids)
                {
                    Console.WriteLine($"{kid.Name} -> {kid.Points}");
                }
            }

            if (toys.Count > 0)
            {
                Console.WriteLine("Presents:");
                foreach (var toy in toys)
                {
                    Console.WriteLine($"{toy.ToyName} -> {toy.ToyCount}");
                }
            }
        }
    }

    class Child
    {
        public Child(string name, int points)
        {
            Name = name;
            Points += points;
        }
        public string Name;
        public int Points = 0;
    }

    class Toys
    {
        public Toys(string name, int points)
        {
            ToyName = name;
            ToyCount += points;
        }
        public string ToyName;
        public int ToyCount = 0;
    }
}
