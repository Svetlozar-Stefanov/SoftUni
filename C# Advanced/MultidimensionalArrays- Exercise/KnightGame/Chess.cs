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
                            int jump = 0;
                            for (int i = 2; i <= 3; i++)
                            {
                                if (row + i >= 0 && row + i < matrix.GetLength(0))
                                {
                                    if (col + i - jump >= 0 && col + i - jump < matrix.GetLength(1))
                                    {
                                        if (matrix[row + i, col + i - jump] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                    if (col - i - jump >= 0 && col - i - jump < matrix.GetLength(1))
                                    {
                                        if (matrix[row + i, col - i - jump] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                }
                                if (row - i >= 0 && row - i < matrix.GetLength(0))
                                {
                                    if (col + i - jump >= 0 && col + i - jump < matrix.GetLength(1))
                                    {
                                        if (matrix[row - i, col + i - jump] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                    if (col - i - jump >= 0 && col - i - jump < matrix.GetLength(1))
                                    {
                                        if (matrix[row - i, col - i - jump] == 'K')
                                        {
                                            hits++;
                                        }
                                    }
                                }
                                jump += 2;
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
