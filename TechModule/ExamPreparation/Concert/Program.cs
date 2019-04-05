using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandPlayTime = new Dictionary<string, int>();

            string[] initialInput = Console.ReadLine().Split("; ");

            while (initialInput[0] != "start of concert")
            {
                string command = initialInput[0];
                if (command == "Add")
                {
                    string bandName = initialInput[1];
                    string[] musicians = initialInput[2].Split(", ");

                    if (!bands.ContainsKey(bandName))
                    {
                        bands.Add(bandName, new List<string>());
                    }

                    foreach (var player in musicians)
                    {
                        if (!bands[bandName].Contains(player))
                        {
                            bands[bandName].Add(player);
                        }
                    }
                }

                if (command =="Play")
                {
                    string bandName = initialInput[1];
                    int playTime = int.Parse(initialInput[2]);

                    if (!bandPlayTime.ContainsKey(bandName))
                    {
                        bandPlayTime.Add(bandName, 0);
                    }
                    bandPlayTime[bandName] += playTime;
                }

                initialInput = Console.ReadLine().Split("; ");
            }

            int totalTime = 0;
            foreach (var band in bandPlayTime)
            {
                totalTime += band.Value;
            }
            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandPlayTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string lastInput = Console.ReadLine();
            foreach (var band in bands)
            {
                if (band.Key == lastInput)
                {
                    Console.WriteLine(band.Key);
                    foreach (var player in band.Value)
                    {
                        Console.WriteLine($"=> {player}");
                    }
                }
            }
        }
    }
}
