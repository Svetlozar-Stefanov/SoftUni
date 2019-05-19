namespace PrimaryDiagonal
{
    using System;
    using System.Linq;

    public class DiaonalSum
    {
        public static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colsValue = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colsValue[col];
                    if (row == col)
                    {
                        sum += colsValue[col];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
