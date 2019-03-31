using System;

namespace MetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal convertKm = meters / 1000m;
            Console.WriteLine($"{convertKm:f2}");
        }
    }
}
