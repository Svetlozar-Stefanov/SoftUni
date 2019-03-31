using System;

namespace SantasCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBatches = int.Parse(Console.ReadLine());
            int totalBoxes = 0;
            for (int i = 0; i < numberOfBatches ; i++)
            {
                int gramsFlour = int.Parse(Console.ReadLine());
                int gramsSugar = int.Parse(Console.ReadLine());
                int gramsCocoa = int.Parse(Console.ReadLine());

                int flourCups = gramsFlour / 140;
                int sugarSpoons = gramsSugar / 20;
                int cocoaSpoons = gramsCocoa / 10;

                if (flourCups > 0 && sugarSpoons > 0 && cocoaSpoons > 0)
                {
                    int totalCookiesPerBake = (140 + 10 + 20) * Math.Min(flourCups, Math.Min(sugarSpoons, cocoaSpoons)) / 25;
                    int currentBatchBoxes = totalCookiesPerBake / 5;
                    Console.WriteLine($"Boxes of cookies: {currentBatchBoxes}");
                    totalBoxes += currentBatchBoxes;
                }
                else
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
