using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();
            while (input.Contains(wordToRemove))
            {
                input = input.Replace(wordToRemove, "");
            }

            Console.WriteLine(input);
        }
    }
}
