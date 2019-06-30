using System;
using System.Linq;

namespace HotelReservation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);

            Season season = default(Season);
            switch (input[2])
            {
                case "Autumn":season = Season.Autumn;
                    break;
                case "Spring":
                    season = Season.Spring;
                    break;
                case "Winter":
                    season = Season.Winter;
                    break;
                case "Summer":
                    season = Season.Summer;
                    break;
                default:
                    break;
            }
            Discounts discounts = default(Discounts);
            if (input.Length == 3)
            {
                discounts = Discounts.None;
            }
            else
            {
                switch (input[3])
                {
                    case "VIP":
                        discounts = Discounts.Vip;
                        break;
                    case "SecondVisit":
                        discounts = Discounts.SecondVisit;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{PriceCalculator.GetFullPrice(pricePerDay, numberOfDays, season, discounts):f2}");
        }
    }
}
