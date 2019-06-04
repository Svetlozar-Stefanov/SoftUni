namespace ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Reverse
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int checkNum = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ",ReverseAndCheck(numbers,Checker,checkNum)));
        }

        public static Func<int, int, bool> Checker = (num, check) =>
        {
            if (num % check == 0)
            {
                return false;
            }
            return true;
        };

        public static Func<List<int>, Func<int, int, bool>,int , List<int>> ReverseAndCheck = (list, func, check) =>
        {
            List<int> newList = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (func(list[i],check))
                {
                    newList.Add(list[i]);
                }
            }

            return newList;
        };
    }
}
