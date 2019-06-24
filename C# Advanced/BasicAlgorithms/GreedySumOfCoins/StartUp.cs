using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedySumOfCoins
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] {' ',',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            input.RemoveAt(0);

            List<int> coins = input
                .Select(int.Parse)
                .OrderByDescending(C => C)
                .ToList();

            int target = int.Parse(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).LastOrDefault());
            int count = 0;
            Dictionary<int, int> neededCoins = new Dictionary<int, int>();

            int index = 0;
            int sum = 0;
            while (index != coins.Count)
            {
                if (sum == target)
                {
                    break;
                }
                if (sum + coins[index] <= target)
                {
                    sum += coins[index];
                    if (!neededCoins.ContainsKey(coins[index]))
                    {
                        neededCoins[coins[index]] = 0;
                    }
                    neededCoins[coins[index]]++;
                    count++;
                }
                else if (sum + coins[index] > target)
                {
                    index++;
                }
            }

            if (index >= coins.Count)
            {
                Console.WriteLine("Error");
            }
            if (sum == target)
            {
                Console.WriteLine($"Number of coins to take: {count}");
                foreach (var (key,value) in neededCoins)
                {
                    Console.WriteLine($"{value} coin(s) with value {key}");
                }
            }
        }
    }
}
