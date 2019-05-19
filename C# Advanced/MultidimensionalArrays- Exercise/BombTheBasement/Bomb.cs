namespace BombTheBasement
{
    using System;
    using System.Linq;

    public class Bomb
    {
        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];
            if (rows > 0 && cols > 0)
            {
                int[,] matrix = new int[rows, cols];

                int[] parameters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int bRow = parameters[0];
                int bCol = parameters[1];
                int radius = parameters[2];

                if (bRow >= 0 && bRow < rows && bCol >= 0 && bCol < cols && radius > 0)
                {
                    if (radius > 0)
                    {
                        int expansion = 0;
                        for (int row = bRow - radius; row <= bRow + radius; row++)
                        {
                            for (int col = bCol - radius; col <= bCol + radius; col++)
                            {
                                if (col >= bCol - expansion && col <= bCol + expansion)
                                {
                                    if (row >= 0 && row < matrix.GetLength(0) 
                                        && col >= 0 && col < matrix.GetLength(1))
                                    {
                                        matrix[row, col] = 1;
                                    }
                                }
                            }
                            if (row < bRow)
                            {
                                expansion++;
                            }
                            else
                            {
                                expansion--;
                            }
                        }

                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            int exit = 0;
                            while (matrix[0, col] != 1)
                            {
                                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                                {
                                    matrix[row, col] = matrix[row + 1, col];
                                }
                                matrix[matrix.GetLength(0) - 1, col] = 0;
                                if (exit > matrix.GetLength(1))
                                {
                                    break;
                                }
                                exit++;
                            }
                        }

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
                
        }
            
    }
}
