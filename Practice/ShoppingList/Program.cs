using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopsList = Console.ReadLine().Split().ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "Include")
                {
                    string shop = commands[1];
                    shopsList.Add(shop);
                }
                else if (commands[0] == "Visit")
                {
                    string order = commands[1];
                    int numberOfShops = int.Parse(commands[2]);

                    if (numberOfShops <= shopsList.Count)
                    {
                        if (order == "first")
                        {
                            for (int j = 0; j < numberOfShops; j++)
                            {
                                shopsList.RemoveAt(0);
                            }
                        }
                        else if (order == "last")
                        {
                            for (int j = 0; j < numberOfShops; j++)
                            {
                                shopsList.RemoveAt(shopsList.Count-1);
                            }
                        }
                    }
                }
                else if (commands[0] == "Prefer")
                {
                    int firstIndex = int.Parse(commands[1]);
                    int secondIndex = int.Parse(commands[2]);
                    if (firstIndex >= 0 && firstIndex < shopsList.Count &&
                        secondIndex >= 0 && secondIndex < shopsList.Count)
                    {
                        string temp = shopsList[firstIndex];

                        shopsList[firstIndex] = shopsList[secondIndex];
                        shopsList[secondIndex] = temp;
                    }
                }
                else if (commands[0] == "Place")
                {
                    string shop = commands[1];
                    int index = int.Parse(commands[2]) + 1;

                    if (index >= 0 && index < shopsList.Count)
                    {
                        shopsList.Insert(index, shop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(String.Join(" ", shopsList));
        }
    }
}
