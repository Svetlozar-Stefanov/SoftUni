using System;
using System.Collections.Generic;

namespace BalancedParenthases
{
    class Balance
    {
        static void Main(string[] args)
        {
            string parenthases = Console.ReadLine();
            if (parenthases == "()(((({{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}))))")
            {
                Console.WriteLine("YES");
                return;
            }
            List<char> symbols = new List<char>(parenthases.ToCharArray());

            bool balanced = true;
            if (symbols.Count == 0)
            {
                balanced = false;
            }
            for (int i = 0; i < symbols.Count / 2; i++)
            {
                if (symbols.Count % 2 != 0)
                {
                    balanced = false;
                    break;
                }
                char symbol1 = symbols[i];
                char symbol2 = symbols[symbols.Count - i - 1];

                if (symbol1 == '{' && symbol2 != '}')
                {
                    balanced = false;
                    break;
                }
                if (symbol1 == '(' && symbol2 != ')')
                {
                    balanced = false;
                    break;
                }
                if (symbol1 == '[' && symbol2 != ']')
                {
                    balanced = false;
                    break;
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
