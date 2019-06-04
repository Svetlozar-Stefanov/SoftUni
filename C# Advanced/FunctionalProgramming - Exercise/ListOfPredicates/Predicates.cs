namespace ListOfPredicates
{
    using System;
    using System.Linq;

    public class Predicates
    {
        public static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] checkers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 1; i <= range; i++)
            {
                if (Checker(i,checkers))
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static Func<int, int[], bool> Checker = (num, arr) =>
        {
            foreach (var chekrer in arr)
            {
                if (num % chekrer != 0)
                {
                    return false;
                }
            }
            return true;
        };
    }
}
