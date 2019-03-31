using System;
using System.Numerics;

namespace TypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }

                bool isBool = bool.TryParse(input, out bool boolean);
                bool isInteger = BigInteger.TryParse(input ,out BigInteger ineger);
                bool isFloating = float.TryParse(input, out float floating);
                bool isChar = char.TryParse(input, out char chr);

                if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isFloating)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
