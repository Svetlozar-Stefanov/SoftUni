namespace SumNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sum
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
