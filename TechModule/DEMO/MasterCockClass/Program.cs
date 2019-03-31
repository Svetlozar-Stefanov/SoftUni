using System;

namespace MasterCockClass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            decimal priceFlour = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceApron = decimal.Parse(Console.ReadLine());

            int freeBagsFlour = numberOfStudents / 5;
            decimal neededFlour = (numberOfStudents - freeBagsFlour) * priceFlour;
            decimal neededEggs = (priceEggs * 10) * numberOfStudents;
            decimal neededAprons =(priceApron * Math.Ceiling(numberOfStudents + numberOfStudents * 0.2m));
            

            decimal finalCost = neededFlour + neededEggs + neededAprons;

            if (finalCost <= budget)
            {
                Console.WriteLine($"Items purchased for {finalCost:f2}$.");
            }
            else
            {
                Console.WriteLine($"{finalCost - budget:f2}$ more needed.");
            }
        }
    }
}
