namespace CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class Count
    {
        public static void Main(string[] args)
        {
            SortedDictionary<char, int> counter = new SortedDictionary<char, int>();

            string input = Console.ReadLine();
            foreach (var letter in input)
            {
                if (!counter.ContainsKey(letter))
                {
                    counter[letter] = 0;
                }
                counter[letter]++;
            }

            foreach (var letter in counter)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }

        }
    }
}
