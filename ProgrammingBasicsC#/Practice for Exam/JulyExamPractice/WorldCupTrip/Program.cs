using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double goingTicket = double.Parse(Console.ReadLine());
            double bacwayTicket = double.Parse(Console.ReadLine());
            double matchTicket = double.Parse(Console.ReadLine());
            double numOfMatches = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double planeTickets = 6 * (goingTicket + bacwayTicket);
            double planeTicketsWithDiscount = planeTickets - (planeTickets * (discount / 100.0));

            double totalMatchTickets = 6 * matchTicket * numOfMatches;
            double total = planeTicketsWithDiscount + totalMatchTickets;

            Console.WriteLine($"Total sum: {total:f2} lv.");

            double eachTicket = total / 6;

            Console.WriteLine($"Each friend has to pay {eachTicket:f2} lv.");
        }
    }
}
