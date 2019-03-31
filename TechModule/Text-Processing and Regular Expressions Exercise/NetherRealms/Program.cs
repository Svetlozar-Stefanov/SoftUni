using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Demons> names = new List<Demons>();

            foreach (var name in input)
            {
                string regexHealth = @"[^\/*+-.\d]";
                MatchCollection symbols = Regex.Matches(name, regexHealth);

                double health = 0;
                foreach (Match symbol in symbols)
                {
                    health += char.Parse(symbol.ToString());
                }

                string regexDamage = @"[-+]?[0-9]*\.?[0-9]+";
                MatchCollection numbers = Regex.Matches(name, regexDamage);

                double damage = 0;
                foreach (Match number in numbers)
                {
                    damage += double.Parse(number.ToString());
                }

                MatchCollection operations = Regex.Matches(name, @"[*\/]");
                foreach (var op in operations)
                {
                    if (op.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                var demon = new Demons(name, health, damage);
                names.Add(demon);
            }

            names = names.OrderBy(x => x.Name).ToList();

            foreach (var name in names)
            {
                Console.WriteLine($"{name.Name} - {name.Health} health, {name.Damage:f2} damage");
            }
        }
    }

    class Demons
    {
        public Demons(string name, double health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public string Name;
        public double Health;
        public double Damage;
    }
}
