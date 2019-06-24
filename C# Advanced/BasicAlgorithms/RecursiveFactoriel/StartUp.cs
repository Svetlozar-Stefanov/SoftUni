using System;

namespace RecursiveFactoriel
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factoriel(number));
        }

        private static int Factoriel(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factoriel(number - 1);
        }
    }
}
