using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string square = "square";
            string rectangle = "rectangle";
            string circle = "circle";
            string triangle = "triangle";

            string choosenFigure = Console.ReadLine();

            if (choosenFigure == square)
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine($"{area:f3}");

            }
            else if (choosenFigure == rectangle)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double area = a * b;
                Console.WriteLine($"{area:f3}");
            }
            else if (choosenFigure == circle)
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(r, 2);
                Console.WriteLine($"{area:f3}");
            }
            else if (choosenFigure == triangle)
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (a * h) / 2;
                Console.WriteLine($"{area:f3}");
            }


        }
    }
}
