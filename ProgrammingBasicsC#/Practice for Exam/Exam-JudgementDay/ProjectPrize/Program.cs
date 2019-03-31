using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectParts = int.Parse(Console.ReadLine());
            double prizePerPoint = double.Parse(Console.ReadLine());
            double totalPoints = 0;

            for (int i = 1; i <= projectParts; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    totalPoints = totalPoints + (points * 2);
                }
                else
                {
                    totalPoints += points;
                }
            }
            double finalPrize = totalPoints * prizePerPoint;

            Console.WriteLine($"The project prize was {finalPrize:f2} lv.");

        }
    }
}
