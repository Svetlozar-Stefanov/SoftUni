using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int warriorsWaves = int.Parse(Console.ReadLine());

            List<int> defences = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> warriors = null;

            bool isDefeted = false;
            for (int i = 1; i <= warriorsWaves; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 3 == 0)
                {
                    int newDefender = int.Parse(Console.ReadLine());
                    defences.Add(newDefender);
                }

                warriors = new List<int>(input);

                while (warriors.Count > 0)
                {
                    if (defences.Count <= 0)
                    {
                        isDefeted = true;
                        break;
                    }

                    int currentPlate = defences[0];
                    int currentWarrior = warriors.Last();

                    if (currentPlate - currentWarrior > 0)
                    {
                        defences[0] -= warriors.Last();
                        warriors.RemoveAt(warriors.Count - 1);
                    }
                    else if (currentPlate - currentWarrior < 0)
                    {
                        warriors[warriors.Count - 1] -= defences[0];
                        defences.RemoveAt(0);
                    }
                    else if (currentPlate - currentWarrior == 0)
                    {
                        warriors.RemoveAt(warriors.Count - 1);
                        defences.RemoveAt(0);
                    }
                }
                if (isDefeted)
                {
                    break;
                }
            }

            if (isDefeted)
            {
                Console.WriteLine($"The Trojans successfully destroyed the Spartan defense.");
                warriors.Reverse();
                Console.WriteLine($"Warriors left: {string.Join(", ",warriors)}");
            }
            if (!isDefeted)
            {
                Console.WriteLine($"The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ",defences)}");
            }
        }
    }
}
