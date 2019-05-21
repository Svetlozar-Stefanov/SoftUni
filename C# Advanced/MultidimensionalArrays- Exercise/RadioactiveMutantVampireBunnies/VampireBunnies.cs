namespace RadioactiveMutantVampireBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VampireBunnies
    {
        public static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];
            if (rows <= 0 || cols <= 0)
            {
                return;
            }
            char[,] matrix = new char[rows, cols];

            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] values = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (values[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                        continue;
                    }
                    matrix[row, col] = values[col];
                }
            }
            char[] commands = Console.ReadLine()
                .ToCharArray();
            if (commands.Length < 0)
            {
                return;
            }

            bool won = false;
            bool dead = false;
            int moveIndex = 0;
            while (!won && !dead)
            {
                List<int[]> bunniesPosition = new List<int[]>();
                char action = commands[moveIndex];

                if (action == 'U')
                {
                    if (playerRow - 1 >= 0 && playerRow - 1 < matrix.GetLength(0))
                    {
                        playerRow--;
                        if (matrix[playerRow,playerCol] == 'B')
                        {
                            dead = true;
                        }
                        else
                        {
                            matrix[playerRow + 1, playerCol] = '.';
                            matrix[playerRow, playerCol] = 'P';

                        }
                    }
                    else
                    {
                        won = true;
                        matrix[playerRow, playerCol] = '.';
                    }
                }
                if (action == 'D')
                {
                    if (playerRow + 1 >= 0 && playerRow + 1 < matrix.GetLength(0))
                    {
                        playerRow++;
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            dead = true;
                        }
                        else
                        {
                            matrix[playerRow - 1, playerCol] = '.';
                            matrix[playerRow, playerCol] = 'P';

                        }
                    }
                    else
                    {
                        won = true;
                        matrix[playerRow, playerCol] = '.';
                    }
                }
                if (action == 'R')
                {
                    if (playerCol + 1 >= 0 && playerCol + 1 < matrix.GetLength(1))
                    {
                        playerCol++;
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            dead = true;
                        }
                        else
                        {
                            matrix[playerRow, playerCol - 1] = '.';
                            matrix[playerRow, playerCol] = 'P';

                        }
                    }
                    else
                    {
                        won = true;
                        matrix[playerRow, playerCol] = '.';
                    }
                }
                if (action == 'L')
                {
                    if (playerCol - 1 >= 0 && playerCol - 1 < matrix.GetLength(1))
                    {
                        playerCol--;
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            dead = true;
                        }
                        else
                        {
                            matrix[playerRow, playerCol + 1] = '.';
                            matrix[playerRow, playerCol] = 'P';
                        }
                    }
                    else
                    {
                        won = true;
                        matrix[playerRow, playerCol] = '.';
                    }
                }
                moveIndex++;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row,col] == 'B')
                        {
                            int[] positions = new int[2];
                            positions[0] = row;
                            positions[1] = col;
                            bunniesPosition.Add(positions);
                        }
                    }
                }

                for (int i = 0; i < bunniesPosition.Count; i++)
                {
                    int row = bunniesPosition[i][0];
                    int col = bunniesPosition[i][1];
                    for (int j = -1; j <= 1; j++)
                    {
                        if (row + j >= 0 && row + j < matrix.GetLength(0))
                        {
                            if (playerRow == row + j && playerCol == col && !won)
                            {
                                dead = true;
                            }
                            matrix[row + j, col] = 'B';
                        }
                        if (col + j >= 0 && col + j < matrix.GetLength(1))
                        {
                            if (playerRow == row && playerCol == col + j && !won)
                            {
                                dead = true;
                            }
                            matrix[row, col + j] = 'B';
                        }
                    }
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

            if (won)
            {
                Console.Write($"won: ");
                Console.Write($"{playerRow} {playerCol}\n");
            }
            if (dead)
            {
                Console.Write("dead: ");
                Console.Write($"{playerRow} {playerCol}\n");
            }
        }
    }
}
