using System;

namespace PrimeCheckerRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool prime = true;
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime.ToString().ToLower()}");
            }
        }
    }
}
