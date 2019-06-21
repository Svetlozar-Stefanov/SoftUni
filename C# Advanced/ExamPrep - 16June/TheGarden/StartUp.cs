using System;
using System.Linq;

namespace TheGarden
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] garden = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                char[] row = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                garden[i] = new char[row.Length];
                for (int j = 0; j < row.Length; j++)
                {
                    garden[i][j] = row[j];
                }
            }

            int carrots = 0;
            int potatoes = 0;
            int lettuce = 0;
            int harmed = 0;

            string initialInput = Console.ReadLine();

            while (initialInput.ToLower() != "end of harvest")
            {
                string[] input = initialInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                if (command.ToLower() == "harvest")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    if (row >= 0 && row < garden.Length &&
                        col >= 0 && col < garden[row].Length)
                    {
                        if (garden[row][col] == 'L')
                        {
                            lettuce++;
                        }
                        else if (garden[row][col] == 'P')
                        {
                            potatoes++;
                        }
                        else if (garden[row][col] == 'C')
                        {
                            carrots++;
                        }
                        garden[row][col] = ' ';
                    }
                }

                if (command.ToLower() == "mole")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    string direction = input[3];

                    int addRow = 0;
                    int addCol = 0;

                    if (direction.ToLower() == "up")
                    {
                        addRow = -2;
                    }
                    else if (direction.ToLower() == "down")
                    {
                        addRow = 2;
                    }
                    else if (direction.ToLower() == "left")
                    {
                        addCol = -2;
                    }
                    else if (direction.ToLower() == "right")
                    {
                        addCol = 2;
                    }

                    while (row >= 0 && row < garden.Length &&
                        col >= 0 && col < garden[row].Length)
                    {
                        if (garden[row][col] == 'L' ||
                            garden[row][col] == 'C' ||
                            garden[row][col] == 'P')
                        {
                            garden[row][col] = ' ';
                            harmed++;
                        }
                        row += addRow;
                        col += addCol;
                    }
                }

                initialInput = Console.ReadLine();
            }

            for (int i = 0; i < garden.Length; i++)
            {
                string line = "";
                for (int j = 0; j < garden[i].Length; j++)
                {
                    line += garden[i][j] + " ";
                }
                Console.WriteLine(line.TrimEnd());
            }

            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatoes}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmed}");
        }
    }
}
