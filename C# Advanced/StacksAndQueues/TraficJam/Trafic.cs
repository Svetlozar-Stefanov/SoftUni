using System;
using System.Collections.Generic;

namespace TraficJam
{
    class Trafic
    {
        static void Main(string[] args)
        {
            int total = 0;
            int pass = int.Parse(Console.ReadLine());
            Queue<string> trafic = new Queue<string>();
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (input.ToLower() == "green")
                {
                    int carsToPass = Math.Min(trafic.Count, pass);
                    for (int i = 0; i < carsToPass; i++)
                    {
                        Console.WriteLine($"{trafic.Dequeue()} passed!");
                        total++;
                    }
                }
                else
                {
                    trafic.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{total} cars passed the crossroads.");
        }
    }
}
