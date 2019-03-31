using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            for (int i = 0; i < listNumbers.Count; i++)
            {
                if (!numbers.ContainsKey(listNumbers[i]))
                {
                    numbers[listNumbers[i]] = 0;
                }
                numbers[listNumbers[i]]++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
