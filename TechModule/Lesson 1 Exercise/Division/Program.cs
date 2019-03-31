using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 6 == 0)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                    return;
                }
                Console.WriteLine($"The number is divisible by 6");
                return;
            }
            else
            {
                if (num % 2 == 0)
                {
                    if (num % 10 == 0)
                    {
                        Console.WriteLine("The number is divisible by 10");
                        return;
                    }
                    Console.WriteLine("The number is divisible by 2");
                    return;
                }
                else if (num % 3 == 0)
                {
                    if (num % 7 == 0)
                    {
                        Console.WriteLine("The number is divisible by 7");
                        return;
                    }
                    Console.WriteLine("The number is divisible by 3");
                    return;
                }
            }
            if (num % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
