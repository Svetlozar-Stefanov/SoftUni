using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCounter = 0;
            int halfPower = pokePower / 2;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCounter++;
                if (pokePower == halfPower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
               
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);
        }
    }
}
