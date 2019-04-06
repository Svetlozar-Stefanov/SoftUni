using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            string[] wordsAndDescriptions = Console.ReadLine().Split(" | ");

            foreach (var pair in wordsAndDescriptions)
            {
                string[] pairInfo = pair.Split(": ");
                string word = pairInfo[0];
                string description = pairInfo[1];

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }
                dictionary[word].Add(description);
            }

            string[] wordsToOutput = Console.ReadLine().Split(" | ");
            foreach (var word in wordsToOutput)
            {
                if (dictionary.ContainsKey(word))
                {
                    Console.WriteLine($"{word}");
                    foreach (var description in dictionary[word].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{description}");
                    }
                }
            }

            string endCommand = Console.ReadLine();
            if (endCommand == "End")
            {
                return;
            }
            if (endCommand == "List")
            {
                foreach (var word in dictionary.OrderBy(x =>  x.Key))
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
