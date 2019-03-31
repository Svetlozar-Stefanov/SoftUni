using System;

namespace EvenNOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetEvenAndOddSub(number);
            Console.WriteLine(result);
        }

        private static int GetEvenAndOddSub(int number)
        {
            int sub = EvenSum(number) * OddSum(number);
            return sub;
        }

        private static int EvenSum(int number)
        {
            int evenSum = 0;
            while (number != 0)
            { 
                int lastDigit = Math.Abs(number % 10);
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                number /= 10;
            }
            return evenSum;
        }

        private static int OddSum(int number)
        {
            int oddSum = 0;
            while (number != 0)
            {
                int lastDigit =Math.Abs(number % 10);
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
                number /= 10;
            }
            return oddSum;
        }
    }
}
