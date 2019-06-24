using System;
using System.Collections.Generic;
using System.Linq;

namespace UniverseSet
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
               .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
               .ToList();
            input.RemoveAt(0);

            List<int> universe = input
                .Select(int.Parse)
                .ToList();

            int setsCount = int.Parse(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).LastOrDefault());

            List<List<int>> sets = new List<List<int>>();

            for (int i = 0; i < setsCount; i++)
            {
                sets.Add(Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            sets = sets.OrderByDescending(s => s.Count(n => universe.Contains(n))).ToList();

            List<List<int>> usedSets = new List<List<int>>();
            for (int i = 0; i < sets.Count; i++)
            {
                List<int> currentSet = sets[i];
                for (int j = 0; j < currentSet.Count; j++)
                {
                    if (universe.Count == 0)
                    {
                        break;
                    }
                    if (universe.Contains(currentSet[j]))
                    {
                        universe.Remove(currentSet[j]);
                        if (!usedSets.Contains(currentSet))
                        {
                            usedSets.Add(currentSet);
                        }
                    }
                }
                if (universe.Count == 0)
                {
                    break;
                }
            }

            if (universe.Count == 0)
            {
                Console.WriteLine($"Sets to take ({usedSets.Count}):");
                foreach (var set in usedSets)
                {
                    Console.WriteLine($"{{ {string.Join(", ",set)} }}");
                }
            }
        }
    }
}
