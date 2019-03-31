using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <= n; num1++)
            {
                for (int num2 = 1; num2 <= n; num2++)
                {
                    for (int l1 = 97; l1 <= 97 + l - 1; l1++)
                    {
                        for (int l2 = 97; l2 <= 97 + l -1; l2++)
                        {
                            for (int num3 = 1; num3 <= n; num3++)
                            {
                                if (num3 > num2 && num3 > num1)
                                {
                                    Console.Write($"{num1}{num2}{(char)l1}{(char)l2}{num3} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
