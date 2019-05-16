using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class BasicOperations
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementsToPush = commands[0];
            int elementsToPop = commands[1];
            int searchedElement = commands[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            int smallestNum = int.MaxValue;
            if (stack.Contains(searchedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        int currNum = stack.Pop();
                        if (currNum < smallestNum)
                        {
                            smallestNum = currNum;
                        }
                    }
                    Console.WriteLine(smallestNum);
                }
            }
        }
    }
}
