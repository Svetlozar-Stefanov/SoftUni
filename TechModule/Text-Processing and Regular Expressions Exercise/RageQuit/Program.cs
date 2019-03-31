using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection strings = Regex.Matches(input , @"(?<message>\D+)(?<number>[\d]+)");
            StringBuilder result = new StringBuilder();

            foreach (Match match in strings)
            {
                string message = match.Groups["message"].Value.ToUpper();
                int repeat = int.Parse(match.Groups["number"].Value);

                for (int i = 0; i < repeat; i++)
                {
                    result.Append(message);
                }
            }
            string uniqueChar = new string(result.ToString().Distinct().ToArray());

            Console.WriteLine($"Unique symbols used: {uniqueChar.Length}");
            Console.WriteLine(result.ToString());
        }
    }
}
