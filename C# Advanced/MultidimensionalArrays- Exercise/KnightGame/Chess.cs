namespace KnightGame
{
    using System;
    public class Chess
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string values = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int count = 0;
            int worstKnight = int.MinValue;
            while (worstKnight != 0)
            {
                worstKnight = int.MinValue;
                int wRow = -1;
                int wCol = -1;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currentSymbol = matrix[row, col];
                        if (currentSymbol == 'K')
                        {
                            int hits = 0;
                            int jump = 2;
                            for (int i = 1; i <= 2; i++)
                            {
                                if (row + i >= 0 && row + i < matrix.GetLength(0))
                                {
                                    if (col + jump >= 0 && col + jump < matrix.GetLength(1))
                                    {
                                        if (matrix[row + i, col + jump] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                    if (col - jump >= 0 && col - jump < matrix.GetLength(1))
                                    {
                                        if (matrix[row + i, col - jump] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                }
                                if (row - i >= 0 && row - i < matrix.GetLength(0))
                                {
                                    if (col + jump >= 0 && col + jump < matrix.GetLength(1))
                                    {
                                        if (matrix[row - i, col + jump] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                    if (col - jump >= 0 && col - jump < matrix.GetLength(1))
                                    {
                                        if (matrix[row - i, col - jump] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                }
                                if (col + i >= 0 && col + i < matrix.GetLength(1))
                                {
                                    if (row + jump >= 0 && row + jump < matrix.GetLength(0))
                                    {
                                        if (matrix[row + jump,col + i] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                    if (row - jump >= 0 && row - jump < matrix.GetLength(0))
                                    {
                                        if (matrix[row - jump, col + i] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                }
                                if (col - i >= 0 && col - i < matrix.GetLength(1))
                                {
                                    if (row + jump >= 0 && row + jump < matrix.GetLength(0))
                                    {
                                        if (matrix[row + jump, col - i] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                    if (row - jump >= 0 && row - jump < matrix.GetLength(0))
                                    {
                                        if (matrix[row - jump, col - i] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                }
                                jump--;
                            }

                            if (worstKnight < hits)
                            {
                                worstKnight = hits;
                                wRow = row;
                                wCol = col;
                            }
                        }
                    }
                }
                if (worstKnight > 0)
                {
                    matrix[wRow, wCol] = 'O';
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
