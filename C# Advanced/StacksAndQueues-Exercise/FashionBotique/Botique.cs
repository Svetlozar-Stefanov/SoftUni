using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBotique
{
    class Botique
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothes = new Stack<int>(input);

            int initialCapacity = int.Parse(Console.ReadLine());
            int rack = initialCapacity;
            double numberOfRacks = 1;
            if (clothes.Sum() == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (clothes.Count > 0)
            {
                int cloth = clothes.Pop();
                if (cloth < rack)
                {
                    rack -= cloth;
                }
                else if (cloth == rack && clothes.Count > 0)
                {
                    rack = initialCapacity;
                    numberOfRacks++;
                }
                else if (cloth > rack)
                {
                    rack = initialCapacity - cloth;
                    numberOfRacks++;
                }
            }
            

            Console.WriteLine(numberOfRacks);
        }
    }
}
