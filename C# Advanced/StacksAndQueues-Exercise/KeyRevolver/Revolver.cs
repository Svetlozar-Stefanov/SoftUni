using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Revolver
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] initialBullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> bullets = new Stack<int>(initialBullets);
            int[] initialLocks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> locks = new Queue<int>(initialLocks);
            int intelValue = int.Parse(Console.ReadLine());

            int barrel = gunBarrelSize;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                if (barrel > 0)
                {
                    int currentBullet = bullets.Pop();
                    int currentLock = locks.Peek();

                    if (currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");
                        locks.Dequeue();
                        barrel--;
                        intelValue -= bulletPrice;
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                        barrel--;
                        intelValue -= bulletPrice;
                    }
                    if (barrel <= 0)
                    {
                        if (bullets.Count > 0)
                        {
                            Console.WriteLine("Reloading!");
                            barrel = gunBarrelSize;
                        }
                    }
                }
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelValue}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
