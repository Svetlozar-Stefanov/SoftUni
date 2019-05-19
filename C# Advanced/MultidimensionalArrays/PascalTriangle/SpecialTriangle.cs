namespace PascalTriangle
{
    using System;
    using System.Collections.Generic;

    public class SpecialTriangle
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] triangle = new long[size][];

            for (int row = 0; row < triangle.Length; row++)
            {
                triangle[row] = new long[row + 1];
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    triangle[row][col] = 1;
                }
            }

            for (int row = 2; row < triangle.Length; row++)
            {
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    if (col > 0 && col < triangle[row].Length - 1)
                    {
                        long currentValue = triangle[row - 1][col - 1] + triangle[row - 1][col];
                        triangle[row][col] = currentValue;
                    }
                }
            }

            for (int row = 0; row < triangle.Length; row++)
            {
                int freeSpace = size - triangle[row].Length;
                string whitespace = new string(' ',freeSpace / 2);
                List<long> side = new List<long>();
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    side.Add(triangle[row][col]);
                }
                Console.WriteLine($"{whitespace}{String.Join(" ",side)}{whitespace}");
            }
        }
    }
}
