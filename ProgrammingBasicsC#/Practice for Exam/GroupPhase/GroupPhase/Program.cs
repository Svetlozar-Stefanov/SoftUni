using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPhase
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int totalMatches = int.Parse(Console.ReadLine());
            int points = 0;
            int totalDifferance = 0;

            for (int i = 0; i < totalMatches; i++)
            {
                int difference = 0;

                int goals = int.Parse(Console.ReadLine());
                int loses = int.Parse(Console.ReadLine());

                difference = goals - loses;

                if (difference > 0)
                {
                    points += 3;
                }
                if (difference == 0)
                {
                    points++;
                }

                totalDifferance += difference;
            }

            if (totalDifferance >= 0)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {totalDifferance}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalDifferance}.");
            }
        }
    }
}
