using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibonacci = GetFibonacci(n);

            Console.WriteLine(fibonacci);
        }

        static int GetFibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
           return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
