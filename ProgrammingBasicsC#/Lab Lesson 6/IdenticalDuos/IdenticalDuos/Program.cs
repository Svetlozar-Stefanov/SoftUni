using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdenticalDuos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double lastSum = 0;
            double diff = 0;
            double biggestDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    lastSum = num1 + num2;
                }
                else
                {
                    sum = num1 + num2;
                    diff = Math.Abs(lastSum - sum);
                    if (diff > biggestDiff)
                    {
                        biggestDiff = diff;
                    }
                    lastSum = sum;
                }

                
            }
            if (biggestDiff == 0)
            {
                Console.WriteLine($"Yes, value={lastSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff= {biggestDiff}");
            }
            
        }
    }
}
