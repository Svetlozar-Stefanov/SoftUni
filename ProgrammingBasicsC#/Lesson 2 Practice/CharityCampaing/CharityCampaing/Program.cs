using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaing
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceCake = 45;
            double priceGofrete = 5.80;
            double pricePanckes = 3.20;

            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofretes = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sumCakes = cakes * priceCake;
            double sumGofretes = gofretes * priceGofrete;
            double sumPancake = pancakes * pricePanckes;
            double sumDay = (sumCakes + sumGofretes + sumPancake) * bakers;
            double campaing = sumDay * days;
            double expenses = campaing - (campaing * 0.125);

            Console.WriteLine($"{expenses:f2}");
        }
    }
}
