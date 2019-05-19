using System;
using System.Linq;

namespace SumMatrixElements
{
    class SumElements
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);

            int[,] matrix = new int[rows, cols];

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] values = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                    sum += values[col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
