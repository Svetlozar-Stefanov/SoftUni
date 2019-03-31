using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;

            bool broken = false;
            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantiy = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (!materials.ContainsKey(material))
                    {
                        materials[material] = 0;
                    }
                    materials[material] += quantiy;

                    if (materials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        materials["shards"] -= 250;
                        broken = true;
                        break;
                    }
                    else if (materials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        materials["fragments"] -= 250;
                        broken = true;
                        break;
                    }
                    else if (materials["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        materials["motes"] -= 250;
                        broken = true;
                        break;
                    }
                }
                if (broken)
                {
                    break;
                }
            }

            Dictionary<string, int> valuableMaterials = materials.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes").ToDictionary(x => x.Key ,x => x.Value);
            valuableMaterials = valuableMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in valuableMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Dictionary<string, int> junk = materials.Where(x => x.Key != "shards" && x.Key != "fragments" && x.Key != "motes").ToDictionary(x => x.Key, x => x.Value);
            junk = junk.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
