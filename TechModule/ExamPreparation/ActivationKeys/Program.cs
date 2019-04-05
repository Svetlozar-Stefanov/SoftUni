using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = Console.ReadLine().Split("&");
            List<string> finalKeys = new List<string>();

            for (int n = 0; n < keys.Length; n++)
            {
                string key = keys[n];

                Regex regex = new Regex(@"\w{16,25}");

                if (regex.IsMatch(key) && (key.Length == 16 || key.Length == 25))
                {
                    List<char> keySymbols = key.ToList();
                    for (int i = 0; i < keySymbols.Count; i++)
                    {
                        if (char.IsDigit(keySymbols[i]))
                        {
                            int number = 9 - (keySymbols[i] - '0');
                            keySymbols[i] = (char)(number + '0');
                        }
                    }
                    key = String.Join("",keySymbols);

                    List<string> parts = new List<string>();
                    if (key.Length == 16)
                    {
                        for (int i = 0; i <= 12; i += 4)
                        {
                            parts.Add(key.Substring(i, 4).ToUpper());
                        }
                    }
                    else if (key.Length == 25)
                    {
                        for (int i = 0; i <= 20; i += 5)
                        {
                            parts.Add(key.Substring(i, 5).ToUpper());
                        }
                    }

                    finalKeys.Add(String.Join("-", parts));
                }
            }
            Console.WriteLine(String.Join(", ",finalKeys));
        }
    }
}
