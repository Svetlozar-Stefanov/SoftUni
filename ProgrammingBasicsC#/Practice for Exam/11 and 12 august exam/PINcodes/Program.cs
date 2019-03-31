using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int up = int.Parse(Console.ReadLine());
            int mid = int.Parse(Console.ReadLine());
            int down = int.Parse(Console.ReadLine());

            for (int a = 1; a <= up; a++)
            {
                for (int b = 2; b <= mid; b++)
                {
                    for (int c = 1; c <= down; c++)
                    {
                        if ((a % 2 == 0 && c % 2 == 0) && (b == 2 || b == 3 || b == 5 || b == 7))
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }
                    }
                }
            }
        }
    }
}
