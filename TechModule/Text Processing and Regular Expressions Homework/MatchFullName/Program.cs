using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection result = Regex.Matches(input, @"\b[A-Z][a-z]+[\s{1}][A-Z][a-z]+\b");

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
