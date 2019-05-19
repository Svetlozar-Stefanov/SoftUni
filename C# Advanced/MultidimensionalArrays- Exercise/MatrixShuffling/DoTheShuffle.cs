namespace MatrixShuffling
{
    using System;
    using System.Linq;

    public class DoTheShuffle
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
                string[] values = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0].ToLower() != "end")
            {
                if (input.Length == 5)
                {
                    string command = input[0];
                    int row1 = int.Parse(input[1]);
                    int col1 = int.Parse(input[2]);
                    int row2 = int.Parse(input[3]);
                    int col2 = int.Parse(input[4]);

                    if (command.ToLower() == "swap" 
                        && row1 >= 0 && row1 < matrix.GetLength(0)
                        && col1 >= 0 && col1 < matrix.GetLength(1)
                        && row2 >= 0 && row2 < matrix.GetLength(0)
                        && col2 >= 0 && col2 < matrix.GetLength(1))
                    {
                        string temp = matrix[row2, col2];
                        matrix[row2, col2] = matrix[row1, col1];
                        matrix[row1, col1] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
