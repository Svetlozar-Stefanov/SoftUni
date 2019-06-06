namespace CustomComparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Compare
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> orderEvenOdd = (x, y) =>
              (x % 2 == 0 && y % 2 != 0) ? -1 :
              (x % 2 != 0 && y % 2 == 0) ? 1 :
              (x > y) ? 1 : (x < y) ? -1 : 0;

            Array.Sort(numbers, (x,y) => orderEvenOdd(x,y));

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
