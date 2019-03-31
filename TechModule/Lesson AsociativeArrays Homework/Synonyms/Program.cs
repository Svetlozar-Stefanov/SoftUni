using System;
using System.Collections.Generic;

namespace Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int words = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < words; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }
                dictionary[word].Add(synonym);
            }

            foreach (var word in dictionary)
            {
                Console.Write($"{word.Key} - ");
                Console.Write(String.Join(", ", word.Value));
                Console.WriteLine();
            }
        }
    }
}
