using System;
using System.Collections.Generic;

namespace Supermarket
{
    class SupermarketQueue
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();

            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                if (input.ToLower() == "paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
