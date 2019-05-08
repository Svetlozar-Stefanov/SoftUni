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
            }
            public int X;
            public int Y;
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


        static void Main(string[] args)
        {
            SetUp();
            while (true)
            {
                MoveSnake();
                CheckCollision();
                Eat();
                Console.Clear();
                DrawAt(Food.X, Food.Y,'o', ConsoleColor.Red);
                foreach (var position in SnakeElements)
                {
                    DrawAt(position.X,position.Y,'*', ConsoleColor.Yellow);
                }
                Thread.Sleep(100);
            }
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
        }

        private static void GameOver()
        {
            Console.Clear();
            string endMessage = "Game Over!!!";
            Console.SetCursorPosition(Console.WindowWidth / 2 - endMessage.Length / 2, Console.WindowHeight / 2);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(endMessage);
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Environment.Exit(0);
        }

        private static void Eat()
        {
            Position head = SnakeElements.Last();
            if (head.X == Food.X && head.Y == Food.Y)
            {
                Food = new Position(Random.Next(0, Console.WindowWidth), Random.Next(0, Console.WindowHeight));
                SnakeElements.Enqueue(head);
            }
        }

        private static void SetUp()
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;
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
                }
                if (key.Key == ConsoleKey.S && Direction != 3)
                {
                    Direction = 2;
                }
                if (key.Key == ConsoleKey.A && Direction != 0)
                {
                    Direction = 1;
                }
                if (key.Key == ConsoleKey.D && Direction != 1)
                {
                    Direction = 0;
                }
            }
            
            Position head = SnakeElements.Last();
            SnakeElements.Dequeue();
            Position newDirection = Directions[Direction];
            if (head.X < 1)
            {
                head.X = Console.WindowWidth - 1;
            }
            else if (head.X >= Console.WindowWidth-1)
            {
                head.X = 0;
            }
            else if (head.Y < 1)
            {
                head.Y = Console.WindowHeight - 2;
            }
            else if (head.Y >= Console.WindowHeight - 2)
            {
                head.Y = 0;
            }
            Position newHead = new Position(head.X + newDirection.X, head.Y + newDirection.Y);
            SnakeElements.Enqueue(newHead);
        }
    }
}
