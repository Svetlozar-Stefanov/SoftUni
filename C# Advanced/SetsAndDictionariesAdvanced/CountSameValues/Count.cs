namespace CountSameValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Count
    {
        public static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!count.ContainsKey(num))
                {
                    count[num] = 0;
                }
                count[num]++;
            }

            foreach (var pair in count)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
