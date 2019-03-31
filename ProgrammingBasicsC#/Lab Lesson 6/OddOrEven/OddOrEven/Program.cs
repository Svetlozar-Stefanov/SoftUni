using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    double num1 = double.Parse(Console.ReadLine());
                    evenSum += num1;
                    if (num1 > evenMax)
                    {
                        evenMax = num1;
                    }
                    if (num1 < evenMin)
                    {
                        evenMin = num1;
                    }
                  
                }
                else
                {
                    double num2 = double.Parse(Console.ReadLine());
                    oddSum += num2;
                    if (num2 > oddMax)
                    {
                        oddMax = num2;
                    }
                    if (num2 < oddMin)
                    {
                        oddMin = num2;
                    }
                }
            }

            if (evenSum == 0)
            {
                Console.WriteLine($"OddSum={oddSum}");
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
                Console.WriteLine($"EvenSum={evenSum}");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            if (oddSum == 0)
            {
                Console.WriteLine($"OddSum={oddSum}");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine($"EvenSum={evenSum}");
                Console.WriteLine($"EvenMin={evenMin}");
                Console.WriteLine($"EvenMax={evenMax}");
            }
            if (oddSum ==0 && evenSum == 0)
            {
                Console.WriteLine($"OddSum={oddSum}");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine($"EvenSum={evenSum}");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }

            Console.WriteLine($"OddSum={oddSum}");
            Console.WriteLine($"OddMin={oddMin}");
            Console.WriteLine($"OddMax={oddMax}");
            Console.WriteLine($"EvenSum={evenSum}");
            Console.WriteLine($"EvenMin={evenMin}");
            Console.WriteLine($"EvenMax={evenMax}");

        }
    }
}
