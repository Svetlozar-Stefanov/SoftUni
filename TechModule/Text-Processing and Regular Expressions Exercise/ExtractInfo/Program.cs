using System;
using System.Text.RegularExpressions;

namespace ExtractInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                Match name = Regex.Match(input, @"(?<=@)[A-Za-z]+(?=\|)");
                Match age = Regex.Match(input, @"(?<=#)\d+(?=\*)");

                Console.WriteLine($"{name.ToString()} is {age.ToString()} years old.");
            }
        }
    }
}
