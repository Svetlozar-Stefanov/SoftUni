using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());

            double totalWater = days * (waterPerPerson * countPlayers);
            double totalFood = days * (foodPerPerson * countPlayers);

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;
                if (energy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    energy = energy + (energy * 0.05);
                    totalWater = totalWater - (totalWater * 0.3);
                }
                if (i % 3 == 0)
                {
                    totalFood -= totalFood / countPlayers;
                    energy = energy + (energy * 0.1);
                }
            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
        }
    }
}
