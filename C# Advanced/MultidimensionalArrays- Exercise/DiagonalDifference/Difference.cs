namespace DiagonalDifference
{
    using System;
    using System.Linq;

    public class Difference
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int lToRSum = 0;
            int rToLSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] values = Console.ReadLine().
                    Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];

                    if (row == col)
                    {
                        lToRSum += values[col];
                    }
                    if (row + col == size - 1)
                    {
                        rToLSum += values[col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(lToRSum - rToLSum));
        }
    }
}
