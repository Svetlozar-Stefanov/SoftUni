using System;
using System.Collections.Generic;

namespace ReversedStrings
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var letter in input)
            {
                stack.Push(letter);
            }

            foreach (var letter in stack)
            {
                Console.Write(letter);
            }
        }
    }
}
