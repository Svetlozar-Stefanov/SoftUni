using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string action = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                int output = 0;
                if (action == "+")
                {
                    output = firstNum + secondNum;
                }
                else if (action == "-")
                {
                    output = firstNum - secondNum;
                }

                stack.Push(output.ToString());
            }

            Console.WriteLine(stack.Pop());
             
        }
    }
}
