using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            OrderPrice(product, quantity);
        }

        private static void OrderPrice(string product, int quantity)
        {
            if (product == "coffee")
            {
                Console.WriteLine(1.50m * quantity);
            }
            else if (product == "water")
            {
                Console.WriteLine(1.00m * quantity);
            }
            else if (product == "coke")
            {
                Console.WriteLine(1.40m * quantity);
            }
            else if (product == "snacks")
            {
                Console.WriteLine(2.00m * quantity);
            }
        }
    }
}
