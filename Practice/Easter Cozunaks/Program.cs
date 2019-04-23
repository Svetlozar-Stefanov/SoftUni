using System;

namespace Easter_Cozunaks
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal flourPerKiloPrice = decimal.Parse(Console.ReadLine());

            decimal pricePackOfEggs = flourPerKiloPrice * 0.75m;
            decimal priceForLiterMilk = flourPerKiloPrice + (flourPerKiloPrice * 0.25m);
            decimal neededMilk = priceForLiterMilk / 4;

            decimal cozunakPrice = pricePackOfEggs + flourPerKiloPrice + neededMilk;
            int cozunakCount = 0;
            int eggsCount = 0;


            while (budget >= cozunakPrice)
            {
                budget -= cozunakPrice;

                cozunakCount++;
                eggsCount+=3;

                if (cozunakCount % 3 == 0) 
                {
                    eggsCount -= cozunakCount - 2;
                }
            }

            Console.WriteLine($"You made {cozunakCount} cozonacs! Now you have {eggsCount} eggs and {budget:f2}BGN left.");
        }
    }
}
