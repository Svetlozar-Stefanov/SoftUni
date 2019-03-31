using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveRepeatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> listFromInput = input.ToList();

            for (int i = 0; i < listFromInput.Count; i++)
            {
                char currentSymbol = listFromInput[i];
                int j = i;
                while (j + 1 < listFromInput.Count && listFromInput[j + 1] == currentSymbol)
                {
                    listFromInput.RemoveAt(j+1);
                }
            }

            Console.WriteLine(String.Join("", listFromInput));
        }
    }
}
