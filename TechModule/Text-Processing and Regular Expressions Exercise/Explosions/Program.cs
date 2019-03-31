using System;
using System.Collections.Generic;
using System.Linq;

namespace Explosions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == '>')
                {
                    if (i + 1 < input.Count)
                    {
                        int explosionPower = input[i + 1] - '0';
                        for (int j = 0; j < explosionPower; j++)
                        {
                            try
                            {
                                if (input[i + 1] == '>')
                                {
                                    if (i + 2 < input.Count)
                                    {
                                        explosionPower += input[i + 2] - '0';
                                        i++;
                                        j--;
                                    }
                                }
                                else
                                {
                                    input.RemoveAt(i + 1);
                                }
                            }
                            catch (Exception)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(String.Join("", input));
        }
    }
}
