using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace LetterChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalSum = 0;

            MatchCollection pairs = Regex.Matches(input, @"(?<firstLetter>[a-zA-z])(?<number>\d+)(?<secondLetter>[a-zA-Z])");

            foreach (Match pair in pairs)
            {
                char firsLetter = char.Parse(pair.Groups["firstLetter"].Value);
                decimal number = decimal.Parse(pair.Groups["number"].Value);
                char secondLetter = char.Parse(pair.Groups["secondLetter"].Value);

                if (char.IsUpper(firsLetter))
                {
                    number = number / ((firsLetter - 'A') + 1);
                }
                else if (char.IsLower(firsLetter))
                {
                    number = number * ((firsLetter - 'a') + 1);
                }

                if (char.IsUpper(secondLetter))
                {
                    number = number - ((secondLetter - 'A') + 1);
                }
                else if (char.IsLower(secondLetter))
                {
                    number = number + ((secondLetter - 'a') + 1);
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
