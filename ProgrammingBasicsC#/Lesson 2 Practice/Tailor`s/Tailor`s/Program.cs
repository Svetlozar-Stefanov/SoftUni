using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor_s
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollarTable = 7;
            double dollarSquare = 9;
            double currency = 1.85;

            double tables = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double sTables = tables * (a + 2 * 0.30) * (b + 2 * 0.30);
            double sSqaures = tables * (a / 2) * (a / 2);

            double priceDollars = sTables * dollarTable + sSqaures * dollarSquare;
            double priceBGN = priceDollars * currency;

            Console.WriteLine($"{priceDollars:f2} USD");
            Console.WriteLine($"{priceBGN:f2} BGN");

        }
    }
}
