using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeSalad
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>()
            {
                {"tomato",80 },
                {"carrot",136 },
                {"lettuce",109 },
                {"potato",215 }
            };

            string[] vegetablesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[] caloriesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<string> vegetables = new Queue<string>(vegetablesInput);
            Stack<int> calories = new Stack<int>(caloriesInput);
            Queue<int> madeSalads = new Queue<int>();

            int currentSalad = 0;
            if (calories.Count > 0)
            {
                currentSalad = calories.Peek();
            }

            while (vegetables.Count > 0 && calories.Count > 0)
            {
                int vegetableCalories = 0;
                if (products.ContainsKey(vegetables.Peek()))
                {
                    vegetableCalories = products[vegetables.Dequeue()];
                }
                else
                {
                    vegetables.Dequeue();
                }

                currentSalad -= (vegetableCalories);
                if (currentSalad <= 0)
                {
                    madeSalads.Enqueue(calories.Pop());
                    if (calories.Count > 0)
                    {
                        currentSalad = calories.Peek();
                    }
                }
            }

            if (calories.Count > 0 && currentSalad <= calories.Peek() / 2)
            {
                madeSalads.Enqueue(calories.Pop());
            }


            Console.WriteLine(string.Join(" ", madeSalads));
            if (vegetables.Count > 0)
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
            else if (calories.Count > 0)
            {
                Console.WriteLine(string.Join(" ", calories));
            }
        }
    }
}
