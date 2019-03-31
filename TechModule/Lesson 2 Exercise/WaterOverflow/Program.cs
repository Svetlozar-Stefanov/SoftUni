using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterCapacity = 0;
            for (int i = 0; i < n; i++)
            {
                int waterPoured = int.Parse(Console.ReadLine());

                if (waterPoured <= 255 && waterCapacity + waterPoured <= 255)
                {
                    waterCapacity += waterPoured;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterCapacity);
        }
    }
}
