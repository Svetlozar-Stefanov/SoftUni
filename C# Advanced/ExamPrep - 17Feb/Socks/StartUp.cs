using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] left = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] right = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> leftSocks = new Stack<int>(left);
            Queue<int> rightSocks = new Queue<int>(right);

            Queue<int> pairs = new Queue<int>();
            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int lastGivenLeft = leftSocks.Peek();
                int firstGivenRight = rightSocks.Peek();

                if (lastGivenLeft > firstGivenRight)
                {
                    pairs.Enqueue(leftSocks.Pop() + rightSocks.Dequeue());
                }
                else if (lastGivenLeft < firstGivenRight)
                {
                    leftSocks.Pop();
                }
                else if (lastGivenLeft == firstGivenRight)
                {
                    rightSocks.Dequeue();
                    leftSocks.Pop();
                    leftSocks.Push(lastGivenLeft+ 1);
                }
            }
            Console.WriteLine(pairs.OrderByDescending(s => s).FirstOrDefault());
            Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
