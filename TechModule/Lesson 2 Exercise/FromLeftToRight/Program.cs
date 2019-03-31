using System;
using System.Numerics;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                char del = ' ';

                string[] splitNumbers = input.Split(del);

                long leftNum = long.Parse(splitNumbers[0]);
                long rightNum = long.Parse(splitNumbers[1]);

                long biggerNum = leftNum;
                if (rightNum > biggerNum)
                {
                    biggerNum = rightNum;
                }

                long sum = 0;

                while (biggerNum != 0)
                {
                    sum += biggerNum % 10;
                    biggerNum /= 10;
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
