using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (ticketType == "VIP")
            {
                ticketPrice = 499.99;
            }
            else
            {
                ticketPrice = 249.99;
            }

            double transportMoney = 0;

            if (people >= 1 && people <= 4)
            {
                transportMoney = budget * 0.75;
            }

            else if (people >= 5 && people <=9)
            {
                transportMoney = budget * 0.6;
            }

            else if (people >= 10 && people <= 24)
            {
                transportMoney = budget * 0.5;
            }

            else if (people >= 25 && people <= 49)
            {
                transportMoney = budget * 0.4;
            }

            else if (people >= 50)
            {
                transportMoney = budget * 0.25;
            }

            double moneyLeftBeforeTicket = budget - transportMoney;
            double moneyLeftAfterTicket = moneyLeftBeforeTicket - (ticketPrice * people);

            if (moneyLeftBeforeTicket > ticketPrice * people)
            {
                Console.WriteLine($"Yes! You have {moneyLeftAfterTicket:f2} leva left.");
            }

            else if(moneyLeftBeforeTicket < ticketPrice * people)
            {

                moneyLeftAfterTicket = Math.Abs(moneyLeftAfterTicket);
                Console.WriteLine($"Not enough money! You need {moneyLeftAfterTicket:f2} leva.");
            }
        }
    }
}
