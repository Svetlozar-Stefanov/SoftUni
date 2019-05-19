namespace _2x2SquareInMatrix
{
    using System;
    using System.Linq;

    public class SquareMatrix
    {
        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] symbols = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < symbols.Length && symbols.Length <= matrix.GetLength(1); col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            int count = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row,col] == matrix[row,col+1] 
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
