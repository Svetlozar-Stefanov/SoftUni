namespace JaggedArrayModifications
{
    using System;
    using System.Linq;

    public class JaggedModification
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

            string[] input = Console.ReadLine()
                .Split();

            while (input[0].ToLower() != "end")
            {
                string operation = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row < 0 || row >= matrix.GetLength(0)
                    || col < 0 || col >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (operation.ToLower() == "add")
                    {
                        matrix[row, col] += value;
                    }
                    if (operation.ToLower() == "subtract")
                    {
                        matrix[row, col] -= value;
                    }
                }
                input = Console.ReadLine()
                .Split();
            }

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
