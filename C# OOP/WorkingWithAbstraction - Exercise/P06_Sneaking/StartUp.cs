namespace P06_Sneaking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static char[][] room;
        static List<Guard> guards = new List<Guard>();
        static Position sam = new Position();
        struct Guard
        {
            public Guard(int row, int col, char look)
            {
                Row = row;
                Col = col;
                Look = look;
            }
            public int Row { get; set; }
            public int Col { get; set; }
            public char Look { get; set; }
        }

        struct Position
        {
            public Position(int row = -1, int col = -1)
            {
                Row = row;
                Col = col;
            }
            public int Row { get; set; }
            public int Col { get; set; }
        }
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            room = new char[rows][];
            FillMatrix(rows);

            var moves = Console.ReadLine().ToCharArray();

            for (int i = 0; i < moves.Length; i++)
            {
                MoveGuards();
                Fight();
                MovePlayer(moves, i);
            }
        }

        private static void MovePlayer(char[] moves, int i)
        {
            room[sam.Row][sam.Col] = '.';
            switch (moves[i])
            {
                case 'U':
                    sam.Row--;
                    break;
                case 'D':
                    sam.Row++;
                    break;
                case 'L':
                    sam.Col--;
                    break;
                case 'R':
                    sam.Col++;
                    break;
                default:
                    break;
            }
            room[sam.Row][sam.Col] = 'S';
            if (guards.Contains(guards.Where(g => g.Row == sam.Row && g.Col == sam.Col).FirstOrDefault()))
            {
                guards.Remove(guards.Where(g => g.Row == sam.Row && g.Col == sam.Col).FirstOrDefault());
            }

            Position enemy = new Position(-1, -1);
            for (int col = 0; col < room[sam.Row].Length; col++)
            {
                if (enemy.Row != -1 && enemy.Col != -1)
                {
                    break;
                }
                if (room[sam.Row][col] != '.' && room[sam.Row][col] != 'S')
                {
                    enemy.Row = sam.Row;
                    enemy.Col = col;
                }
            }
            if (enemy.Row != -1
                && enemy.Col != -1
                &&room[enemy.Row][enemy.Col] == 'N' 
                && sam.Row == enemy.Row)
            {
                room[enemy.Row][enemy.Col] = 'X';
                Console.WriteLine("Nikoladze killed!");
                PrintMatrix();
            }
        }

        private static void Fight()
        {
            Position enemy = new Position(-1,-1);
            for (int col = 0; col < room[sam.Row].Length; col++)
            {
                if (enemy.Row != -1 && enemy.Col != -1)
                {
                    break;
                }
                if (room[sam.Row][col] != '.' && room[sam.Row][col] != 'S')
                {
                    enemy.Row = sam.Row;
                    enemy.Col = col;
                }
            }
            if (enemy.Row == -1 && enemy.Col == -1)
            {
                return;
            }
            if (sam.Col < enemy.Col
                && room[enemy.Row][enemy.Col] == 'd'
                && enemy.Row == sam.Row)
            {
                Deaht();
            }
            else if (enemy.Col < sam.Col
                && room[enemy.Row][enemy.Col] == 'b'
                && enemy.Row == sam.Row)
            {
                Deaht();
            }
        }

        private static void Deaht()
        {
            room[sam.Row][sam.Col] = 'X';
            Console.WriteLine($"Sam died at {sam.Row}, {sam.Col}");
            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        private static void MoveGuards()
        {
            for (int guardCount = 0; guardCount < guards.Count; guardCount++)
            {
                Guard guard = guards[guardCount];
                if (guard.Look == 'b')
                {
                    if (guard.Row >= 0
                        && guard.Row < room.Length
                        && guard.Col + 1 >= 0
                        && guard.Col + 1 < room[guard.Row].Length)
                    {
                        room[guard.Row][guard.Col] = '.';
                        room[guard.Row][guard.Col + 1] = 'b';
                        guard.Col++;
                    }
                    else
                    {
                        room[guard.Row][guard.Col] = 'd';
                        guard.Look = 'd';
                    }
                }
                else if (room[guard.Row][guard.Col] == 'd')
                {
                    if (guard.Row >= 0
                        && guard.Row < room.Length
                        && guard.Col - 1 >= 0
                        && guard.Col - 1 < room[guard.Row].Length)
                    {
                        room[guard.Row][guard.Col] = '.';
                        room[guard.Row][guard.Col - 1] = 'd';
                        guard.Col--;
                    }
                    else
                    {
                        room[guard.Row][guard.Col] = 'b';
                        guard.Look = 'b';
                    }
                }
                guards[guardCount] = guard;
            }
        }

        private static void FillMatrix(int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                room[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];
                    if (room[row][col] == 'S')
                    {
                        sam.Row = row;
                        sam.Col = col;
                    }
                    if (room[row][col] == 'b' || room[row][col] == 'd')
                    {
                        guards.Add(new Guard(row, col, room[row][col]));
                    }
                }
            }
        }
    }
}
