using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<int> houses = Console.ReadLine().Split().Select(int.Parse).ToList();
            int santaIndex = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Forward")
                {
                    int numberOfSteps = int.Parse(command[1]);
                    if (santaIndex + numberOfSteps < houses.Count && santaIndex + numberOfSteps >= 0)
                    {
                        santaIndex += numberOfSteps;
                        houses.RemoveAt(santaIndex);
                    }
                }
                else if (command[0] == "Back")
                {
                    int numberOfSteps = int.Parse(command[1]);
                    if (santaIndex - numberOfSteps < houses.Count && santaIndex - numberOfSteps >= 0)
                    {
                        santaIndex -= numberOfSteps;
                        houses.RemoveAt(santaIndex);
                    }
                }
                else if (command[0] == "Gift")
                {
                    int index = int.Parse(command[1]);
                    int houseNumber = int.Parse(command[2]);
                    if (index >= 0 && index < houses.Count)
                    {
                        houses.Insert(index, houseNumber);
                        santaIndex = index;
                    }
                }
                else if (command[0] == "Swap")
                {
                    int first = int.Parse(command[1]);
                    int second = int.Parse(command[2]);
                    int indexOfFirst = houses.IndexOf(first);
                    int indexOfSecond = houses.IndexOf(second);

                    if (indexOfFirst >= 0 && indexOfFirst < houses.Count
                        && indexOfSecond >= 0 && indexOfSecond < houses.Count)
                    {
                        int temp = houses[indexOfFirst];
                        houses[indexOfFirst] = houses[indexOfSecond];
                        houses[indexOfSecond] = temp;
                    }
                }
            }

            Console.WriteLine($"Position: {santaIndex}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
