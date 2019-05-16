using System;
using System.Collections.Generic;

namespace TruckTour
{
    class Tour
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            List<int> initialPositions = new List<int>();
            List<int> circle = new List<int>();

            int tank = 0;

            for (int i = 0; i < pumpsCount; i++)
            {
                string[] pump = Console.ReadLine()
                    .Split(" ");
                int petrol = int.Parse(pump[0]);
                int road = int.Parse(pump[1]);
                int value = petrol - road;

                initialPositions.Add(value);
                circle.Add(value);
            }

            bool rightPath = false;
            while (!rightPath)
            {
                rightPath = true;
                for (int i = 0; i < circle.Count; i++)
                {
                    tank += circle[i];
                    if (tank < 0)
                    {
                        rightPath = false;
                        int firstElement = circle[0];
                        circle.RemoveAt(0);
                        circle.Add(firstElement);
                        tank = 0;
                        break;
                    }
                }
            }

            int index = initialPositions.IndexOf(circle[0]);
            Console.WriteLine(index);
        }
    }
}
