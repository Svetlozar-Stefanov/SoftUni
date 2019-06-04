namespace AddVAT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VAT
    {
        public static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n += n * 0.2)
                .ToList();

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
