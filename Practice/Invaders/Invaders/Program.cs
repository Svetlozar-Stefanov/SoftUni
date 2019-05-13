using System;
using System.Collections.Generic;
using System.Threading;

namespace Invaders
{
    class Program
    {
        struct Object
        {
            public Object(int x, int y)
            {
                X = x;
                Y = y;
                C = '*';
                Color = ConsoleColor.White;
            }
            public Object(int x, int y, char c)
            {
                X = x;
                Y = y;
                C = c;
                Color = ConsoleColor.White;
            }
            public Object(int x, int y, char c, ConsoleColor color)
            {
                X = x;
                Y = y;
                C = c;
                Color = color;
            }
            public int X;
            public int Y;
            public char C;
            public ConsoleColor Color;
        }

        static int WindowWidth = 100;
        static int WindowHeight = 30;
        static List<Object> Player = new List<Object>();
        static List<Object> PlayerBullets = new List<Object>();
        static List<List<Object>> Invaders = new List<List<Object>>();
        static int TimeOut = 10;
        static int Moves = 0;
        static void Main(string[] args)
        {
            Settings();
            StartUp();
            while (true)
            {
                MovePlayer();
                MoveInvaders();
                MoveBullets();
                Console.Clear();
                DrawPlayer();
                DrawEnemies();
                DrawBullets();

                Thread.Sleep(100);
                TimeOut++;
                if (Moves <= 20)
                {
                    Moves++;
                }
                else
                {
                    Moves = 0;
                }
            }
        }

        private static void MoveBullets()
        {
            List<Object> newPlayerBullets = new List<Object>();
            foreach (var bullet in PlayerBullets)
            {
                int x = bullet.X;
                int y = bullet.Y;
                char c = bullet.C;
                if (y-- > 0)
                {
                    newPlayerBullets.Add(new Object(x, y--, c));
                }
            }
            PlayerBullets.Clear();
            PlayerBullets = newPlayerBullets;
        }

        private static void DrawBullets()
        {
            foreach (var bullet in PlayerBullets)
            {
                DrawAt(bullet.X, bullet.Y, bullet.C,bullet.Color);
            }
        }

        private static void DrawEnemies()
        {
            foreach (var invader in Invaders)
            {
                foreach (var item in invader)
                {
                    DrawAt(item.X, item.Y,'*',ConsoleColor.White);
                }
            }
        }

        private static void DrawPlayer()
        {
            foreach (var item in Player)
            {
                DrawAt(item.X, item.Y, item.C,item.Color);
            }
        }

        private static void DrawAt(int x, int y, char c, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        private static void MovePlayer()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.D && Player[0].X < Console.WindowWidth-3)
                {
                    List<Object> newPlayer = new List<Object>();
                    for (int i = 0; i < Player.Count; i++)
                    {
                        int currentX = Player[i].X;
                        int currentY = Player[i].Y;
                        char currentC = Player[i].C;
                        ConsoleColor color = Player[i].Color;

                        newPlayer.Add(new Object(currentX += 1, currentY, currentC, color));
                    }
                    Player.Clear();
                    Player = newPlayer;
                }
                if (pressedKey.Key == ConsoleKey.A && Player[0].X > 2)
                {
                    List<Object> newPlayer = new List<Object>();
                    for (int i = 0; i < Player.Count; i++)
                    {
                        int currentX = Player[i].X;
                        int currentY = Player[i].Y;
                        char currentC = Player[i].C;
                        ConsoleColor color = Player[i].Color;

                        newPlayer.Add(new Object(currentX -= 1, currentY, currentC,color));
                    }
                    Player.Clear();
                    Player = newPlayer;
                }
                if (pressedKey.Key == ConsoleKey.Spacebar && TimeOut >= 10)
                {
                    int x = Player[0].X;
                    int y = Player[0].Y;
                    PlayerBullets.Add(new Object(x, y--,'*'));
                    TimeOut = 0;
                }
            }
        }

        private static void MoveInvaders()
        {
            if (Moves <= 10)
            {
                List<List<Object>> newInvaders = new List<List<Object>>();
                foreach (var invader in Invaders)
                {
                    List<Object> newInvader = new List<Object>();
                    foreach (var item in invader)
                    {
                        int x = item.X;
                        int y = item.Y;
                        newInvader.Add(new Object(x += 1, y));
                    }
                    newInvaders.Add(newInvader);
                }
                Invaders.Clear();
                Invaders = newInvaders;
            }
            else if (Moves <= 20)
            {
                List<List<Object>> newInvaders = new List<List<Object>>();
                foreach (var invader in Invaders)
                {
                    List<Object> newInvader = new List<Object>();
                    foreach (var item in invader)
                    {
                        int x = item.X;
                        int y = item.Y;
                        newInvader.Add(new Object(x -= 1, y));
                    }
                    newInvaders.Add(newInvader);
                }
                Invaders.Clear();
                Invaders = newInvaders;
            }
            
        }

        private static void StartUp()
        {
            SetPlayer();
            SetInvaders();
        }

        private static void SetInvaders()
        {
            int x = 15;
            int y = 8;
            for (int i = 1; i <= 50; i++)
            {
                List<Object> invader = new List<Object>();
                invader.Add(new Object(x, y));
                for (int J = -1; J < 2; J++)
                {
                    invader.Add(new Object(x + J, y + 1));
                }
                x += 6;
                if (i % 10 == 0)
                {
                    y += 3;
                    x = 15;
                }
                Invaders.Add(invader);
            }
        }

        private static void SetPlayer()
        {
            int initialX = Console.WindowWidth / 2;
            int initialY = Console.WindowHeight - 2;
            Player.Add(new Object(initialX,initialY,'|',ConsoleColor.Green));
            for (int i = -1; i < 2; i++)
            {
                Player.Add(new Object(initialX + i, initialY + 1,'O',ConsoleColor.Green));
            }
        }

        private static void Settings()
        {
            Console.WindowWidth = WindowWidth;
            Console.WindowHeight = WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;
            Console.Title = "Invaders";
        }
    }
}
