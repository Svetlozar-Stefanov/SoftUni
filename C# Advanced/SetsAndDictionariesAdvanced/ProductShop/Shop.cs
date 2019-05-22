namespace ProductShop
{
    using System;
    using System.Collections.Generic;

    public class Shop
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0]?.ToLower() != "revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop][product] = 0;
                }

                shops[shop][product] = price;
                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var pair in shops)
            {
                Console.WriteLine($"{pair.Key}->");
                foreach (var product in pair.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
