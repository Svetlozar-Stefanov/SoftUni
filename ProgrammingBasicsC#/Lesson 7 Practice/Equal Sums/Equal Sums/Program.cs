using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstN = Console.ReadLine();
            var secondN = Console.ReadLine();
            int oddSum = 0;
            int evenSum = 0;


            for (int i = int.Parse(firstN); i <= int.Parse(secondN); i++)
            {
                firstN = i.ToString();

                oddSum = (int)Char.GetNumericValue(firstN[0]) + (int)Char.GetNumericValue(firstN[2]) + (int)Char.GetNumericValue(firstN[4]);
                evenSum = (int)Char.GetNumericValue(firstN[1]) + (int)Char.GetNumericValue(firstN[3]) + (int)Char.GetNumericValue(firstN[5]);

                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
