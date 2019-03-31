using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numList.RemoveAll(x => x < 0);

            numList.Reverse();

            if (numList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", numList));
            }
        }
    }
}
