using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, > dwarfs = new Dictionary<string, List<Characteristics>>();

            string[] input = Console.ReadLine().Split(" <:> ");
            while (input[0] != "Once upon a time")
            {
                string dwarfName = input[0];
                string hatColor = input[1];
                int physics = int.Parse(input[2]);

                if (!dwarfs.ContainsKey(dwarfName))
                {
                    dwarfs[dwarfName] = new List<Characteristics>
                    {
                        new Characteristics(hatColor, physics)
                    };
                }
                if (dwarfs.ContainsKey(dwarfName) && !dwarfs[dwarfName].Any(x => x.HatColour == hatColor))
                {
                    dwarfs[dwarfName].Add(new Characteristics(hatColor, physics));
                }
                if (dwarfs.ContainsKey(dwarfName) && dwarfs[dwarfName].Any(x => x.HatColour == hatColor))
                {
                    if (physics > dwarfs[dwarfName].)
                    {
                        dwarfs[dwarfName][hatColor] = physics;
                    }
                }
                input = Console.ReadLine().Split(" <:> ");
            }

            

            foreach (var imp in dwarfs)
            {
                foreach (var item in imp.Value)
                {
                    Console.WriteLine($"({item.Key}) {imp.Key} <-> {item.Value}");
                }
            }
        }
    }

    class Characteristics
    {
        public Characteristics(string hatColor, int physics)
        {
            HatColour = hatColor;
            Physics = physics;
        }

        public string HatColour;
        public int Physics;
    }
}
