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

            int elementsToAdd = commands[0];
            int elementsToRemove = commands[1];
            int searchedElement = commands[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < elementsToAdd; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }

            int smallestNum = int.MaxValue;
            if (queue.Contains(searchedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    while (queue.Count > 0)
                    {
                        int currNum = queue.Dequeue();
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
