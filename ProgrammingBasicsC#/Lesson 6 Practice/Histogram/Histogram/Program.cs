using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1Counter = 0;
            double p2Counter = 0;
            double p3Counter = 0;
            double p4Counter = 0;
            double p5Counter = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1Counter++;
                }
                else if (num >= 200 && num < 400)
                {
                    p2Counter++;
                }
                else if (num >= 400 && num < 600)
                {
                    p3Counter++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4Counter++;
                }
                else if (num >= 800)
                {
                    p5Counter++;
                }
            }
            double p1 = p1Counter / n * 100;
            double p2 = p2Counter / n * 100;
            double p3 = p3Counter / n * 100;
            double p4 = p4Counter / n * 100;
            double p5 = p5Counter / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
