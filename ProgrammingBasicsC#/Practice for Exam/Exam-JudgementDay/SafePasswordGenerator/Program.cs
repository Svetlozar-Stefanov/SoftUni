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

            for (int a = 35; a <= 56; a++)
            {
                if (a >= 55)
                {
                    a = 35;
                }
                for (int b = 64; b <= 97; b++)
                {
                    if (b >= 96)
                    {
                        b = 64;
                    }
                    for (int c = 1; c <= num1; c++)
                    {
                        for (int d = 1; d <= num2; d++)
                        {
                            if (passwordCounter > max)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write($"{a}{b}{c}{d}{a}{b}|");
                                passwordCounter++;
                            }
                        }
                    }
                }
            }

        }
    }
}
