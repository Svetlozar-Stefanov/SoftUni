using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPC = int.Parse(Console.ReadLine());

            double ratingSum = 0;
            double totalSales = 0;

            for (int i = 1; i <= numOfPC; i++)
            {
                double num = double.Parse(Console.ReadLine());
                double rating = num % 10;
                double sales = (num - rating) / 10.0;
                ratingSum += rating;

                if (rating == 2)
                {
                    totalSales += sales * 0.00;
                }
                if (rating == 3)
                {
                    totalSales += sales * 0.5;
                }
                if (rating == 4)
                {
                    totalSales += sales * 0.70;
                }
                if (rating == 5)
                {
                    totalSales += sales * 0.85;
                }
                if (rating == 6)
                {
                    totalSales += sales * 1;
                }
            }
            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{(ratingSum / numOfPC):f2}");
        }
    }
}
