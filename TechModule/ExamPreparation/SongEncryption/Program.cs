using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"^(?<artist>[A-Z][ 'a-z]+):(?<song>[A-Z ]+)$");
            while (input != "end")
            {
                if (regex.IsMatch(input))
                {
                    Match info = regex.Match(input);
                    string artist = info.Groups["artist"].Value;
                    string song = info.Groups["song"].Value;

                    StringBuilder encryption = new StringBuilder();
                    for (int i = 0; i < input.Length; i++)
                    {
                        char currentChar = input[i];
                        int key = artist.Length;

                        if (currentChar == ':')
                        {
                            encryption.Append("@");
                            continue;
                        }
                        if (currentChar >= 65 && currentChar <= 90)
                        {
                            while (currentChar + key > 90)
                            {
                                key = key - (90 - (int)currentChar);
                                currentChar = (char)('A' - 1);
                            }
                            currentChar = (char)(currentChar + key);
                        }
                        else if (currentChar >= 97 && currentChar <= 122)
                        {
                            while (currentChar + key > 122)
                            {
                                key = key - (122 - (int)currentChar);
                                currentChar = (char)('a' - 1);
                            }
                            currentChar = (char)(currentChar + key);
                        }
                        encryption.Append(currentChar);
                    }

                    Console.WriteLine($"Successful encryption: {encryption.ToString()}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
