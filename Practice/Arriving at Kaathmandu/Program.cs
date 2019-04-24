using System;
using System.Text.RegularExpressions;

namespace Arriving_at_Kaathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"^(?<name>[A-Za-z0-9!@#$?]+)=(?<length>\d+)<<(?<geohash>.*)$");

            while (input != "Last note")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    string encryptedName = match.Groups["name"].Value;
                    int length = int.Parse(match.Groups["length"].Value);
                    string geohash = match.Groups["geohash"].Value;
                    if (geohash.Length == length)
                    {
                        string decryptedName = "";
                        foreach (var letter in encryptedName)
                        {
                            if (char.IsLetterOrDigit(letter))
                            {
                                decryptedName += letter;
                            }
                        }

                        Console.WriteLine($"Coordinates found! {decryptedName} -> {geohash}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
