using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Crossroad
    {
        static void Main(string[] args)
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> carsInTraffic = new Queue<string>();

            string command = Console.ReadLine();
            int passedCars = 0;
            while (command.ToLower() != "end")
            {
                if (command.ToLower() == "green")
                {
                    int green = durationOfGreenLight;
                    while (green > 0 && carsInTraffic.Count > 0)
                    {
                        string car = carsInTraffic.Peek();
                        if (green >= car.Length)
                        {
                            green -= car.Length;
                            carsInTraffic.Dequeue();
                            passedCars++;
                        }
                        else if(green < car.Length)
                        {
                            if (green + freeWindow < car.Length)
                            {
                                char crashChar = car[green + freeWindow];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {crashChar}.");
                                return;
                            }
                            else
                            {
                                passedCars++;
                                carsInTraffic.Dequeue();
                                green = 0;
                            }
                        }
                    }
                }
                else
                {
                    carsInTraffic.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");

        }
    }
}
