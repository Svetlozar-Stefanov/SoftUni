using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstMetric = 0;
            double secondMetric = 0;

            double number = double.Parse(Console.ReadLine());
            string firstValue = Console.ReadLine();

            if (firstValue == "m")
            {
                firstMetric = number * 1;
            }

            else if (firstValue == "mm")
            {
                firstMetric = number / 1000;
            }

            else if (firstValue == "cm")
            {
                firstMetric = number / 100;
            }

            else if (firstValue == "mi")
            {
                firstMetric = number / 0.000621371192;
            }

            else if (firstValue == "in")
            {
                firstMetric = number / 39.3700787;
            }

            else if (firstValue == "km")
            {
                firstMetric = number / 0.001;
            }

            else if (firstValue == "ft")
            {
                firstMetric = number / 3.2808399;

            }

            else if (firstValue == "yd")
            {
                firstMetric = number / 1.0936133;
            }

            string secondValue = Console.ReadLine();

            if (secondValue == "m")
            {
                secondMetric = 1;
            }

            else if (secondValue == "mm")
            {
                secondMetric = 1000;

            }

            else if (secondValue == "cm")
            {
                secondMetric = 100;
            }

            else if (secondValue == "mi")
            {
                secondMetric = 0.000621371192;
            }

            else if (secondValue == "in")
            {
                secondMetric = 39.3700787;
            }

            else if (secondValue == "km")
            {
                secondMetric = 0.001;
            }
            else if (secondValue == "ft" )
            {
                secondMetric = 3.2808399;
            }
            else if (secondValue == "yd")
            {
                secondMetric = 1.0936133;
            }

            double Conversion = firstMetric * secondMetric;
            Console.WriteLine($"{Conversion:f8}");
        }
    }
}
