using System;
using System.Numerics;

namespace Snowball
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = -1;
            int[] characteristics = new int[3];
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    characteristics[0] = snowballSnow;
                    characteristics[1] = snowballTime;
                    characteristics[2] = snowballQuality;
                }
            }

            Console.WriteLine($"{characteristics[0]} : {characteristics[1]} = {highestSnowballValue} ({characteristics[2]})");
        }
    }
}
