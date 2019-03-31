using System;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            PrintTopNumbersInRange(range);
        }

        private static void PrintTopNumbersInRange(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                bool oddNum = false;
                int sum = 0;
                int number = i;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    if (lastDigit % 2 != 0)
                    {
                        oddNum = true;
                    }
                    sum += lastDigit;
                    number /= 10;
                }
                if (sum % 8 == 0 && oddNum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
