using System;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = array.Length / 2;

            double racer1Time = 0;
            for (int i = 0; i < length; i++)
            {
                if (array[i] == 0)
                {
                    racer1Time *= 0.8;
                }
                else
                {
                    racer1Time += array[i];
                }
            }

            double racer2Time = 0;
            for (int i = array.Length-1; i > length; i--)
            {
                if (array[i] == 0)
                {
                    racer2Time *= 0.8;
                }
                else
                {
                    racer2Time += array[i];
                }
            }

            if (racer1Time < racer2Time)
            {
                Console.WriteLine($"The winner is left with total time: {racer1Time}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {racer2Time}");
            }
        }
    }
}
