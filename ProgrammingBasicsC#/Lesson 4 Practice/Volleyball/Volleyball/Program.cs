using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int numberOfDaysAtHome = int.Parse(Console.ReadLine());

            double gamesInSofia = (48 - numberOfDaysAtHome) * (3.0/4);
            double gamesOnHoliday = numberOfHolidays * (2.0 / 3);

            double sumOfGames = gamesInSofia + gamesOnHoliday + numberOfDaysAtHome;

            if (typeOfYear == "leap")
            {
                sumOfGames = sumOfGames + (sumOfGames * 0.15);
                Console.WriteLine(Math.Truncate(sumOfGames));
            }
            else if (typeOfYear == "normal")
            {
                Console.WriteLine(Math.Truncate(sumOfGames));
            }
        }
    }
}
