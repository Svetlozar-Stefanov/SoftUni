using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            char[] divider = { 's', 't', 'a', 'r' };
            char[] forbbiden = { '@', '-', '!', ':', '>' };
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            result.Add("A", new List<string>());
            result.Add("D", new List<string>());

            for (int i = 0; i < lines; i++)
            {
                string encryptedMessage = Console.ReadLine();
                char[] counterString = encryptedMessage.ToLower().Where(x => divider.Contains(x)).ToArray();
                int counter = counterString.Length;

                string decryptedMessage = "";
                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    decryptedMessage += (char)(encryptedMessage[j] - counter);
                }
                Regex reg = new Regex(@"@([a-zA-Z]+)[^@\-!:>]*:[0-9]+[^@\-!:>]*!([AD])![^@\-!:>]*->[0-9]+");
                if (reg.IsMatch(decryptedMessage))
                {
                    string planetName = reg.Match(decryptedMessage.ToString()).Groups[1].Value;
                    string attackType = reg.Match(decryptedMessage).Groups[2].Value;
                    if (attackType.ToString() == "A")
                    {
                        result["A"].Add(planetName.ToString());
                    }
                    else if (attackType.ToString() == "D")
                    {
                        result["D"].Add(planetName.ToString());
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {result["A"].Count}");
            foreach (var planet in result["A"].OrderBy(X => X))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {result["D"].Count}");
            foreach (var planet in result["D"].OrderBy(X => X))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
