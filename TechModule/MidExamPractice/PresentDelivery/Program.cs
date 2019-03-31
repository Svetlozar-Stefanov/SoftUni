using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            int santaIndex = 0;

            string command = Console.ReadLine();

            while (command != "Merry Xmas!")
            {
                string[] action = command.Split();
                int jump = int.Parse(action[1]);
                santaIndex += jump;
                while (santaIndex >= houses.Length)
                {
                    santaIndex = santaIndex - houses.Length;
                }

                if (houses[santaIndex] > 0)
                {
                    houses[santaIndex] -= 2;
                }
                else
                {
                    Console.WriteLine($"House {santaIndex} will have a Merry Christmas.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Santa's last position was {santaIndex}.");

            if (houses.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int count = 0;
                foreach (var item in houses)
                {
                    if (item != 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Santa has failed {count} houses.");
            }
        }
    }
}
