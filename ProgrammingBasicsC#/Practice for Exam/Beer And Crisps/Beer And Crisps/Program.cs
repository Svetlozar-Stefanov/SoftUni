using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_And_Crisps
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int bottles = int.Parse(Console.ReadLine());
            int packs = int.Parse(Console.ReadLine());

            double beerPrice = 1.20 * bottles;
            double crispsPrice1 = beerPrice * 0.45;
            double totalCrispPrice = Math.Ceiling(crispsPrice1 * packs);

            double total = beerPrice + totalCrispPrice;

            if (budget >= total)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - total):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(total - budget):f2} more leva!");
            }
        
        }
    }
}
