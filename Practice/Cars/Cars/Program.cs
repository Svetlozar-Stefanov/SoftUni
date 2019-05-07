using System;
using System.Threading;

namespace Cars
{
    class Program
    {
        public struct Car
        {
            public Car(int x, int y, char c, ConsoleColor color)
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
        static Car player = new Car(2, Console.WindowHeight - 1, '@', ConsoleColor.Red);
        static int playField = 5;
        static void Main(string[] args)
        {
            Settings();
            while (true)
            {
                MovePlayer();
                Console.Clear();
                DrawAt(player.x, player.y, player.c, player.color);
                Thread.Sleep(50);
            }
        }

        private static void MovePlayer()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.D)
                {
                    if (player.x < playField)
                    {
                        player.x++;
                    }
                }
                if (key.Key == ConsoleKey.A)
                {
                    if (player.x > 0)
                    {
                        player.x--;
                    }
                }
                if (key.Key == ConsoleKey.W)
                {
                    if (player.y > 0)
                    {
                        player.y--;
                    }
                }
                if (key.Key == ConsoleKey.S)
                {
                    if (player.y < Console.WindowHeight-1)
                    {
                        player.y++;
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
            Console.BufferWidth = Console.WindowWidth = 20;
            Console.BufferHeight = Console.WindowHeight = 20;
        }
    }
}
