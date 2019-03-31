using System;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[]{',', ' '},StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string split = ticket;
                    string leftSide = split.Substring(0, 10);
                    string rightSide = split.Substring(10, 10);
                    string regex = @"[@]{6,10}|[$]{6,10}|[#]{6,10}|[\^]{6,10}";

                    Match leftSymbols = Regex.Match(leftSide, regex);
                    Match rightSymbols = Regex.Match(rightSide, regex);

                    string smallerMatch = "";
                    string biggerMatch = "";

                    if (leftSymbols.Length >= rightSymbols.Length)
                    {
                        biggerMatch = leftSymbols.ToString();
                        smallerMatch = rightSymbols.ToString();
                    }
                    else
                    {
                        biggerMatch = rightSymbols.ToString();
                        smallerMatch = leftSymbols.ToString();
                    }

                    if ((biggerMatch.Length > 0 && smallerMatch.Length > 0) && smallerMatch[0] == biggerMatch[0])
                    {
                        if (smallerMatch.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {smallerMatch.Length}{smallerMatch.ToString()[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {smallerMatch.Length}{smallerMatch.ToString()[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
