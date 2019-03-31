using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> shoppingList = new Dictionary<string, Product>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "buy")
            {
                string productName = command[0];
                double price = double.Parse(command[1]);
                double quantity = double.Parse(command[2]);

                if (!shoppingList.ContainsKey(productName))
                {
                    shoppingList[productName] = new Product(0, 0);
                }
                shoppingList[productName].Price = price;
                shoppingList[productName].Quantity += quantity;

                command = Console.ReadLine().Split();
            }

            foreach (var product in shoppingList)
            {
                double totalPrice = product.Value.Price * product.Value.Quantity;
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }

    class Product
    {
        public Product(double price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }
        public double Price;
        public double Quantity;
    }
}
