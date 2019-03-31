using System;
using System.Collections.Generic;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseTable = new Dictionary<string, char>
            {
                { ".-", 'A' },
                { "-...", 'B' },
                { "-.-.", 'C' },
                { "-..", 'D' },
                { ".", 'E' },
                { "..-.", 'F' },
                { "--.", 'G' },
                { "....", 'H' },
                { "..", 'I' },
                { ".---", 'J' },
                { "-.-", 'K' },
                { ".-..", 'L' },
                { "--", 'M' },
                { "-.", 'N' },
                { "---", 'O' },
                { ".--.", 'P' },
                { "--.-", 'Q' },
                { ".-.", 'R' },
                { "...", 'S' },
                { "-", 'T' },
                { "..-", 'U' },
                { "...-", 'V' },
                { ".--", 'W' },
                { "-..-", 'X' },
                { "-.--", 'Y' },
                { "--..", 'Z' }
            };

            string[] input = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                string[] letters = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string word = "";
                for (int j = 0; j < letters.Length; j++)
                {
                    word += morseTable[letters[j]];
                }

                result += word + " ";  
            }

            Console.WriteLine(result);
        }
    }
}
