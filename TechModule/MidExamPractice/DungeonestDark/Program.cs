using System;

namespace DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;

            string[] allRooms = Console.ReadLine().Split("|");

            for (int i = 0; i < allRooms.Length; i++)
            {
                string[] currentRoom = allRooms[i].Split();
                string action = currentRoom[0];
                int number = int.Parse(currentRoom[1]);

                if (action == "potion")
                {
                    int initialHealth = health;
                    health += number;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    Console.WriteLine($"You healed for {health - initialHealth} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (action == "chest")
                {
                    coins += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {action}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {action}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
