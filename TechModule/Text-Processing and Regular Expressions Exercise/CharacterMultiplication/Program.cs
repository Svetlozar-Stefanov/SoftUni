using System;

namespace CharacterMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string bigger = "";
            string smaller = "";
            int result = 0;

            if (input[0].Length >= input[1].Length)
            {
                bigger = input[0];
                smaller = input[1];
            }
            else
            {
                bigger = input[1];
                smaller = input[0];
            }

            int i;
            for (i = 0; i < smaller.Length; i++)
            {
                result += (bigger[i] * smaller[i]);
            }

            for (int j = i; j < bigger.Length; j++)
            {
                result += bigger[j];
            }

            Console.WriteLine(result);
        }
    }
}
