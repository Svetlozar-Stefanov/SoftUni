using System;

namespace SignOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string sign = Sign(number);

            Console.WriteLine($"The number {number} is {sign}.");

        }

        static string Sign(int number)
        {
            if (number > 0)
            {
                return "positive"; 
            }
            else if (number < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }
    }
}
