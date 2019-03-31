using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());
            PrintTriangle(triangleSize);
        }

        static void PrintTriangle(int size)
        {
            PrintUpperPart(size);
            PrintLowerPart(size - 1);
        }

        private static void PrintLowerPart(int size)
        {
            for (int i = size; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        private static void PrintUpperPart(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
