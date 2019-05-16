using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class FoodQuantity
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] oredersQuantity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(oredersQuantity);
            int biggestOrder = orders.Max();
            Console.WriteLine(biggestOrder);

            while (orders.Count > 0)
            {
                if (foodQuantity >= orders.Peek())
                {
                    foodQuantity -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(" ",orders)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
