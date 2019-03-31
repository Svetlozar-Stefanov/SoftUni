using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            decimal inputSum = 0;
            while (input != "start")
            {
                decimal money = decimal.Parse(input);
                if (money == 0.1m || money == 0.2m || money == 0.5m || money == 1m || money == 2m)
                {
                    inputSum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                input = Console.ReadLine().ToLower();
            }

            input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                if (input == "nuts")
                {
                    if (inputSum < 2.0m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {input}");
                        inputSum -= 2;
                    }
                }
                else if (input == "water")
                {
                    if (inputSum < 0.7m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {input}");
                        inputSum -= 0.7m;
                    }
                }
                else if (input == "crisps")
                {
                    if (inputSum < 1.5m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {input}");
                        inputSum -= 1.5m;
                    }
                }
                else if (input == "soda")
                {
                    if (inputSum < 0.8m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {input}");
                        inputSum -= 0.8m;
                    }
                }
                else if (input == "water")
                {
                    if (inputSum < 0.7m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {input}");
                        inputSum -= 0.7m;
                    }
                }
                else if (input == "coke")
                {
                    if (inputSum < 1.0m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {input}");
                        inputSum -= 1.0m;
                    }
                }
                else
                {
                    Console.WriteLine("Ïnvalid product");
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {inputSum:f2}");
        }
    }
}
