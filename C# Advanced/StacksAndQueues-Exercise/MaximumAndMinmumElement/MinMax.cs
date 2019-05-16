using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinmumElement
{
    class MinMax
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] query = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int command = query[0];
                if (command == 1)
                {
                    int element = query[1];
                    stack.Push(element);
                }
                if (command == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                if (command == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                if (command == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
