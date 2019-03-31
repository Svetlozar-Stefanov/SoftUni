using System;
using System.Collections.Generic;
using System.Linq;

namespace CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('#');

            int bestQuality = int.MinValue;
            int bestAvgQuality = int.MinValue;
            int bestLength = int.MaxValue;
            List<int> bestBatch = new List<int>();

            while (input[0].ToLower() != "bake it!")
            {
                List<int> breadBatches = input.Select(int.Parse).ToList();

                int currentQuality = breadBatches.Sum();
                int currentAvgQuality = breadBatches.Sum() / breadBatches.Count;
                if (currentQuality > bestQuality)
                {
                    bestQuality = currentQuality;
                    bestAvgQuality = currentAvgQuality;
                    bestLength = breadBatches.Count;
                    bestBatch = breadBatches.ToList();
                }
                else if (currentQuality == bestQuality && currentAvgQuality > bestAvgQuality)
                {
                    bestQuality = currentQuality;
                    bestAvgQuality = currentAvgQuality;
                    bestLength = breadBatches.Count;
                    bestBatch = breadBatches.ToList();
                }
                else if (currentQuality == bestQuality && currentAvgQuality == bestAvgQuality && breadBatches.Count < bestLength)
                {
                    bestQuality = currentQuality;
                    bestAvgQuality = currentAvgQuality;
                    bestLength = breadBatches.Count;
                    bestBatch = breadBatches.ToList();
                }

                input = Console.ReadLine().Split('#');
            }

            if (bestBatch.Count>0)
            {
                Console.WriteLine($"Best Batch quality: {bestQuality}");
                Console.WriteLine(String.Join(" ", bestBatch));
            }
        }
    }
}
