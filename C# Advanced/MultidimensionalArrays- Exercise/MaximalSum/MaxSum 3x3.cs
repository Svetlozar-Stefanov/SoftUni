namespace MaximalSum
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class MaxSum
    {
        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            long maxSum = long.MinValue;
            int r = -1;
            int c = -1;
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    long sum = 0;
                    for (int i = row; i <= row + 2; i++)
                    {
                        for (int j = col; j <= col + 2; j++)
                        {
                            sum += matrix[i, j];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        r = row;
                        c = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = r; row <= r + 2; row++)
            {
                for (int col = c; col <= c + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                    Console.WriteLine();
            }
        }
    }
}
