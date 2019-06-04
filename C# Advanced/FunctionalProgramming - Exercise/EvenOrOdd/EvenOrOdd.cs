namespace EvenOrOdd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EvenOrOdd
    {
        public static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();

            if (command == "odd")
            {
                Console.WriteLine(string.Join(" ",numbers.Where(n => isOdd(n))));
            }
            if (command == "even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(n => isEven(n))));
            }
        }

        public static Predicate<int> isEven = n => n % 2 == 0;
        public static Predicate<int> isOdd = n => n % 2 != 0;
    }
}
