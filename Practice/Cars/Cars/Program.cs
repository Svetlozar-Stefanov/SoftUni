using System;
using System.Collections.Generic;
using System.Threading;

namespace Cars
{
    class Program
    {
        public struct Object
        {
            public Object(int x, int y, char c, ConsoleColor color)
            {
                this.x = x;
                this.y = y;
                this.c = c;
                this.color = color;
            }
            public int x;
            public int y;
            public char c;
            public ConsoleColor color;
        }
        static Object Player = new Object(2, Console.WindowHeight - 1, '^', ConsoleColor.Blue);
        static public List<Object> Objects = new List<Object>();
        static Random Random = new Random();
        static int PlayField = 10;
        static int Lives = 5;
        static int speed = 100;
        static int deley = 0;
        static int Score = 0;
        static void Main(string[] args)
        {
            Settings();
            while (true)
            {
                int chance = Random.Next(0, 101);
                bool hitted = false;
                if (deley % 2 == 0)
                {
                    if (chance < 5)
                    {
                        Object healthBonus = new Object(Random.Next(0, PlayField + 1), 0, 'H', ConsoleColor.Red);
                        Objects.Add(healthBonus);
                    }
                    else if (chance < 10)
                    {
                        Object slowDown = new Object(Random.Next(0, PlayField + 1), 0, 'S', ConsoleColor.Green);
                        Objects.Add(slowDown);
                    }
                    else
                    {
                        Object enemy = new Object(Random.Next(0, PlayField + 1), 0, 'V', ConsoleColor.Yellow);
                        Objects.Add(enemy);
                    }
                }
                MovePlayer();
                List<Object> newList = new List<Object>();
                for (int i = 0; i < Objects.Count; i++)
                {
                    Object oldObject = Objects[i];
                    Object newObject = oldObject;
                    newObject.y++;
                    if (newObject.y == Player.y && newObject.x == Player.x)
                    {
                        if (newObject.c == 'V')
                        {
                            hitted = true;
                            speed+=20;
                            Lives--;
                            if (Lives <= 0)
                            {
                                GameOver();
                            }
                        }
                        if (newObject.c == 'S')
                        {
                            speed-=50;
                            Score += 10;
                            continue;
                        }
                        if (newObject.c == 'H')
                        {
                            Lives++;
                            Score += 20;
                            continue;
                        }
                    }
                    if (newObject.y < Console.WindowHeight)
                    {
                        newList.Add(newObject);
                    }
                    else
                    {
                        Score += 10;
                    }
                }
                Objects = newList;
                Console.Clear();
                if (hitted)
                {
                    Objects.Clear();
                    DrawAt(Player.x, Player.y, 'X', ConsoleColor.Red);
                }
                else
                {
                    DrawAt(Player.x, Player.y, Player.c, Player.color);
                }
                foreach (var car in Objects)
                {
                    DrawAt(car.x, car.y, car.c, car.color);
                }
                PrintInfo();
                if (speed <= 230)
                {
                    Thread.Sleep(300 - speed);
                }
                else
                {
                    Thread.Sleep(70);
                }
                speed++;
                deley++;
                Score ++;
            }
        }

        private static void GameOver()
        {
            DrawAt(PlayField + 5, 10, "Game Over", ConsoleColor.DarkRed);
            DrawAt(PlayField + 5, 12, "Press [enter] to exit", ConsoleColor.DarkRed);
            Console.ReadLine();
            Environment.Exit(0);

        }

        private static void PrintInfo()
        {
            DrawAt(PlayField + 5, 4, $"Lives: {Lives}", ConsoleColor.White);
            DrawAt(PlayField + 5, 5, $"Score: {Score}", ConsoleColor.White);
            DrawAt(PlayField + 5, 6, $"Speed: {speed}", ConsoleColor.White);

        }

        private static void DrawAt(int x, int y, string str, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        private static void MovePlayer()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.D)
                {
                    if (Player.x < PlayField)
                    {
                        Player.x++;
                    }
                }
                if (key.Key == ConsoleKey.A)
                {
                    if (Player.x > 0)
                    {
                        Player.x--;
                    }
                }
                if (key.Key == ConsoleKey.W)
                {
                    if (Player.y > 0)
                    {
                        Player.y--;
                    }
                }
                if (key.Key == ConsoleKey.S)
                {
                    if (Player.y < Console.WindowHeight-1)
                    {
                        Player.y++;
                    }
                }
            }
        }

        private static void DrawAt(int x,int y, char c, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        private static void Settings()
        {
            Console.CursorVisible = false;
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.BufferHeight = Console.WindowHeight = 20;
        }
    }
}
