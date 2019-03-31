using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> drumQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> initialQuality = new List<int>();

            for (int i = 0; i < drumQuality.Count; i++)
            {
                initialQuality.Add(drumQuality[i]);
            }

            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < drumQuality.Count; i++)
                {
                    drumQuality[i] -= hitPower;

                    if (drumQuality[i] <= 0)
                    {
                        if (savings >= initialQuality[i] * 3)
                        {
                            savings -= initialQuality[i] * 3;
                            drumQuality[i] = initialQuality[i];
                            //Console.WriteLine(savings);
                        }
                        else
                        {
                            drumQuality.RemoveAt(i);
                            initialQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
                //Console.WriteLine(String.Join(" ", drumQuality));
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ",drumQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
