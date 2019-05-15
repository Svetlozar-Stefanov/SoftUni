using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class PrintEven
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> evenNum = new Queue<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNum.Enqueue(item);
                }
            }
            Console.WriteLine(String.Join(", ",evenNum));
        }
    }
}
