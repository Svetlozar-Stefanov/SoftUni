using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];
                string damage = input[2];
                if (damage == "null")
                {
                    damage = 45.ToString();
                }
                string health = input[3];
                if (health == "null")
                {
                    health = 250.ToString();
                }
                string armor = input[4];
                if (armor == "null")
                {
                    armor = 10.ToString();
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new List<Dragon>();
                }
                if (dragons[type].Any(x => x.Name == name))
                {
                    for (int j = 0; j < dragons[type].Count; j++)
                    {
                        if (dragons[type][j].Name == name)
                        {
                            dragons[type][j].Damage = int.Parse(damage);
                            dragons[type][j].Health = int.Parse(health);
                            dragons[type][j].Armor = int.Parse(armor);
                        }
                    }
                }
                else
                {
                    dragons[type].Add(new Dragon(name, double.Parse(damage), double.Parse(health), double.Parse(armor)));
                }
            }

            foreach (var dragon in dragons)
            {
                double avgDmg = 0;
                double avgHealth = 0;
                double avgArmor = 0;

                foreach (var stat in dragon.Value)
                {
                    avgDmg += stat.Damage;
                    avgHealth += stat.Health;
                    avgArmor += stat.Armor;
                }

                avgDmg /= dragon.Value.Count;
                avgHealth /= dragon.Value.Count;
                avgArmor /= dragon.Value.Count;

                Console.WriteLine($"{dragon.Key}::({avgDmg:f2}/{avgHealth:f2}/{avgArmor:f2})");

                foreach (var info in dragon.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{info.Name} -> damage: {info.Damage}, health: {info.Health}, armor: {info.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public Dragon(string name,double damage, double health, double armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Name;
        public double Damage;
        public double Health;
        public double Armor;
    }
}
