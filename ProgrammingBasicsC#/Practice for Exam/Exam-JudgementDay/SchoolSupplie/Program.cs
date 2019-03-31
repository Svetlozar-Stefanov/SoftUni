using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSupplie
{
    class Program
    {
        static void Main(string[] args)
        {
            int penPacks = int.Parse(Console.ReadLine());
            int markersPacks = int.Parse(Console.ReadLine());
            double litres = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double penPrice = penPacks * 5.80;
            double markerPrice = markersPacks * 7.20;
            double litresPrice = litres * 1.20;

            double sum = penPrice + markerPrice + litresPrice;

            double totalSum = sum - (sum * (discount / 100.0));

            Console.WriteLine($"{totalSum:f3}");
        }
    }
}
