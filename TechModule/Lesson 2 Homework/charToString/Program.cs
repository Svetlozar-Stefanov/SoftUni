
using System;

namespace charToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string charSum = "";
            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                charSum += symbol;
            }

            Console.WriteLine(charSum);
        }
    }
}
