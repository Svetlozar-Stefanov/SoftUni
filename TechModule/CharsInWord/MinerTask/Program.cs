using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ores = new Dictionary<string, int>();

            while (true)
            {
                string ore = Console.ReadLine();
                if (ore == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!ores.ContainsKey(ore))
                {
                    ores[ore] = 0;
                }
                ores[ore] += quantity;
            }

            foreach (var ore in ores)
            {
                Console.WriteLine($"{ore.Key} -> {ore.Value}");
            }
        }
    }
}
