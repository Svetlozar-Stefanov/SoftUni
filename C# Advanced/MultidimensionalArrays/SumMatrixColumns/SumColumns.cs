
namespace SumMatrixColumns
{
    using System;
    using System.Linq;

    public class SumColumns
    {
        public static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] values = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
