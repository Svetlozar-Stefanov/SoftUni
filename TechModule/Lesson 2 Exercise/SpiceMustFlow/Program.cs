using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong startingYield = ulong.Parse(Console.ReadLine());
            int daysCounter = 0;
            ulong extractedSum = 0;
            if (startingYield >= 100)
            {
                while (startingYield >= 100)
                {
                    extractedSum += (startingYield - 26);
                    daysCounter++;
                    startingYield -= 10;
                }
                Console.WriteLine(daysCounter);
                Console.WriteLine(extractedSum - 26);
            }
            else
            {
                Console.WriteLine(daysCounter);
                Console.WriteLine(extractedSum);
            }
        }
    }
}
