using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine();
            double fisherman = double.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (seasson == "Spring")
            {
                ticketPrice = 3000;
            }

            if (seasson == "Summer" || seasson == "Autumn")
            {
                ticketPrice = 4200;
            }

            if (seasson == "Winter")
            {
                ticketPrice = 2600;
            }

            if (fisherman <= 6)
            {
                ticketPrice *= 0.9;
            }

            else if (fisherman <= 11)
            {
                ticketPrice *= 0.85;
            }

            else if (fisherman > 11)
            {
               ticketPrice *= 0.75;
            }

            if (fisherman % 2 == 0 && seasson != "Autumn")
            {
                ticketPrice *= 0.95;
            }
            

            if (budget >= ticketPrice)
            {
                Console.WriteLine($"Yes! You have {budget - ticketPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {ticketPrice - budget:f2} leva.");
            }
        }
    }
}
