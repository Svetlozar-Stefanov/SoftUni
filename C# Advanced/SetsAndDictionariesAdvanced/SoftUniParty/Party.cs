namespace SoftUniParty
{
    using System;
    using System.Collections.Generic;

    public class Party
    {
        public static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> pesants = new HashSet<string>();

            string input = Console.ReadLine();
            while (input?.ToLower() != "party")
            {
                if (input.Length == 8)
                {
                    if (char.IsDigit(input[0]))
                    {
                        vip.Add(input);
                    }
                    else
                    {
                        pesants.Add(input);
                    }
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input?.ToLower() != "end")
            {
                vip.Remove(input);
                pesants.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(vip.Count + pesants.Count);

            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in pesants)
            {
                Console.WriteLine(item);
            }

        }
    }
}
