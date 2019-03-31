using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingHome
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            int fuelTo100km = int.Parse(Console.ReadLine());
            double priceLiter = double.Parse(Console.ReadLine());
            int prize = int.Parse(Console.ReadLine());

            double fuelExpense = (km * fuelTo100km) / 100.0;
            double fuelPrice = fuelExpense * priceLiter;

            double moneyLeft = prize - fuelPrice;

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"You can go home. {moneyLeft:f2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {(prize / 5.0):f2} money.");
            }

        }
    }
}
