using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int maxCappacity = int.Parse(Console.ReadLine());

            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Stack<string> stack = new Stack<string>(input);

            Queue<KeyValuePair<string, List<int>>> halls = new Queue<KeyValuePair<string, List<int>>>();
            while (stack.Count > 0)
            {
                string current = stack.Peek();

                if (int.TryParse(current, out int people))
                {
                    if (halls.Count > 0 && halls.Peek().Value.Sum() + people <= maxCappacity)
                    {
                        halls.Peek().Value.Add(int.Parse(stack.Pop()));
                    }
                    else if (halls.Count > 0 && halls.Peek().Value.Sum() + people > maxCappacity)
                    {
                        var hall = halls.Dequeue();
                        Console.WriteLine($"{hall.Key} -> {string.Join(", ",hall.Value)}");
                    }
                    else if (halls.Count <= 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    halls.Enqueue(new KeyValuePair<string, List<int>>(stack.Pop(), new List<int>()));
                }
            }
        }
    }
}
