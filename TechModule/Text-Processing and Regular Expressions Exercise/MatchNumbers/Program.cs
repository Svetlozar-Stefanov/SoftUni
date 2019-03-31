using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            MatchCollection result = Regex.Matches(input, regex);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
