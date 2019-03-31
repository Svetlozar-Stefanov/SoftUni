using System;

namespace PoundToDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal convertUS = pounds * 1.31m;

            Console.WriteLine($"{convertUS:f3}");
        }
    }
}
