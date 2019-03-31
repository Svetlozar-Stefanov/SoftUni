using System;

namespace ChristmasSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int cost = 0;
            int spirit = 0;

            int i;
            for (i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {
                    cost += quantity * 2;
                    spirit += 5;
                }
                if (i % 3 == 0)
                {
                    cost += ((quantity * 5) + (quantity * 3));
                    spirit += 13;
                }
                if (i % 5 == 0)
                {
                    cost += quantity * 15;
                    spirit += 17;
                    if (i % 3 == 0)
                    {
                        spirit += 30;
                    }
                }
                if (i % 10 == 0)
                {
                    if (i == days)
                    {
                        spirit -= 30;
                    }
                    cost += 23;
                    spirit -= 20;
                }
            }

            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
