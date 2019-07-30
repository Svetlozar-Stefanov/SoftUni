using SimpleSnake.Enums;
using SimpleSnake.GameObjects;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SimpleSnake.Core
{
    public class Engine
    {
        private List<Point> pointsOfDirection;
        private Direction direction;
        private Snake snake;
        private Wall wall;
        private double sleepTime;

        public Engine(Wall wall, Snake snake)
        {
            pointsOfDirection = new List<Point>();
            this.snake = snake;
            this.wall = wall;
            sleepTime = 100;
            direction = Direction.Right;
        }

        public void Run()
        {
            CreateDirections();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    GetNextDirection();
                }

                bool isMoving = snake.IsMoving(pointsOfDirection[(int)direction]);

                if (!isMoving)
                {
                    AskForRestart();
                }

                sleepTime -= 0.1;

                Thread.Sleep((int)sleepTime);
            }
        }

        private void AskForRestart()
        {
            int leftX = wall.LeftX + 1;
            int topY = 3;

            Console.SetCursorPosition(leftX, topY);
            Console.Write("Would you like to continue? y/n");

            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(20, 10);
            Console.Write("Game over!");
            Environment.Exit(0);
        }

        private void CreateDirections()
        {
            pointsOfDirection.Add(new Point(1, 0));
            pointsOfDirection.Add(new Point(-1, 0));
            pointsOfDirection.Add(new Point(0, 1));
            pointsOfDirection.Add(new Point(0, -1));
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            if (userInput.Key == ConsoleKey.LeftArrow)
            {
                if (direction != Direction.Right)
                {
                    direction = Direction.Left;
                }
            }
            else if (userInput.Key == ConsoleKey.RightArrow)
            {
                if (direction != Direction.Left)
                {
                    direction = Direction.Right;
                }
            }
            else if (userInput.Key == ConsoleKey.UpArrow)
            {
                if (direction != Direction.Down)
                {
                    direction = Direction.Up;
                }
            }
            else if (userInput.Key == ConsoleKey.DownArrow)
            {
                if (direction != Direction.Up)
                {
                    direction = Direction.Down;
                }
            }

            Console.CursorVisible = false;
        }
    }
}
