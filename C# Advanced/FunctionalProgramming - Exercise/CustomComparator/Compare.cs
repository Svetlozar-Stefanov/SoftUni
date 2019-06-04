namespace CustomComparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Compare
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> even = numbers.Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();

            List<int> odd = numbers.Where(n => n % 2 != 0)
                .OrderBy(n => n)
                .ToList();
            
            Console.Write($"{string.Join(" ", even)} {string.Join(" ", odd)}");
        }
    }
}
