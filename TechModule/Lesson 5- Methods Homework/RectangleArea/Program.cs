using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = GetArea(width, height);
            Console.WriteLine(rectangleArea);
        }

        private static double GetArea(double width, double height)
        {
            return width * height;
        }
    }
}
