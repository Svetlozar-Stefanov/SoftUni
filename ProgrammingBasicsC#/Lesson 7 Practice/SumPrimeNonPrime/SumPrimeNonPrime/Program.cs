using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            for (int i = 1; ; i++)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                bool isPrime = true;
                int n = int.Parse(command);

                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    if (n < 2)
                    {
                        nonPrimeSum += n;
                    }
                    for (int j = 2; j < n; j++)
                    {
                        if (n % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        primeSum += n;
                    }
                    else
                    {
                        nonPrimeSum += n;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
