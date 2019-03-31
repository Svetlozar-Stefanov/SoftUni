using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int length = num.ToString().Length;

            for (int i = 0; i < length; i++)
            {
                int lastDigit = num % 10;
                char symbol = (char)(lastDigit + 33);
                if (lastDigit == 0)
                {
                    Console.Write("ZERO");
                }
                else
                {
                    for (int col = 0; col < lastDigit; col++)
                    {
                        Console.Write(symbol);
                    }
                }
                num = num/ 10;
                Console.WriteLine();
            }

        }
    }
}
