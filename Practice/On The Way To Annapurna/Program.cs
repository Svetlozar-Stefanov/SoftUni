using System;
using System.Collections.Generic;
using System.Linq;

namespace On_The_Way_To_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> diary = new Dictionary<string, List<string>>();

            string[] command = Console.ReadLine().Split("->");
            while (command[0] != "END")
            {
                if (command[0] == "Add")
                {
                    string store = command[1];
                    string[] items = command[2].Split(",");
                    if (!diary.ContainsKey(store))
                    {
                        diary.Add(store, new List<string>());
                    }
                    foreach (var item in items)
                    {
                        diary[store].Add(item);
                    }
                }
                if (command[0] == "Remove")
                {
                    string store = command[1];
                    if (diary.ContainsKey(store))
                    {
                        diary.Remove(store);
                    }
                }
                command = Console.ReadLine().Split("->");
            }

            Console.WriteLine("Stores list:");
            foreach (var store in diary.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
            {
                Console.WriteLine(store.Key);
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
