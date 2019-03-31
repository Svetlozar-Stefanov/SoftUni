using System;
using System.Collections.Generic;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(", ").ToList();
            List<string> result = new List<string>();

            foreach (var word in words)
            {
                if (word.Length > 3 && word.Length < 16)
                {
                    bool valid = true;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(word[i]) ^ word[i] != '-' ^ word[i] != '_')
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        result.Add(word);
                    }
                }
            }

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
