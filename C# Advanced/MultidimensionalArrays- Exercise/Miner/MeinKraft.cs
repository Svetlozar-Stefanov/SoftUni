namespace Miner
{
    using System;
    using System.Linq;

    public class MeinKraft
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[size, size];
            int[] start = new int[2];
            int initialCoal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] values = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (values[col] == 's')
                    {
                        start[0] = row;
                        start[1] = col;
                    }
                    if (values[col] == 'c')
                    {
                        initialCoal++;
                    }
                    matrix[row, col] = values[col];
                }
            }

            int pRow = start[0];
            int pCol = start[1];
            int collectedCoal = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i].ToLower() == "left" && pCol - 1 >= 0 && pCol - 1 < matrix.GetLength(1))
                {
                    pCol--;
                }
                if (commands[i].ToLower() == "right" && pCol + 1 >= 0 && pCol + 1 < matrix.GetLength(1))
                {
                    pCol++;
                }
                if (commands[i].ToLower() == "up" && pRow - 1 >= 0 && pRow - 1 < matrix.GetLength(0))
                {
                    pRow--;
                }
                if (commands[i].ToLower() == "down" && pRow + 1 >= 0 && pRow + 1 < matrix.GetLength(0))
                {
                    pRow++;
                }

                if (matrix[pRow,pCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({pRow}, {pCol})");
                    Environment.Exit(0);
                }
                if (matrix[pRow,pCol] == 'c')
                {
                    initialCoal--;
                    collectedCoal++;
                    matrix[pRow, pCol] = '*';
                }
                if (initialCoal == 0)
                {
                    Console.WriteLine($"You collected all coals! ({pRow}, {pCol})");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine($"{initialCoal} coals left. ({pRow}, {pCol})");
        }
    }
}
