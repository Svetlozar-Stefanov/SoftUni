using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAway = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dog1 = double.Parse(Console.ReadLine());
            double dog2 = double.Parse(Console.ReadLine());
            double dog3 = double.Parse(Console.ReadLine());

            double dog1Total = dog1 * daysAway;
            double dog2Total = dog2 * daysAway;
            double dog3Total = dog3 * daysAway;
            double totalFood = dog1Total + dog2Total + dog3Total;

            if (food >= totalFood)
            {
                Console.WriteLine($"{Math.Floor(food - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - food)} more kilos of food are needed.");
            }
        }
    }
}
