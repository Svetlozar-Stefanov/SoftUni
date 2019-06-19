using System;

namespace TronRacer
{
    public class StartUp
    {
        struct Player
        {
            public int Row { get; set; }
            public int Col { get; set; }
        }
        public static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize,matrixSize];

            Player firstPlayer = new Player();
            Player secondPlayer = new Player();

            for (int row = 0; row < matrixSize; row++)
            {
                string rowInfo = Console.ReadLine();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowInfo[col];
                    if (matrix[row, col] == 'f')
                    {
                        firstPlayer.Row = row;
                        firstPlayer.Col = col;
                    }
                    if (matrix[row, col] == 's')
                    {
                        secondPlayer.Row = row;
                        secondPlayer.Col = col;
                    }
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstPlayerMove = commands[0];
                string secondPlayerMove = commands[1];

                int[] directions1 = MoveBy(firstPlayerMove);

                firstPlayer.Row += directions1[0];
                firstPlayer.Row = ChekRow(firstPlayer.Row,matrix.GetLength(0));

                firstPlayer.Col += directions1[1];
                firstPlayer.Col = CheckCol(firstPlayer.Col, matrix.GetLength(1));

                if (matrix[firstPlayer.Row,firstPlayer.Col] != 's')
                {
                    matrix[firstPlayer.Row, firstPlayer.Col] = 'f';
                }
                else if (matrix[firstPlayer.Row, firstPlayer.Col] == 's')
                {
                    matrix[firstPlayer.Row, firstPlayer.Col] = 'x';
                    break;
                }

                int[] directions2 = MoveBy(secondPlayerMove);
                secondPlayer.Row += directions2[0];
                secondPlayer.Row = ChekRow(secondPlayer.Row, matrix.GetLength(0));

                secondPlayer.Col += directions2[1];
                secondPlayer.Col = CheckCol(secondPlayer.Col, matrix.GetLength(1));

                if (matrix[secondPlayer.Row, secondPlayer.Col] != 'f')
                {
                    matrix[secondPlayer.Row, secondPlayer.Col] = 's';
                }
                else if (matrix[secondPlayer.Row, secondPlayer.Col] == 'f')
                {
                    matrix[secondPlayer.Row, secondPlayer.Col] = 'x';
                    break;
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
        }

        private static int CheckCol(int col, int size)
        {
            if (col >= size)
            {
                return 0;
            }
            if (col < 0)
            {
                return size - 1;
            }
            return col;
        }

        private static int ChekRow(int row, int size)
        {
            if (row >= size)
            {
                return 0;
            }
            if (row < 0)
            {
                return size - 1;
            }
            return row;
        }

        private static int[] MoveBy(string playerMove)
        {
            if (playerMove == "right")
            {
                return new int[] { 0, 1 };
            }
            if (playerMove == "left")
            {
                return new int[] { 0, -1 };
            }
            if (playerMove == "up")
            {
                return new int[] { -1, 0 };
            }
            if (playerMove == "down")
            {
                return new int[] { 1, 0 };
            }
            return new int[] { 0, 0 };
        }
    }
}
