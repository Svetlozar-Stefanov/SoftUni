using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int passwordCounter = 0;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            char A = '#';
            char B = '@';

            for (int x = 1; x <= num1; x++)
            {
                for (int y = 1; y <= num2; y++)
                {
                    if (passwordCounter >= max)
                    {
                        return;
                    }
                    else
                    {
                        Console.Write($"{A}{B}{x}{y}{B}{A}|");
                        A++;
                        B++;
                        passwordCounter++;
                    }
                    if (A > 55)
                    {
                        A = '#';
                    }
                    if (B > 96)
                    {
                        B = '@';
                    }
                }
            }

        }

    }
}
