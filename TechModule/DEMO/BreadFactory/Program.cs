using System;
using System.Linq;

namespace BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = 100;
            int initialCoins = 100;

            string[] events = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < events.Length; i++)
            {
                string[] currentDayInfo = events[i].Split("-").ToArray();

                string dayAction = currentDayInfo[0];
                int amount = int.Parse(currentDayInfo[1]);

                if (dayAction == "rest")
                {
                    if (initialEnergy + amount <= 100)
                    {
                        initialEnergy += amount;
                        Console.WriteLine($"You gained {amount} energy.");
                    }
                    else
                    {
                        Console.WriteLine($"You gained 0 energy.");
                    }
                    Console.WriteLine($"Current energy: {initialEnergy}.");
                }

                else if (dayAction == "order")
                {
                    
                    if (initialEnergy - 30 >= 0)
                    {
                        initialEnergy -= 30;
                        initialCoins += amount;
                        Console.WriteLine($"You earned {amount} coins.");
                    }
                    else
                    {
                        initialEnergy += 50;
                        Console.WriteLine($"You had to rest!");
                    }
                }
                else
                {
                    
                    if (initialCoins - amount > 0)
                    {
                        initialCoins -= amount;
                        Console.WriteLine($"You bought {dayAction}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {dayAction}.");
                        return;
                    }
                }
            }

            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {initialCoins}");
            Console.WriteLine($"Energy: {initialEnergy}");
        }
    }
}
