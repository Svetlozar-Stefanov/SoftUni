using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWhiskey / 2;
            double priceWine = priceRakia - (0.4 * priceRakia);
            double priceBeer = priceRakia - (0.8 * priceRakia);

            double sumRakia = rakia * priceRakia;
            double sumWine = wine * priceWine;
            double sumBeer = beer * priceBeer;
            double sumWhisky = whiskey * priceWhiskey;

            double price = sumRakia + sumWine + sumBeer + sumWhisky;
            Console.WriteLine($"{price:f2}");
        }
    }
}
