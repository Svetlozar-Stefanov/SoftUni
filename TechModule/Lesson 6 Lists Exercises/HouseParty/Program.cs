using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] action = Console.ReadLine().Split().ToArray();

                if (action[2].ToLower() == "going!")
                {
                    if (guestList.Contains(action[0]))
                    {
                        Console.WriteLine($"{action[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(action[0]);
                    }
                }
                else if (action[2].ToLower() == "not")
                {
                    if (guestList.Contains(action[0]))
                    {
                        guestList.Remove(action[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{action[0]} is not in the list!");
                    }
                }
            }
            foreach (var name in guestList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
