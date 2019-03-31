using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HiddenTresure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            while (input != "find")
            {
                StringBuilder result = new StringBuilder();

                int keyIndex = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (keyIndex >= keys.Length)
                    {
                        keyIndex = 0;
                    }

                    result.Append((char)(input[i] - keys[keyIndex]));
                    keyIndex++;
                }

                Match treasure = Regex.Match(result.ToString(), @"(?<=&)[A-Za-z]+(?=&)");
                Match coordinates = Regex.Match(result.ToString(), @"(?<=<)\w+(?=>)");

                Console.WriteLine($"Found {treasure} at {coordinates}");

                input = Console.ReadLine();
            }
        }
    }
}
