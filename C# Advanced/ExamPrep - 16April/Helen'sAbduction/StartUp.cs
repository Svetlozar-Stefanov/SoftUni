using System;

namespace Helen_sAbduction
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            char[][] field = new char[size][];

            int parisRow = int.MaxValue;
            int parisCol = int.MaxValue;
            for (int row = 0; row < size; row++)
            {
                string line = Console.ReadLine();
                field[row] = new char[line.Length];

                for (int col = 0; col < line.Length; col++)
                {
                    field[row][col] = line[col];
                    if (field[row][col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                }
            }

            field[parisRow][parisCol] = '-';

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = input[0];
                int sRow = int.Parse(input[1]);
                int sCol = int.Parse(input[2]);

                field[sRow][sCol] = 'S';

                if (direction == "up" && parisRow - 1 >= 0)
                {
                    parisRow--;
                }
                else if (direction == "down" && parisRow + 1 < size)
                {
                    parisRow++;
                }
                else if (direction == "left" && parisCol - 1 >= 0)
                {
                    parisCol--;
                }
                else if (direction == "right" && parisCol + 1 < size)
                {
                    parisCol++;
                }
                energy--;

                if (field[parisRow][parisCol] == 'H')
                {
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                    field[parisRow][parisCol] = '-';
                    break;
                }

                if (energy <= 0)
                {
                    field[parisRow][parisCol] = 'X';
                    Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                    break;
                }
                if (field[parisRow][parisCol] == 'S')
                {
                    energy -= 2;
                    if (energy <= 0)
                    {
                        field[parisRow][parisCol] = 'X';
                        Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                        break;
                    }
                    else
                    {
                        field[parisRow][parisCol] = '-';
                    }
                }
            }

            PrintMatrix(field);
        }

        private static void PrintMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
