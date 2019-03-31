using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestModel = "";

            for (int i = 1; i <= numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (kegVolume > biggestKeg)
                {
                    biggestKeg = kegVolume;
                    biggestModel = kegModel;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
