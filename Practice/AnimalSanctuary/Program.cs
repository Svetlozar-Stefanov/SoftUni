using System;
using System.Text.RegularExpressions;

namespace AnimalSanctuary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^n:(?<name>[^;]+);t:(?<type>[^;]+);c--(?<country>[A-Za-z ]+)$");

            int totalKg = 0;
            for (int i = 0; i < numberOfCommands; i++)
            {
                string encryptedMessage = Console.ReadLine();
                Match match = regex.Match(encryptedMessage);

                if (match.Success)
                {
                    string encryptedName = match.Groups["name"].Value;
                    string encryptedType = match.Groups["type"].Value;
                    string encryptedCountry = match.Groups["country"].Value;

                    string name = "";
                    string type = "";

                    foreach (var letter in encryptedName)
                    {
                        if (char.IsLetter(letter) || letter == ' ')
                        {
                            name += letter;
                        }
                        if (char.IsDigit(letter))
                        {
                            totalKg += letter - '0';
                        }
                    }

                    foreach (var letter in encryptedType)
                    {
                        if (char.IsLetter(letter) || letter ==  ' ')
                        {
                            type += letter;
                        }
                        if (char.IsDigit(letter))
                        {
                            totalKg += letter - '0';
                        }
                    }
                    Console.WriteLine($"{name} is a {type} from {encryptedCountry}");
                }
            }

            Console.WriteLine($"Total weight of animals: {totalKg}KG");
        }
    }
}
