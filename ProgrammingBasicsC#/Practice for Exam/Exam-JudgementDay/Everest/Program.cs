using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int progress = 5364;
            int goal = 8848;
            int daysCounter = 1;

            for (int i = 0; ; i++)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                int climbedMeters = int.Parse(Console.ReadLine());
                if (input == "Yes")
                {
                    daysCounter++;
                }
                if (daysCounter > 5)
                {
                    break;
                }
                progress += climbedMeters;
                if (progress >= goal)
                {
                    break;
                }
            }

            if (progress >= goal)
            {
                Console.WriteLine($"Goal reached for {daysCounter} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(progress);
            }


        }
    }
}
