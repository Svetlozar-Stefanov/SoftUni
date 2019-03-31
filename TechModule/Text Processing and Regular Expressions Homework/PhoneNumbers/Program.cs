using System;
using System.Text.RegularExpressions;

namespace PhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            MatchCollection result = Regex.Matches(numbers, @"(?<=^| )\+359([- ])[2]\1[\d]{3}\1[\d]{4}\b");

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
