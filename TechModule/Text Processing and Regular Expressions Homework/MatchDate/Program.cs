using System;
using System.Text.RegularExpressions;

namespace MatchDate
{
    class Program
    { 
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            MatchCollection result = Regex.Matches(dates, regex);

            foreach (Match date in result)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
