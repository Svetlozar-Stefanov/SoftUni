using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                if (item == "hoodie")
                {
                    sum += 30;
                }
                if (item == "keychain")
                {
                    sum += 4;
                }
                if (item == "T-shirt")
                {
                    sum += 20;
                }
                if (item == "flag")
                {
                    sum += 15;
                }
                if (item == "sticker")
                {
                    sum += 1;
                }
            }
            if (budget >= sum)
            {
                Console.WriteLine($"You bought {n} items and left with {budget - sum} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget} more lv.");
            }
        }
    }
}
