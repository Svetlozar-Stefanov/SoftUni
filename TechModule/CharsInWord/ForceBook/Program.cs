using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input.ToLower() != "lumpawaroo")
            {
                string[] info;
                try
                {
                    info = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = info[0];
                    string forceUser = info[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook[forceSide] = new List<string>();
                    }
                    if (!forceBook.Values.Any(x => x.Contains(forceUser)))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    info = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = info[0];
                    string forceSide = info[1];
                    foreach (var side in forceBook)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            side.Value.Remove(forceUser);
                            break;
                        }
                    }
                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook[forceSide] = new List<string>();
                    }
                    if (!forceBook.Values.Any(x => x.Contains(forceUser)))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                }
                catch (Exception)
                {
                }

                input = Console.ReadLine();
            }

            forceBook = forceBook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var side in forceBook)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    side.Value.Sort();
                    foreach (var person in side.Value)
                    {
                        Console.WriteLine($"! {person}");
                    }
                }
            }
        }
    }
}
