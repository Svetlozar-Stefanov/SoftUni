namespace SnakeMoves
{
    using System;
    using System.Linq;

    public class Snake
    {
        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();

            int index = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (index >= snake.Length)
                    {
                        index = 0;
                    }
                    matrix[row, col] = snake[index];
                    index++;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
