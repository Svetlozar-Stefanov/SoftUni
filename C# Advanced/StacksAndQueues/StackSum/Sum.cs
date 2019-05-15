using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Sum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numStack = new Stack<int>(numbers);

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0].ToLower() != "end")
            {
                if (command[0].ToLower() == "add")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        numStack.Push(int.Parse(command[i]));
                    }
                }
                if (command[0].ToLower() == "remove")
                {
                    int removeCount = int.Parse(command[1]);

                    if (removeCount <= numStack.Count)
                    {
                        for (int i = 0; i < removeCount; i++)
                        {
                            numStack.Pop();
                        }
                    }
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine($"Sum: {numStack.Sum()}");
        }
    }
}
