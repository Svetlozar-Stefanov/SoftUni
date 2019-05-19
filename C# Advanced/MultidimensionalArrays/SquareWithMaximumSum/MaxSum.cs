namespace SquareWithMaximumSum
{
    using System;
    using System.Linq;

    public class MaxSum
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

            int biggestSum = int.MinValue;
            int indexR = -1;
            int indexC = -1;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int currentSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row+ 1, col]
                        + matrix[row+1, col+1];

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        indexR = row;
                        indexC = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[indexR,indexC]} {matrix[indexR,indexC+1]}\n" +
                $"{matrix[indexR+1, indexC]} {matrix[indexR+1, indexC+1]}\n" +
                $"{biggestSum}");
        }
    }
}
