using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class BottlesAndCups
    {
        static void Main(string[] args)
        {
            int[] initialCups = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> cups = new Queue<int>(initialCups);

            int[] initialBottles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> bottles = new Stack<int>(initialBottles);

            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Peek();

                if (currentBottle >= currentCup)
                {
                    bottles.Pop();
                    cups.Dequeue();
                    wastedWater += currentBottle - currentCup;
                }
                else if (currentCup > currentBottle)
                {
                    while (currentCup > 0)
                    {
                        currentCup -= bottles.Pop();
                    }
                    cups.Dequeue();
                    wastedWater += Math.Abs(currentCup);
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {String.Join(" ",bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
