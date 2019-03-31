using System;

namespace CookingMasterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            int freeBagsFlour = numberOfStudents / 5;
            double neededFlour = (numberOfStudents - freeBagsFlour) * priceFlour;
            double neededEggs = (priceEggs * 10) * numberOfStudents;
            double neededAprons = (priceApron * numberOfStudents) * 0.8;

            double finalCost = neededFlour + neededEggs + Math.Ceiling(neededAprons);

            if (finalCost <= budget)
            {
                Console.WriteLine($"Items purchased for {finalCost:f2}$.");
            }
            else
            {
                Console.WriteLine($"{finalCost-budget:f2}$ more needed.");
            }
        }
    }
}
