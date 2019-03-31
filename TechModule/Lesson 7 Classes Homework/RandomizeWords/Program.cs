using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random randomizer = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int randomPosition = randomizer.Next(0, words.Count);

                string temp = words[i];
                words[i] = words[randomPosition];
                words[randomPosition] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
