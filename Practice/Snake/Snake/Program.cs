using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
    class Program
    {
        public struct Position
        {
            public Position(int x, int y)
            {
                this.X = x;
                this.Y = y;
                this.C = '0';
            }
            public Position(int x, int y, char c)
            {
                this.X = x;
                this.Y = y;
                this.C = c;
            }
            public int X;
            public int Y;
            public char C;
        }

        static public Queue<Position> SnakeElements = new Queue<Position>();
        static public Position[] Directions = new Position[]
        {
            new Position(1,0), //right
            new Position(-1,0), //left
            new Position(0,1), //down
            new Position(0,-1) // up
        };
        static int Direction = 0;
        static Random Random = new Random();
        static public Position Food = new Position(Random.Next(0, Console.WindowWidth), Random.Next(0, Console.WindowHeight));
        static public List<Position> Obstacles = new List<Position>();
        static int Score = 0;
        static int speed = 10;
        static char symbol = '>';
        static void Main(string[] args)
        {
            SetUp();
            while (true)
            {
                MoveSnake();
                CheckCollision();
                Eat();
                DrawInfo();
                DrawAt(Food.X, Food.Y,'O', ConsoleColor.Red);
                DrawObstacles();
                DrawSnake();
                Thread.Sleep(200 - speed);
            }
        }

        private static void DrawObstacles()
        {
            foreach (var obstacle in Obstacles)
            {
                DrawAt(obstacle.X, obstacle.Y, 'X', ConsoleColor.DarkBlue);
            }
        }

        private static void DrawSnake()
        {
            int count = 0;
            foreach (var position in SnakeElements)
            {
                count++;
                if ((position.X == SnakeElements.Last().X && position.Y == SnakeElements.Last().Y))
                {
                    DrawAt(position.X, position.Y,position.C, ConsoleColor.Green);
                }
                else if (count % 2 != 0)
                {
                    DrawAt(position.X, position.Y,'0', ConsoleColor.Green);
                }
                else
                {
                    DrawAt(position.X, position.Y,'0', ConsoleColor.Yellow);
                }
            }
        }

        private static void DrawInfo()
        {
            string message = $"Score:{Score}";
            Console.SetCursorPosition(Console.WindowWidth - message.Length, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
        }

        private static void CheckCollision()
        {
            Position head = SnakeElements.Last();
            for (int i = 0; i < SnakeElements.Count - 1; i++)
            {
                if (head.X == SnakeElements.ElementAt(i).X && head.Y == SnakeElements.ElementAt(i).Y)
                {
                    GameOver();
                }
            }
            foreach (var obstacle in Obstacles)
            {
                if (head.X == obstacle.X && obstacle.Y == head.Y)
                {
                    GameOver();
                }
            }
            
        }

        private static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string endMessage = "Game Over!!!";
            Console.SetCursorPosition(Console.WindowWidth / 2 - endMessage.Length / 2, Console.WindowHeight / 2);
            Console.Write(endMessage);
            string firstOption = "Press [enter] to replay";
            Console.SetCursorPosition(Console.WindowWidth / 2 - firstOption.Length / 2, Console.WindowHeight / 2 + 1);
            Console.Write(firstOption);
            string secondOption = "Press [esc] to exit";
            Console.SetCursorPosition(Console.WindowWidth / 2 - secondOption.Length / 2, Console.WindowHeight / 2 + 2);
            Console.Write(secondOption);
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                SetUp();
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Environment.Exit(0);
            }
        }

        private static void Eat()
        {
            Position head = SnakeElements.Last();
            if (head.X == Food.X && head.Y == Food.Y)
            {
                Food = new Position(Random.Next(1, Console.WindowWidth-2), Random.Next(1, Console.WindowHeight-2));
                while (SnakeElements.Contains(Food) || Obstacles.Contains(Food))
                {
                    Food = new Position(Random.Next(1, Console.WindowWidth - 2), Random.Next(1, Console.WindowHeight - 2));
                }
                Position obstacle = new Position(Random.Next(1, Console.WindowWidth - 2), Random.Next(1, Console.WindowHeight - 2));
                while (SnakeElements.Contains(obstacle) || Obstacles.Contains(Food))
                {
                    obstacle = new Position(Random.Next(1, Console.WindowWidth - 2), Random.Next(1, Console.WindowHeight - 2));
                }
                Obstacles.Add(obstacle);
                SnakeElements.Enqueue(head);
                Score += 20;
                if (speed <= 150)
                {
                    speed += 10;
                }
            }
        }

        private static void SetUp()
        {
            SnakeElements.Clear();
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;
            Direction = 0;
            Food = new Position(Random.Next(0, Console.WindowWidth), Random.Next(0, Console.WindowHeight));
            Obstacles = new List<Position>();
            Score = 0;
            speed = 10;
            symbol = '>';
            for (int i = 10; i < 20; i++)
            {
                SnakeElements.Enqueue(new Position(i, 15));
            }
        }

        private static void DrawAt(int x, int y, char c, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
            Console.ResetColor();
        }

        private static void MoveSnake()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.W && Direction != 2)
                {
                    Direction = 3;
                    symbol = '^';
                }
                if (key.Key == ConsoleKey.S && Direction != 3)
                {
                    Direction = 2;
                    symbol = 'v';
                }
                if (key.Key == ConsoleKey.A && Direction != 0)
                {
                    Direction = 1;
                    symbol = '<';
                }
                if (key.Key == ConsoleKey.D && Direction != 1)
                {
                    Direction = 0;
                    symbol = '>';
                }
            }
            
            Position head = SnakeElements.Last();
            Position last = SnakeElements.Dequeue();
            DrawAt(last.X, last.Y, ' ',ConsoleColor.Black);
            Position newDirection = Directions[Direction];
            if (head.X <= 1)
            {
                head.X = Console.WindowWidth - 2;
            }
            else if (head.X >= Console.WindowWidth-2)
            {
                head.X = 1;
            }
            else if (head.Y <= 1)
            {
                head.Y = Console.WindowHeight - 2;
            }
            else if (head.Y >= Console.WindowHeight - 2)
            {
                head.Y = 1;
            }
            Position newHead = new Position(head.X + newDirection.X, head.Y + newDirection.Y, symbol);
            SnakeElements.Enqueue(newHead);
        }
    }
}
