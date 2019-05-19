using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthases
{
    class Balance
    {
        static void Main(string[] args)
        {
            char[] parenthases = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            char[] oppenings = { '(', '{', '[' };

            bool balanced = true;
            foreach (var item in parenthases)
            {
                if (oppenings.Contains(item))
                {
                    stack.Push(item);
                }
                else
                {
                    char oppening = stack.Pop();
                    if (item == ')' && stack.Pop() != '(')
                    {
                        balanced = false;
                        break;
                    }
                    if (item == '}' && stack.Pop() != '{')
                    {
                        balanced = false;
                        break;
                    }
                    if (item == ']' && stack.Pop() != '[')
                    {
                        balanced = false;
                        break;
                    }
                }
            }
            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
