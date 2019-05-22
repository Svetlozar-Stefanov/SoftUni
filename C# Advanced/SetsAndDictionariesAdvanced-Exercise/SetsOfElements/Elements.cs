namespace SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Elements
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstSetLength = input[0];
            int secondSetLength = input[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength + secondSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < firstSetLength)
                {
                    firstSet.Add(number);
                }
                else
                {
                    secondSet.Add(number);
                }
            }

            HashSet<int> matches = new HashSet<int>();
            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    matches.Add(item);
                }
            }

            Console.WriteLine(String.Join(" ",matches));
        }
    }
}
