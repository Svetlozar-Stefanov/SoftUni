using System;

namespace TribonacchiSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] tribonacciArray = new int[num];

            GenerateTribonacci(tribonacciArray);
            Console.WriteLine(String.Join(" ", tribonacciArray));
        }

        private static void GenerateTribonacci(int[] tribonacciArray)
        {
            for (int i = 0; i < tribonacciArray.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    tribonacciArray[i] = 1;
                }
                else if (i == 2)
                {
                    tribonacciArray[i] = 2;
                }
                else
                {
                    tribonacciArray[i] = tribonacciArray[i - 3] + tribonacciArray[i - 2] + tribonacciArray[i - 1];
                }
            }
        }
    }
}
