using System;
using System.Collections.Generic;

namespace HotPotatoe
{
    class SamoPotatosi
    {
        static void Main(string[] args)
        {
            string[] fighters = Console.ReadLine()
                .Split();
            int turns = int.Parse(Console.ReadLine());

            Queue<string> game = new Queue<string>(fighters);

            while (game.Count > 1)
            {
                for (int i = 1; i < turns; i++)
                {
                    string currentContendor = game.Dequeue();
                    game.Enqueue(currentContendor);
                }
                Console.WriteLine($"Removed {game.Dequeue()}");
            }

            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
