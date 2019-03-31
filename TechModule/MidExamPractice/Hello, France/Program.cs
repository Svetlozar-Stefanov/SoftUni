using System;
using System.Collections.Generic;
using System.Linq;

namespace Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allItems = Console.ReadLine().Split('|');
            decimal budget = decimal.Parse(Console.ReadLine());

            List<decimal> higherPrices = new List<decimal>();
            decimal profit = 0;

            for (int i = 0; i < allItems.Length; i++)
            {
                string[] currentItemInfo = allItems[i].Split("->");
                string name = currentItemInfo[0];
                decimal price = decimal.Parse(currentItemInfo[1]);
                if (price <= budget)
                {
                    if (name == "Clothes" && price <= 50m)
                    {
                        budget -= price;
                        decimal currentProfit = price * 0.4m;
                        profit += currentProfit;
                        higherPrices.Add(price + currentProfit);
                    }
                    if (name == "Shoes" && price <= 35m)
                    {
                        budget -= price;
                        decimal currentProfit = price * 0.4m;
                        profit += currentProfit;
                        higherPrices.Add(price + currentProfit);
                    }
                    if (name == "Accessories" && price <= 20.50m)
                    {
                        budget -= price;
                        decimal currentProfit = price * 0.4m;
                        profit += currentProfit;
                        higherPrices.Add(price + currentProfit);
                    }
                }
                
            }

            foreach (var num in higherPrices)
            {
                Console.Write($"{num:f2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:f2}");
            if (budget + (higherPrices.Sum())>= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
