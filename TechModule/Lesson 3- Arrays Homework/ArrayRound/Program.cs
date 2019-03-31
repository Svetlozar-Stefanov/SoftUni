using System;
using System.Linq;

namespace ArrayRound
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num} => {Math.Round(num, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
