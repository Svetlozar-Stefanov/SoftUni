namespace SortEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Even
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();

            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
