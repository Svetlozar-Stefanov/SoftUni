using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());

            double minutesSum = 0;
            int penalties = 0;
            int additionalTime = 0;

            for (int i = 1; i <= playedGames; i++)
            {
                int minutes = int.Parse(Console.ReadLine());
                if (minutes > 90 && minutes <= 120)
                {
                    additionalTime++;
                }
                else if (minutes > 120)
                {
                    penalties++;
                }
                minutesSum += minutes;
            }

            double avgTime = minutesSum / playedGames;

            Console.WriteLine($"{team} has played {minutesSum} minutes. Average minutes per game: {avgTime:f2}");
            Console.WriteLine($"Games with penalties: {penalties}");
            Console.WriteLine($"Games with additional time: {additionalTime}");
        }
    }
}
