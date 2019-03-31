using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double moneySpent = 0;

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (budget <= 0)
                {
                    Console.WriteLine($"Out of money!");
                    return;
                }
                if (input == "game time")
                {
                    Console.WriteLine($"Total spent: {moneySpent:c2}. Remaining: {budget:c2}");
                    return;
                }

                if (input == "outfall 4")
                {
                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        moneySpent += 39.99;
                        Console.WriteLine($"Bought OutFall 4");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (input == "cs: og")
                {
                    if (budget >= 15.99)
                    {
                        budget -= 15.99;
                        moneySpent += 15.99;
                        Console.WriteLine($"Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (input == "zplinter zell")
                {
                    if (budget >= 19.99)
                    {
                        budget -= 19.99;
                        moneySpent += 19.99;
                        Console.WriteLine($"Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (input == "honored 2")
                {
                    if (budget >= 59.99)
                    {
                        budget -= 59.99;
                        moneySpent += 59.99;
                        Console.WriteLine($"Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (input == "roverwatch")
                {
                    if (budget >= 29.99)
                    {
                        budget -= 29.99;
                        moneySpent += 29.99;
                        Console.WriteLine($"Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else if (input == "roverwatch origins edition")
                {
                    if (budget >= 39.99)
                    {
                        budget -= 39.99;
                        moneySpent += 39.99;
                        Console.WriteLine($"Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}
