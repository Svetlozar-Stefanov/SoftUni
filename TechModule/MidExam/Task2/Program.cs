using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fireCell = Console.ReadLine().Split("#", StringSplitOptions.RemoveEmptyEntries);

            int waterSupply = int.Parse(Console.ReadLine());

            double effort = 0;
            double totalFire = 0;
            List<int> putOutCells = new List<int>();

            for (int i = 0; i < fireCell.Length; i++)
            {
                string[] currentCell = fireCell[i].Split(" = ", StringSplitOptions.RemoveEmptyEntries);
                string currentFireLevel = currentCell[0];
                int value = int.Parse(currentCell[1]);

                if (waterSupply >= value)
                {
                    if (currentFireLevel.ToLower() == "low" && value >= 1 && value <= 50)
                    {
                        waterSupply -= value;
                        effort += value * 0.25;
                        totalFire += value;
                        putOutCells.Add(value);
                    }
                    else if (currentFireLevel.ToLower() == "medium" && value >= 51 && value <= 80)
                    {
                        waterSupply -= value;
                        effort += value * 0.25;
                        totalFire += value;
                        putOutCells.Add(value);
                    }
                    else if (currentFireLevel.ToLower() == "high" && value >= 81 && value <= 125)
                    {
                        waterSupply -= value;
                        effort += value * 0.25;
                        totalFire += value;
                        putOutCells.Add(value);
                    }
                }
            }



            Console.WriteLine("Cells:");
            foreach (var cell in putOutCells)
            {
                Console.WriteLine($"- {cell}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
