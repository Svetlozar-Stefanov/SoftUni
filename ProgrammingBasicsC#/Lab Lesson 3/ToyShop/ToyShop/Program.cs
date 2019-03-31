using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePuzzle = 2.60;
            double priceDoll = 3;
            double priceBear = 4.10;
            double priceMinion = 8.20;
            double priceTruck = 2;

            double priceVacation = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double toySum = puzzles * pricePuzzle + dolls * priceDoll + bears * priceBear + minions * priceMinion + trucks * priceTruck;
            double numberOfToys = puzzles + dolls + bears + minions + trucks;

            double discount = 0;
            if (numberOfToys >= 50)
            {
                discount = toySum * 0.25;
            }
            double afterDiscount = toySum - discount;
            double finalSum = afterDiscount - (afterDiscount * 0.1);

            if (finalSum >= priceVacation)
            {
                
                Console.WriteLine($"Yes! {(finalSum - priceVacation):f2} lv left.");
            }
            else
            {
                
                Console.WriteLine($"Not enough money! {(priceVacation - finalSum):f2} lv needed.");
            }


        }
    }
}
