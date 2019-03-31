using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestPlayerName = "";
            int bestPlayerGoals = int.MinValue;

            string input = Console.ReadLine();
            while(input != "END")
            {
                string player = input;
                int goals = int.Parse(Console.ReadLine());

                if (goals > bestPlayerGoals)
                {
                    bestPlayerGoals = goals;
                    bestPlayerName = player;
                }
                if (goals >= 10)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayerName} is the best player!");
            if (bestPlayerGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals.");
            }
        }
    }
}
