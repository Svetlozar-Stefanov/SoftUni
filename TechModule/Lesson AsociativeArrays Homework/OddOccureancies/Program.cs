using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccureancies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listWords = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> countWords = new Dictionary<string, int>();

            for (int i = 0; i < listWords.Count; i++)
            {
                if (!countWords.ContainsKey(listWords[i]))
                {
                    countWords[listWords[i]] = 0;
                }
                countWords[listWords[i]]++;
            }

            foreach (var word in countWords)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
