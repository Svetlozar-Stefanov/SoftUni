namespace Bombs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Bomb
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] values = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            string input = Console.ReadLine();
            string[] coordinates = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] value = coordinates[i].Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int row = value[0];
                int col = value[1];

                int power = matrix[row, col];
                if (power > 0)
                {
                    for (int r = row - 1; r <= row + 1; r++)
                    {
                        for (int c = col - 1; c <= col + 1; c++)
                        {
                            if (r >= 0 && r < matrix.GetLength(0)
                                && c >= 0 && c < matrix.GetLength(1))
                            {
                                if (matrix[r, c] > 0)
                                {
                                    matrix[r, c] -= power;
                                }
                            }
                        }
                    }
                }
            }

            int sum = 0;
            int count = 0;
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    count++;
                    sum += item;
                }
            }


            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
