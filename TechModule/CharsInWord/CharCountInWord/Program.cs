using System;
using System.Collections.Generic;

namespace CharCountInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    if (!letters.ContainsKey(word[i]))
                    {
                        letters[word[i]] = 0;
                    }
                    letters[word[i]]++;
                }
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
