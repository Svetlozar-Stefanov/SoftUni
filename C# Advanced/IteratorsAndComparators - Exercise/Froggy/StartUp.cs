using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] path = input
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(path);

            List<int> output = new List<int>();
            foreach (var stone in lake)
            {
                output.Add(stone);
            }

            Console.WriteLine(string.Join(", ",output));
        }
    }
}
