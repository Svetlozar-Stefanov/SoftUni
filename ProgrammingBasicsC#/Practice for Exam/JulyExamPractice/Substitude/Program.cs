using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitude
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int a = x1; a <= 8; a++)
            {
                for (int b = 9; b >= x2; b--)
                {
                    for (int c = y1; c <= 8; c++)
                    {
                        for (int d = 9; d >= y2; d--)
                        {
                            if ((a % 2 == 0 && b % 2 != 0) && (c % 2 == 0 && d % 2 != 0))
                            {
                                if (a == c && b == d)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                    continue;
                                }
                                Console.WriteLine($"{a}{b} - {c}{d}");
                                counter++;
                                if (counter >= 6)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
