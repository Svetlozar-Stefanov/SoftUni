using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstX1 = double.Parse(Console.ReadLine());
            double firstY1 = double.Parse(Console.ReadLine());
            double firstX2 = double.Parse(Console.ReadLine());
            double firstY2 = double.Parse(Console.ReadLine());
            double length1 = GetLength(firstX1, firstY1, firstX2, firstY2);

            double secondX1 = double.Parse(Console.ReadLine());
            double secondY1 = double.Parse(Console.ReadLine());
            double secondX2 = double.Parse(Console.ReadLine());
            double secondY2 = double.Parse(Console.ReadLine());
            double length2 = GetLength(secondX1, secondY1, secondX2, secondY2);

            if (length1 >= length2)
            {
                PrintPoints(firstX1, firstY1, firstX2, firstY2);
            }
            else
            {
                PrintPoints(secondX1, secondY1, secondX2, secondY2);
            }
        }

        private static void PrintPoints(double X1, double Y1, double X2, double Y2)
        {
            if (Math.Sqrt(X1 * X1 + Y1 * Y1) <= Math.Sqrt(X2 * X2 + Y2 * Y2))
            {
                Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
            }
            else
            {
                Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
            }
        }

        private static double GetLength(double X1, double Y1, double X2, double Y2)
        {
            double length =Math.Sqrt((Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2)));
            return length;
        }
    }
}
